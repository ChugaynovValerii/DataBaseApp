using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DataBaseApp
{
    public partial class AdminMainForm : Form
    {
        private OracleConnection connection;

        private DataGridViewRow changingProject;
        private DataGridViewRow changingRowDep;
        private DataGridViewRow changingRowEmp;


        public AdminMainForm(OracleConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            initProjects();
            initEmployees();
            initDepartments();
        }

        private void adminFormTabControl_Selected(object sender, TabControlEventArgs e)
        {
            editProjectsMode.Checked = false;
            cancelChangesWorkTypeButton.Text = "Посчитать прибыль";
            statGridView.Visible = false;
            editDepMode.Checked = false;
            editEmployeeMode.Checked = false;
        }

        private void numberTextBoxHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void percentTextBoxHandler(object sender, KeyPressEventArgs e)
        {
            TextBox senderBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && senderBox.Text.ToString().Length == 2)
            {
                e.Handled = true;
            }
        }
        private void initDepartments()
        {
            OracleCommand command = new OracleCommand("SELECT * FROM DEPARTMENTS", connection);
            OracleDataReader reader = command.ExecuteReader();
            departmentGridView.Rows.Clear();
            departmentComboBox.Items.Clear();
            while (reader.Read())
            {
                object[] row = { reader["ID"], reader["NAME"] };
                departmentGridView.Rows.Add(row);
                departmentComboBox.Items.Add(reader["NAME"]);
            }
            departmentGridView.Sort(departmentGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            departmentGridView.Rows[0].Selected = true;

            initDepEmp();
        }

        private void initDepEmp()
        {
            empInDepGridView.Rows.Clear();
            if (departmentGridView.SelectedRows.Count != 0)
            {
                string depID = departmentGridView.SelectedRows[0].Cells[0].Value.ToString();

                OracleCommand command = new OracleCommand("SELECT EMPLOYEES.ID ID, EMPLOYEES.FIRST_NAME N1, EMPLOYEES.LAST_NAME N2, EMPLOYEES.FATHER_NAME N3 FROM DEPARTMENTS_EMPLOYEES" +
                    " JOIN EMPLOYEES ON EMPLOYEES.ID=EMPLOYEE_ID WHERE DEPARTMENT_ID=:DEPARTMENT_ID", connection);
                command.Parameters.Add("DEPARTMENT_ID", depID);

                OracleDataReader reader = command.ExecuteReader();
                bool isRead = false;
                while (reader.Read())
                {
                    isRead = true;
                    object[] row = { reader["ID"], reader["N1"].ToString() + " " + reader["N2"].ToString() + " " + reader["N3"].ToString() };
                    empInDepGridView.Rows.Add(row);
                }
                if (isRead)
                {
                    empInDepGridView.Sort(empInDepGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    empInDepGridView.Rows[0].Selected = true;
                }
                empComboBox.Items.Clear();
                command = new OracleCommand("SELECT EMPLOYEES.FIRST_NAME N1, EMPLOYEES.LAST_NAME N2, EMPLOYEES.FATHER_NAME N3" +
                    " FROM EMPLOYEES JOIN (SELECT ID FROM EMPLOYEES MINUS SELECT EMPLOYEE_ID ID FROM DEPARTMENTS_EMPLOYEES WHERE DEPARTMENT_ID=:DEPARTMENT_ID) T" +
                    " ON T.ID=EMPLOYEES.ID", connection);
                command.Parameters.Add("DEPARTMENT_ID", depID);

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string row = reader["N1"].ToString() + " " + reader["N2"].ToString() + " " + reader["N3"].ToString();
                    empComboBox.Items.Add(row);
                }
            }
        }

        private void initProjects()
        {
            projectsDataGridView.Rows.Clear();
            OracleCommand command = new OracleCommand("SELECT PROJECTS.ID ID, PROJECTS.NAME NAME," +
                " COST, DEPARTMENTS.NAME DEP_NAME, DATE_BEG, DATE_END, DATE_END_REAL" +
                " FROM PROJECTS JOIN DEPARTMENTS ON DEPARTMENT_ID=DEPARTMENTS.ID", connection);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                object[] row = { reader["ID"], reader["NAME"], reader["COST"], reader["DEP_NAME"], reader["DATE_BEG"], reader["DATE_END"], reader["DATE_END_REAL"] };
                projectsDataGridView.Rows.Add(row);
            }
            projectsDataGridView.Sort(projectsDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            projectsDataGridView.Rows[0].Selected = true;
        }

        private void initEmployees()
        {
            employeeGridView.Rows.Clear();
            OracleCommand command = new OracleCommand("SELECT * FROM EMPLOYEES", connection);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                object[] row = { reader["ID"], reader["FIRST_NAME"], reader["LAST_NAME"], reader["FATHER_NAME"], reader["POSITION"], reader["SALARY"] };
                employeeGridView.Rows.Add(row);
            }
            employeeGridView.Sort(employeeGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            employeeGridView.Rows[0].Selected = true;
            initDepEmp();
        }

        private string getInsertedValue(string str)
        {
            if (str == "")
            {
                return "null";
            }
            else
            {
                return str;
            }
        }
        private void addProjectButton_Click(object sender, EventArgs e)
        {
            if (ProjectsToAddTextBox.Text == "" || costProjectToAdd.Text == "" || departmentComboBox.Text == "" || begDateToAdd.Text == "")
            {
                MessageBox.Show("Заполните все данные");
                return;
            }
            OracleCommand command;
            if (editProjectsMode.Checked)
            {

                command = new OracleCommand("UPDATE PROJECTS SET NAME=:NAME, COST=:COST," +
                    " DEPARTMENT_ID=(SELECT ID FROM DEPARTMENTS WHERE NAME=:DEPARTMENT_ID)," +
                " DATE_BEG=to_timestamp(:DATE_BEG, 'dd.mm.yyyy hh24:mi:ss')," +
                " DATE_END=to_timestamp(:DATE_END, 'dd.mm.yyyy hh24:mi:ss')," +
                " DATE_END_REAL=to_timestamp(:DATE_END_REAL, 'dd.mm.yyyy hh24:mi:ss')" +
                " WHERE ID=:ID", connection);
                
                command.Parameters.Add("NAME", getInsertedValue(ProjectsToAddTextBox.Text));
                command.Parameters.Add("COST", getInsertedValue(costProjectToAdd.Text));
                command.Parameters.Add("DEPARTMENT_ID", getInsertedValue(departmentComboBox.Text.ToString()));
                command.Parameters.Add("DATE_BEG", getInsertedValue(begDateToAdd.Text));
                command.Parameters.Add("DATE_END", getInsertedValue(endDateToAdd.Text));
               
                command.Parameters.Add("DATE_END_REAL", realEndDateToAdd.Text);
                
                command.Parameters.Add("ID", getInsertedValue(changingProject.Cells[0].Value.ToString()));

            }
            else
            {
                command = new OracleCommand("SELECT ID FROM DEPARTMENTS WHERE NAME=:DEPARTMENT_ID", connection);
                command.Parameters.Add("DEPARTMENT_ID", getInsertedValue(departmentComboBox.Text.ToString()));

                OracleDataReader reader = command.ExecuteReader();
                string id = "";
                if (reader.Read())
                {
                    id = reader["ID"].ToString();
                }
                reader.Close();
                if (realEndDateToAdd.Text == "")
                {
                    command = new OracleCommand("INSERT INTO PROJECTS (NAME, COST, DEPARTMENT_ID, DATE_BEG, DATE_END) VALUES(:NAME, :COST, "
                        + id +
                    ", to_timestamp(:DATE_BEG, 'dd.mm.yyyy hh24:mi:ss')," +
                    " to_timestamp(:DATE_END, 'dd.mm.yyyy hh24:mi:ss'))", connection);
                }
                else
                {
                    command = new OracleCommand("INSERT INTO PROJECTS (NAME, COST, DEPARTMENT_ID, DATE_BEG, DATE_END, DATE_END_REAL) VALUES(:NAME, :COST, "
                        + id +
                    ", to_timestamp(:DATE_BEG, 'dd.mm.yyyy hh24:mi:ss')," +
                    " to_timestamp(:DATE_END, 'dd.mm.yyyy hh24:mi:ss'), to_timestamp(:DATE_END_REAL, 'dd.mm.yyyy hh24:mi:ss'))", connection);
                }
                command.Parameters.Add("NAME", getInsertedValue(ProjectsToAddTextBox.Text));
                command.Parameters.Add("COST", getInsertedValue(costProjectToAdd.Text));
                command.Parameters.Add("DATE_BEG", getInsertedValue(begDateToAdd.Text));
                command.Parameters.Add("DATE_END", getInsertedValue(endDateToAdd.Text));
                if (realEndDateToAdd.Text != "")
                {
                    command.Parameters.Add("DATE_END_REAL", getInsertedValue(realEndDateToAdd.Text));
                }

            }
            command.ExecuteNonQuery();
            ProjectsToAddTextBox.Text = "";
            costProjectToAdd.Text = "";
            begDateToAdd.Text = "";
            endDateToAdd.Text = "";
            realEndDateToAdd.Text = "";
            projectsDataGridView.Rows.Clear();
            initProjects();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (firstNameToAddEmployee.Text == "" || lastNameToAddEmployee.Text == "" || salaryToAddEmployee.Text == "" || fatherNameToAddEmployee.Text == "" || positionToAddEmployee.Text == "")
            {
                MessageBox.Show("Заполните все данные");
                return;
            }

            OracleCommand command;
            if (editEmployeeMode.Checked)
            {
                command = new OracleCommand("UPDATE EMPLOYEES SET FIRST_NAME=:FIRST_NAME, LAST_NAME=:LAST_NAME, FATHER_NAME=:FATHER_NAME," +
                    " POSITION=:POSITION, SALARY=:SALARY " +
                    "WHERE ID=:ID", connection);
                command.Parameters.Add("FIRST_NAME", OracleDbType.Varchar2, 200).Value = getInsertedValue(firstNameToAddEmployee.Text);
                command.Parameters.Add("LAST_NAME", getInsertedValue(lastNameToAddEmployee.Text));
                command.Parameters.Add("FATHER_NAME", getInsertedValue(fatherNameToAddEmployee.Text));
                command.Parameters.Add("POSITION", getInsertedValue(positionToAddEmployee.Text));
                command.Parameters.Add("SALARY", getInsertedValue(salaryToAddEmployee.Text));
                command.Parameters.Add("ID", getInsertedValue(changingRowEmp.Cells[0].Value.ToString()));
            }
            else
            {
                command = new OracleCommand("INSERT INTO EMPLOYEES (FIRST_NAME, LAST_NAME, FATHER_NAME, POSITION, SALARY) VALUES(:FIRST_NAME, :LAST_NAME, :FATHER_NAME, :POSITION, :SALARY)", connection);
                command.Parameters.Add("FIRST_NAME", OracleDbType.Varchar2, 200).Value = getInsertedValue(firstNameToAddEmployee.Text);
                command.Parameters.Add("LAST_NAME", getInsertedValue(lastNameToAddEmployee.Text));
                command.Parameters.Add("FATHER_NAME", getInsertedValue(fatherNameToAddEmployee.Text));
                command.Parameters.Add("POSITION", getInsertedValue(positionToAddEmployee.Text));
                command.Parameters.Add("SALARY", getInsertedValue(salaryToAddEmployee.Text));
            }
            command.ExecuteNonQuery();
            fatherNameToAddEmployee.Text = "";
            lastNameToAddEmployee.Text = "";
            firstNameToAddEmployee.Text = "";
            positionToAddEmployee.Text = "";
            salaryToAddEmployee.Text = "";
            employeeGridView.Rows.Clear();
            initEmployees();
        }


        
        private void addDepButton_Click(object sender, EventArgs e)
        {
            if (depNameTextBox.Text == "")
            {
                MessageBox.Show("Введите название нового отдела!");
                return;
            }
            OracleCommand command;
            if (editDepMode.Checked)
            {
                command = new OracleCommand("UPDATE DEPARTMENTS SET NAME=:NAME " +
                    "WHERE ID=:ID", connection);
                command.Parameters.Add("NAME", OracleDbType.Varchar2, 200).Value = getInsertedValue(depNameTextBox.Text);
                command.Parameters.Add("ID", getInsertedValue(changingRowDep.Cells[0].Value.ToString()));

            }
            else
            {
                command = new OracleCommand("INSERT INTO DEPARTMENTS (NAME) VALUES(:NAME)", connection);
                command.Parameters.Add("NAME", OracleDbType.Varchar2, 200).Value = getInsertedValue(depNameTextBox.Text);
            }
            command.ExecuteNonQuery();
            depNameTextBox.Text = "";
            departmentGridView.Rows.Clear();
            initDepartments();
        }


        private void editEmployeeMode_CheckedChanged(object sender, EventArgs e)
        {
            if (editEmployeeMode.Checked && employeeGridView.SelectedCells.Count != 0)
            {
                deleteEmpButton.Visible = true;
                cancelEmployeeButton.Visible = true;
                addEmployeeButton.Text = "Изменить";
                changingRowEmp = employeeGridView.Rows[employeeGridView.SelectedCells[0].RowIndex];
                firstNameToAddEmployee.Text = changingRowEmp.Cells[1].Value.ToString();
                lastNameToAddEmployee.Text = changingRowEmp.Cells[2].Value.ToString();
                fatherNameToAddEmployee.Text = changingRowEmp.Cells[3].Value.ToString();
                positionToAddEmployee.Text = changingRowEmp.Cells[4].Value.ToString();
                salaryToAddEmployee.Text = changingRowEmp.Cells[5].Value.ToString();
            }
            else if (!editEmployeeMode.Checked)
            {
                deleteEmpButton.Visible = false;
                cancelEmployeeButton.Visible = false;
                addEmployeeButton.Text = "Добавить";
                firstNameToAddEmployee.Text = "";
                lastNameToAddEmployee.Text = "";
                fatherNameToAddEmployee.Text = "";
                salaryToAddEmployee.Text = "";
                positionToAddEmployee.Text = "";
            }
        }


        private void signOut_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }


        private void editProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (editProjectsMode.Checked && projectsDataGridView.SelectedCells.Count != 0)
            {
                deleteProjectButton.Visible = true;
                statGridView.Visible = false;
                cancelChangesWorkTypeButton.Text = "Отменить";
                addWorkTypeButton.Text = "Изменить";
                changingProject = projectsDataGridView.Rows[projectsDataGridView.SelectedCells[0].RowIndex];
                ProjectsToAddTextBox.Text = changingProject.Cells[1].Value.ToString();
                costProjectToAdd.Text = changingProject.Cells[2].Value.ToString();
                departmentComboBox.Text = changingProject.Cells[3].Value.ToString();
                begDateToAdd.Text = changingProject.Cells[4].Value.ToString();
                endDateToAdd.Text = changingProject.Cells[5].Value.ToString();
                realEndDateToAdd.Text = changingProject.Cells[6].Value.ToString();
            }
            else if (!editProjectsMode.Checked)
            {
                deleteProjectButton.Visible = false;
                if (cancelChangesWorkTypeButton.Text != "Посмотреть всё")
                {
                    cancelChangesWorkTypeButton.Text = "Посчитать прибыль";
                }
                addWorkTypeButton.Text = "Добавить";
                ProjectsToAddTextBox.Text = "";
                costProjectToAdd.Text = "";
                begDateToAdd.Text = "";
                endDateToAdd.Text = "";
                realEndDateToAdd.Text = "";
            }

        }

        private void editDepMode_CheckedChanged(object sender, EventArgs e)
        {
            initDepEmp();
            if (editDepMode.Checked && departmentGridView.SelectedCells.Count != 0)
            {
                deleteDepButton.Visible = true;
                empComboBox.Visible = false;
                cancelDepButton.Visible = true;
                deleteFromDepButton.Visible = true;
                addEmpToDepButton.Visible = false;
                addDepButton.Text = "Изменить";
                changingRowDep = departmentGridView.Rows[departmentGridView.SelectedCells[0].RowIndex];
                depNameTextBox.Text = changingRowDep.Cells[1].Value.ToString();
            }
            else if (!editDepMode.Checked)
            {
                deleteDepButton.Visible = false;
                addEmpToDepButton.Visible = true;
                deleteFromDepButton.Visible = false;
                empComboBox.Visible = true;
                cancelDepButton.Visible = false;
                addDepButton.Text = "Добавить";
                depNameTextBox.Text = "";
            }
        }

        private void addEmpToDepButton_Click(object sender, EventArgs e)
        {
            if (empComboBox.Text.ToString() == "")
            {
                MessageBox.Show("Чтобы добавить сотрудника в отдел, выберете сотрудника!");
                return;
            }
            if (departmentGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Чтобы добавить сотрудника в отдел, выберете отдел!");
                return;
            }
            OracleCommand command = new OracleCommand("SELECT ID FROM EMPLOYEES WHERE" +
                " FIRST_NAME=:FIRST_NAME AND" +
                " LAST_NAME=:LAST_NAME AND" +
                " FATHER_NAME=:FATHER_NAME", connection);
            string[] name = empComboBox.Text.ToString().Split(' ');
            command.Parameters.Add("FIRST_NAME", name[0]);
            command.Parameters.Add("LAST_NAME", name[1]);
            command.Parameters.Add("FATHER_NAME", name[2]);
            OracleDataReader reader = command.ExecuteReader();
            string id = "";
            if (reader.Read())
            {
                id = reader["ID"].ToString();
            }
            if (id != "")
            {
                command = new OracleCommand("INSERT INTO DEPARTMENTS_EMPLOYEES (DEPARTMENT_ID, EMPLOYEE_ID) VALUES(:DEPARTMENT_ID, :EMPLOYEE_ID)", connection);
                command.Parameters.Add("DEPARTMENT_ID", getInsertedValue(departmentGridView.SelectedRows[0].Cells[0].Value.ToString()));
                command.Parameters.Add("EMPLOYEE_ID", id);
                command.ExecuteNonQuery();
            }
            initDepEmp();
        }

        private void deleteFromDepButton_Click(object sender, EventArgs e)
        {
            if (departmentGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Чтобы удалить сотрудника из отдела, выберете отдел!");
                return;
            }
            if (empInDepGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Чтобы удалить сотрудника из отдела, выберете сотрудника из таблицы выше!");
                return;
            }

            OracleCommand command = new OracleCommand("DELETE FROM DEPARTMENTS_EMPLOYEES WHERE DEPARTMENT_ID=:DEPARTMENT_ID AND EMPLOYEE_ID=:EMPLOYEE_ID", connection);
            command.Parameters.Add("DEPARTMENT_ID", departmentGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.Parameters.Add("EMPLOYEE_ID", empInDepGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();

            initDepEmp();
        }

        private void deleteDep_Click(object sender, EventArgs e)
        {
            if (departmentGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Чтобы удалить отдел, выберете отдел из таблицы левее!");
                return;
            }
            OracleCommand command = new OracleCommand("SELECT ID FROM PROJECTS WHERE DEPARTMENT_ID=:DEPARTMENT_ID", connection);
            command.Parameters.Add("DEPARTMENT_ID", departmentGridView.SelectedRows[0].Cells[0].Value.ToString());
            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Этот отдел работает над проектом ID=" + reader["ID"] + ". Чтобы удалить этот отдел переназначьте отдел для этого проекта");
                return;
            }

            command = new OracleCommand("DELETE FROM DEPARTMENTS_EMPLOYEES WHERE DEPARTMENT_ID=:DEPARTMENT_ID", connection);
            command.Parameters.Add("DEPARTMENT_ID", departmentGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            command = new OracleCommand("DELETE FROM DEPARTMENTS WHERE ID=:DEPARTMENT_ID", connection);
            command.Parameters.Add("DEPARTMENT_ID", departmentGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            initDepartments();
        }

        private void deleteEmpButton_Click(object sender, EventArgs e)
        {
            if (employeeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Чтобы удалить сотрудника, выберете сотрудника из таблицы правее!");
                return;
            }

            OracleCommand command = new OracleCommand("DELETE FROM DEPARTMENTS_EMPLOYEES WHERE EMPLOYEE_ID=:EMPLOYEE_ID", connection);
            command.Parameters.Add("EMPLOYEE_ID", employeeGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            command = new OracleCommand("DELETE FROM EMPLOYEES WHERE ID=:EMPLOYEE_ID", connection);
            command.Parameters.Add("EMPLOYEE_ID", employeeGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            initEmployees();
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Чтобы удалить проект, выберете проект из таблицы правее!");
                return;
            }

            OracleCommand command = new OracleCommand("DELETE FROM PROJECTS WHERE ID=:ID", connection);
            command.Parameters.Add("ID", projectsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            initProjects();
        }


        private void calculateEarnings()
        {
            OracleCommand command = new OracleCommand("SELECT ID, NAME, DEP, DATE_END, COST, SPENDING, COST - SPENDING EARNINGS" +
                " FROM (SELECT ID, NAME, DATE_END, (SELECT NAME FROM DEPARTMENTS WHERE ID=PROJECTS.DEPARTMENT_ID) DEP, COST, SALARIES.SALARY * TRUNC(MONTHS_BETWEEN(GREATEST(SYSDATE, DATE_END), DATE_BEG)) SPENDING" +
                " FROM PROJECTS" +
                " LEFT JOIN (SELECT DEPARTMENT_ID, SUM(SALARY) SALARY" +
                " FROM EMPLOYEES JOIN DEPARTMENTS_EMPLOYEES ON EMPLOYEES.ID = DEPARTMENTS_EMPLOYEES.EMPLOYEE_ID GROUP BY (DEPARTMENT_ID)) SALARIES" +
                " ON SALARIES.DEPARTMENT_ID = PROJECTS.DEPARTMENT_ID WHERE DATE_END_REAL IS NULL)", connection);
            OracleDataReader reader = command.ExecuteReader();
            statGridView.Rows.Clear();
            while (reader.Read())
            {
                object[] row = { reader["ID"], reader["NAME"], reader["DEP"], reader["DATE_END"], reader["COST"], reader["SPENDING"], reader["EARNINGS"] };
                statGridView.Rows.Add(row);
            }
            statGridView.Sort(statGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
            statGridView.Rows[0].Selected = true;
        }
        private void cancelChangesWorkTypeButton_Click(object sender, EventArgs e)
        {
            if (cancelChangesWorkTypeButton.Text == "Посчитать прибыль")
            {
                statGridView.Visible = true;
                cancelChangesWorkTypeButton.Text = "Посмотреть всё";
                calculateEarnings();
            }
            else if(cancelChangesWorkTypeButton.Text == "Посмотреть всё")
            {
                statGridView.Visible = false;
                cancelChangesWorkTypeButton.Text = "Посчитать прибыль";
            }
            editProjects_CheckedChanged(sender, e);
        }
    }
}
