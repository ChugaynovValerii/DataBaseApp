namespace DataBaseApp
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.deleteEmpButton = new System.Windows.Forms.Button();
            this.positionToAddEmployee = new CueTextBox();
            this.fatherNameToAddEmployee = new CueTextBox();
            this.lastNameToAddEmployee = new CueTextBox();
            this.salaryToAddEmployee = new CueTextBox();
            this.firstNameToAddEmployee = new CueTextBox();
            this.cancelEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeMode = new System.Windows.Forms.CheckBox();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.IDEmployeeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumnEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumnEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameEmpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumnEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryColumnEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.departmentsPage = new System.Windows.Forms.TabPage();
            this.deleteDepButton = new System.Windows.Forms.Button();
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.deleteFromDepButton = new System.Windows.Forms.Button();
            this.addEmpToDepButton = new System.Windows.Forms.Button();
            this.empInDepGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNameTextBox = new CueTextBox();
            this.cancelDepButton = new System.Windows.Forms.Button();
            this.editDepMode = new System.Windows.Forms.CheckBox();
            this.departmentGridView = new System.Windows.Forms.DataGridView();
            this.departmentIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDepButton = new System.Windows.Forms.Button();
            this.projectsPage = new System.Windows.Forms.TabPage();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.cancelChangesWorkTypeButton = new System.Windows.Forms.Button();
            this.editProjectsMode = new System.Windows.Forms.CheckBox();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.IDprojCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realDateEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addWorkTypeButton = new System.Windows.Forms.Button();
            this.realEndDateToAdd = new CueTextBox();
            this.endDateToAdd = new CueTextBox();
            this.begDateToAdd = new CueTextBox();
            this.costProjectToAdd = new CueTextBox();
            this.ProjectsToAddTextBox = new CueTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.signOut = new System.Windows.Forms.Button();
            this.adminFormTabControl = new System.Windows.Forms.TabControl();
            this.statGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.departmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empInDepGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView)).BeginInit();
            this.projectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.adminFormTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesPage
            // 
            this.employeesPage.BackColor = System.Drawing.Color.Thistle;
            this.employeesPage.Controls.Add(this.deleteEmpButton);
            this.employeesPage.Controls.Add(this.positionToAddEmployee);
            this.employeesPage.Controls.Add(this.fatherNameToAddEmployee);
            this.employeesPage.Controls.Add(this.lastNameToAddEmployee);
            this.employeesPage.Controls.Add(this.salaryToAddEmployee);
            this.employeesPage.Controls.Add(this.firstNameToAddEmployee);
            this.employeesPage.Controls.Add(this.cancelEmployeeButton);
            this.employeesPage.Controls.Add(this.editEmployeeMode);
            this.employeesPage.Controls.Add(this.employeeGridView);
            this.employeesPage.Controls.Add(this.addEmployeeButton);
            this.employeesPage.Location = new System.Drawing.Point(4, 25);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Size = new System.Drawing.Size(1203, 531);
            this.employeesPage.TabIndex = 4;
            this.employeesPage.Text = "Работники";
            // 
            // deleteEmpButton
            // 
            this.deleteEmpButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmpButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEmpButton.Location = new System.Drawing.Point(64, 343);
            this.deleteEmpButton.Name = "deleteEmpButton";
            this.deleteEmpButton.Size = new System.Drawing.Size(320, 43);
            this.deleteEmpButton.TabIndex = 31;
            this.deleteEmpButton.Text = "Удалить работника";
            this.deleteEmpButton.UseVisualStyleBackColor = false;
            this.deleteEmpButton.Visible = false;
            this.deleteEmpButton.Click += new System.EventHandler(this.deleteEmpButton_Click);
            // 
            // positionToAddEmployee
            // 
            this.positionToAddEmployee.Cue = "Должность";
            this.positionToAddEmployee.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionToAddEmployee.Location = new System.Drawing.Point(64, 242);
            this.positionToAddEmployee.Name = "positionToAddEmployee";
            this.positionToAddEmployee.Size = new System.Drawing.Size(320, 44);
            this.positionToAddEmployee.TabIndex = 24;
            // 
            // fatherNameToAddEmployee
            // 
            this.fatherNameToAddEmployee.Cue = "Отчество";
            this.fatherNameToAddEmployee.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatherNameToAddEmployee.Location = new System.Drawing.Point(64, 192);
            this.fatherNameToAddEmployee.Name = "fatherNameToAddEmployee";
            this.fatherNameToAddEmployee.Size = new System.Drawing.Size(320, 44);
            this.fatherNameToAddEmployee.TabIndex = 23;
            // 
            // lastNameToAddEmployee
            // 
            this.lastNameToAddEmployee.Cue = "Фамилия";
            this.lastNameToAddEmployee.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameToAddEmployee.Location = new System.Drawing.Point(64, 142);
            this.lastNameToAddEmployee.Name = "lastNameToAddEmployee";
            this.lastNameToAddEmployee.Size = new System.Drawing.Size(320, 44);
            this.lastNameToAddEmployee.TabIndex = 19;
            // 
            // salaryToAddEmployee
            // 
            this.salaryToAddEmployee.Cue = "Зар. плата";
            this.salaryToAddEmployee.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryToAddEmployee.Location = new System.Drawing.Point(64, 292);
            this.salaryToAddEmployee.Name = "salaryToAddEmployee";
            this.salaryToAddEmployee.Size = new System.Drawing.Size(320, 44);
            this.salaryToAddEmployee.TabIndex = 17;
            this.salaryToAddEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBoxHandler);
            // 
            // firstNameToAddEmployee
            // 
            this.firstNameToAddEmployee.Cue = "Имя";
            this.firstNameToAddEmployee.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameToAddEmployee.Location = new System.Drawing.Point(64, 90);
            this.firstNameToAddEmployee.Name = "firstNameToAddEmployee";
            this.firstNameToAddEmployee.Size = new System.Drawing.Size(320, 44);
            this.firstNameToAddEmployee.TabIndex = 15;
            // 
            // cancelEmployeeButton
            // 
            this.cancelEmployeeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEmployeeButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelEmployeeButton.Location = new System.Drawing.Point(64, 392);
            this.cancelEmployeeButton.Name = "cancelEmployeeButton";
            this.cancelEmployeeButton.Size = new System.Drawing.Size(320, 43);
            this.cancelEmployeeButton.TabIndex = 22;
            this.cancelEmployeeButton.Text = "Отменить";
            this.cancelEmployeeButton.UseVisualStyleBackColor = false;
            this.cancelEmployeeButton.Visible = false;
            this.cancelEmployeeButton.Click += new System.EventHandler(this.editEmployeeMode_CheckedChanged);
            // 
            // editEmployeeMode
            // 
            this.editEmployeeMode.AutoSize = true;
            this.editEmployeeMode.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEmployeeMode.Location = new System.Drawing.Point(64, 46);
            this.editEmployeeMode.Name = "editEmployeeMode";
            this.editEmployeeMode.Size = new System.Drawing.Size(320, 39);
            this.editEmployeeMode.TabIndex = 21;
            this.editEmployeeMode.Text = "Режим редактирования";
            this.editEmployeeMode.UseVisualStyleBackColor = true;
            this.editEmployeeMode.CheckedChanged += new System.EventHandler(this.editEmployeeMode_CheckedChanged);
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToAddRows = false;
            this.employeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmployeeCol,
            this.firstNameColumnEmployees,
            this.lastNameColumnEmployees,
            this.fatherNameEmpCol,
            this.positionColumnEmployees,
            this.salaryColumnEmployees});
            this.employeeGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.employeeGridView.Location = new System.Drawing.Point(438, 0);
            this.employeeGridView.MultiSelect = false;
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.RowHeadersWidth = 51;
            this.employeeGridView.RowTemplate.Height = 24;
            this.employeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGridView.Size = new System.Drawing.Size(765, 531);
            this.employeeGridView.TabIndex = 20;
            this.employeeGridView.SelectionChanged += new System.EventHandler(this.editEmployeeMode_CheckedChanged);
            // 
            // IDEmployeeCol
            // 
            this.IDEmployeeCol.FillWeight = 32.08556F;
            this.IDEmployeeCol.HeaderText = "ID";
            this.IDEmployeeCol.MinimumWidth = 6;
            this.IDEmployeeCol.Name = "IDEmployeeCol";
            this.IDEmployeeCol.ReadOnly = true;
            // 
            // firstNameColumnEmployees
            // 
            this.firstNameColumnEmployees.FillWeight = 113.5829F;
            this.firstNameColumnEmployees.HeaderText = "Имя";
            this.firstNameColumnEmployees.MinimumWidth = 6;
            this.firstNameColumnEmployees.Name = "firstNameColumnEmployees";
            this.firstNameColumnEmployees.ReadOnly = true;
            // 
            // lastNameColumnEmployees
            // 
            this.lastNameColumnEmployees.FillWeight = 113.5829F;
            this.lastNameColumnEmployees.HeaderText = "Фамилия";
            this.lastNameColumnEmployees.MinimumWidth = 6;
            this.lastNameColumnEmployees.Name = "lastNameColumnEmployees";
            this.lastNameColumnEmployees.ReadOnly = true;
            // 
            // fatherNameEmpCol
            // 
            this.fatherNameEmpCol.FillWeight = 113.5829F;
            this.fatherNameEmpCol.HeaderText = "Отчетство";
            this.fatherNameEmpCol.MinimumWidth = 6;
            this.fatherNameEmpCol.Name = "fatherNameEmpCol";
            this.fatherNameEmpCol.ReadOnly = true;
            // 
            // positionColumnEmployees
            // 
            this.positionColumnEmployees.FillWeight = 113.5829F;
            this.positionColumnEmployees.HeaderText = "Должность";
            this.positionColumnEmployees.MinimumWidth = 6;
            this.positionColumnEmployees.Name = "positionColumnEmployees";
            this.positionColumnEmployees.ReadOnly = true;
            // 
            // salaryColumnEmployees
            // 
            this.salaryColumnEmployees.FillWeight = 113.5829F;
            this.salaryColumnEmployees.HeaderText = "Зар. плата";
            this.salaryColumnEmployees.MinimumWidth = 6;
            this.salaryColumnEmployees.Name = "salaryColumnEmployees";
            this.salaryColumnEmployees.ReadOnly = true;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.SpringGreen;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployeeButton.Location = new System.Drawing.Point(64, 441);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(320, 43);
            this.addEmployeeButton.TabIndex = 16;
            this.addEmployeeButton.Text = "Добавить";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // departmentsPage
            // 
            this.departmentsPage.BackColor = System.Drawing.Color.Thistle;
            this.departmentsPage.Controls.Add(this.deleteDepButton);
            this.departmentsPage.Controls.Add(this.empComboBox);
            this.departmentsPage.Controls.Add(this.deleteFromDepButton);
            this.departmentsPage.Controls.Add(this.addEmpToDepButton);
            this.departmentsPage.Controls.Add(this.empInDepGridView);
            this.departmentsPage.Controls.Add(this.depNameTextBox);
            this.departmentsPage.Controls.Add(this.cancelDepButton);
            this.departmentsPage.Controls.Add(this.editDepMode);
            this.departmentsPage.Controls.Add(this.departmentGridView);
            this.departmentsPage.Controls.Add(this.addDepButton);
            this.departmentsPage.Location = new System.Drawing.Point(4, 25);
            this.departmentsPage.Name = "departmentsPage";
            this.departmentsPage.Size = new System.Drawing.Size(1203, 531);
            this.departmentsPage.TabIndex = 2;
            this.departmentsPage.Text = "Отделы";
            // 
            // deleteDepButton
            // 
            this.deleteDepButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteDepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDepButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDepButton.Location = new System.Drawing.Point(273, 355);
            this.deleteDepButton.Name = "deleteDepButton";
            this.deleteDepButton.Size = new System.Drawing.Size(320, 43);
            this.deleteDepButton.TabIndex = 30;
            this.deleteDepButton.Text = "Удалить отдел";
            this.deleteDepButton.UseVisualStyleBackColor = false;
            this.deleteDepButton.Visible = false;
            this.deleteDepButton.Click += new System.EventHandler(this.deleteDep_Click);
            // 
            // empComboBox
            // 
            this.empComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empComboBox.Font = new System.Drawing.Font("Calibri", 17F);
            this.empComboBox.FormattingEnabled = true;
            this.empComboBox.IntegralHeight = false;
            this.empComboBox.Location = new System.Drawing.Point(609, 305);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(594, 43);
            this.empComboBox.TabIndex = 29;
            // 
            // deleteFromDepButton
            // 
            this.deleteFromDepButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteFromDepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromDepButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFromDepButton.Location = new System.Drawing.Point(609, 355);
            this.deleteFromDepButton.Name = "deleteFromDepButton";
            this.deleteFromDepButton.Size = new System.Drawing.Size(598, 43);
            this.deleteFromDepButton.TabIndex = 22;
            this.deleteFromDepButton.Text = "Удалить работника из отдела";
            this.deleteFromDepButton.UseVisualStyleBackColor = false;
            this.deleteFromDepButton.Visible = false;
            this.deleteFromDepButton.Click += new System.EventHandler(this.deleteFromDepButton_Click);
            // 
            // addEmpToDepButton
            // 
            this.addEmpToDepButton.BackColor = System.Drawing.Color.SpringGreen;
            this.addEmpToDepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpToDepButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmpToDepButton.Location = new System.Drawing.Point(609, 453);
            this.addEmpToDepButton.Name = "addEmpToDepButton";
            this.addEmpToDepButton.Size = new System.Drawing.Size(594, 43);
            this.addEmpToDepButton.TabIndex = 20;
            this.addEmpToDepButton.Text = "Добавить работника в отдел";
            this.addEmpToDepButton.UseVisualStyleBackColor = false;
            this.addEmpToDepButton.Click += new System.EventHandler(this.addEmpToDepButton_Click);
            // 
            // empInDepGridView
            // 
            this.empInDepGridView.AllowUserToAddRows = false;
            this.empInDepGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empInDepGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empInDepGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.empInDepGridView.Location = new System.Drawing.Point(609, 0);
            this.empInDepGridView.MultiSelect = false;
            this.empInDepGridView.Name = "empInDepGridView";
            this.empInDepGridView.ReadOnly = true;
            this.empInDepGridView.RowHeadersWidth = 51;
            this.empInDepGridView.RowTemplate.Height = 24;
            this.empInDepGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empInDepGridView.Size = new System.Drawing.Size(598, 256);
            this.empInDepGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 21.39038F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 178.6097F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // depNameTextBox
            // 
            this.depNameTextBox.Cue = "Название";
            this.depNameTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depNameTextBox.Location = new System.Drawing.Point(273, 305);
            this.depNameTextBox.Name = "depNameTextBox";
            this.depNameTextBox.Size = new System.Drawing.Size(320, 44);
            this.depNameTextBox.TabIndex = 18;
            // 
            // cancelDepButton
            // 
            this.cancelDepButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelDepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelDepButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelDepButton.Location = new System.Drawing.Point(273, 404);
            this.cancelDepButton.Name = "cancelDepButton";
            this.cancelDepButton.Size = new System.Drawing.Size(320, 43);
            this.cancelDepButton.TabIndex = 17;
            this.cancelDepButton.Text = "Отменить изменения";
            this.cancelDepButton.UseVisualStyleBackColor = false;
            this.cancelDepButton.Visible = false;
            this.cancelDepButton.Click += new System.EventHandler(this.editDepMode_CheckedChanged);
            // 
            // editDepMode
            // 
            this.editDepMode.AutoSize = true;
            this.editDepMode.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDepMode.Location = new System.Drawing.Point(273, 58);
            this.editDepMode.Name = "editDepMode";
            this.editDepMode.Size = new System.Drawing.Size(320, 39);
            this.editDepMode.TabIndex = 16;
            this.editDepMode.Text = "Режим редактирования";
            this.editDepMode.UseVisualStyleBackColor = true;
            this.editDepMode.CheckedChanged += new System.EventHandler(this.editDepMode_CheckedChanged);
            // 
            // departmentGridView
            // 
            this.departmentGridView.AllowUserToAddRows = false;
            this.departmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDCol,
            this.depNameColumn});
            this.departmentGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.departmentGridView.Location = new System.Drawing.Point(0, 0);
            this.departmentGridView.MultiSelect = false;
            this.departmentGridView.Name = "departmentGridView";
            this.departmentGridView.ReadOnly = true;
            this.departmentGridView.RowHeadersWidth = 51;
            this.departmentGridView.RowTemplate.Height = 24;
            this.departmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentGridView.Size = new System.Drawing.Size(258, 531);
            this.departmentGridView.TabIndex = 15;
            this.departmentGridView.SelectionChanged += new System.EventHandler(this.editDepMode_CheckedChanged);
            // 
            // departmentIDCol
            // 
            this.departmentIDCol.FillWeight = 42.78076F;
            this.departmentIDCol.HeaderText = "ID";
            this.departmentIDCol.MinimumWidth = 6;
            this.departmentIDCol.Name = "departmentIDCol";
            this.departmentIDCol.ReadOnly = true;
            this.departmentIDCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // depNameColumn
            // 
            this.depNameColumn.FillWeight = 157.2193F;
            this.depNameColumn.HeaderText = "Название отдела";
            this.depNameColumn.MinimumWidth = 6;
            this.depNameColumn.Name = "depNameColumn";
            this.depNameColumn.ReadOnly = true;
            this.depNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addDepButton
            // 
            this.addDepButton.BackColor = System.Drawing.Color.SpringGreen;
            this.addDepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDepButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDepButton.Location = new System.Drawing.Point(273, 453);
            this.addDepButton.Name = "addDepButton";
            this.addDepButton.Size = new System.Drawing.Size(320, 43);
            this.addDepButton.TabIndex = 12;
            this.addDepButton.Text = "Добавить отдел";
            this.addDepButton.UseVisualStyleBackColor = false;
            this.addDepButton.Click += new System.EventHandler(this.addDepButton_Click);
            // 
            // projectsPage
            // 
            this.projectsPage.BackColor = System.Drawing.Color.Thistle;
            this.projectsPage.Controls.Add(this.statGridView);
            this.projectsPage.Controls.Add(this.deleteProjectButton);
            this.projectsPage.Controls.Add(this.departmentComboBox);
            this.projectsPage.Controls.Add(this.cancelChangesWorkTypeButton);
            this.projectsPage.Controls.Add(this.editProjectsMode);
            this.projectsPage.Controls.Add(this.projectsDataGridView);
            this.projectsPage.Controls.Add(this.addWorkTypeButton);
            this.projectsPage.Controls.Add(this.realEndDateToAdd);
            this.projectsPage.Controls.Add(this.endDateToAdd);
            this.projectsPage.Controls.Add(this.begDateToAdd);
            this.projectsPage.Controls.Add(this.costProjectToAdd);
            this.projectsPage.Controls.Add(this.ProjectsToAddTextBox);
            this.projectsPage.Location = new System.Drawing.Point(4, 25);
            this.projectsPage.Name = "projectsPage";
            this.projectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsPage.Size = new System.Drawing.Size(1203, 531);
            this.projectsPage.TabIndex = 1;
            this.projectsPage.Text = "Проекты";
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProjectButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProjectButton.Location = new System.Drawing.Point(57, 365);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(320, 43);
            this.deleteProjectButton.TabIndex = 32;
            this.deleteProjectButton.Text = "Удалить проект";
            this.deleteProjectButton.UseVisualStyleBackColor = false;
            this.deleteProjectButton.Visible = false;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentComboBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.IntegralHeight = false;
            this.departmentComboBox.Location = new System.Drawing.Point(57, 318);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(320, 41);
            this.departmentComboBox.TabIndex = 28;
            // 
            // cancelChangesWorkTypeButton
            // 
            this.cancelChangesWorkTypeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelChangesWorkTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelChangesWorkTypeButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelChangesWorkTypeButton.Location = new System.Drawing.Point(57, 414);
            this.cancelChangesWorkTypeButton.Name = "cancelChangesWorkTypeButton";
            this.cancelChangesWorkTypeButton.Size = new System.Drawing.Size(320, 43);
            this.cancelChangesWorkTypeButton.TabIndex = 14;
            this.cancelChangesWorkTypeButton.Text = "Посчитать прибыль";
            this.cancelChangesWorkTypeButton.UseVisualStyleBackColor = false;
            this.cancelChangesWorkTypeButton.Click += new System.EventHandler(this.cancelChangesWorkTypeButton_Click);
            // 
            // editProjectsMode
            // 
            this.editProjectsMode.AutoSize = true;
            this.editProjectsMode.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProjectsMode.Location = new System.Drawing.Point(57, 23);
            this.editProjectsMode.Name = "editProjectsMode";
            this.editProjectsMode.Size = new System.Drawing.Size(320, 39);
            this.editProjectsMode.TabIndex = 13;
            this.editProjectsMode.Text = "Режим редактирования";
            this.editProjectsMode.UseVisualStyleBackColor = true;
            this.editProjectsMode.CheckedChanged += new System.EventHandler(this.editProjects_CheckedChanged);
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AllowUserToAddRows = false;
            this.projectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDprojCol,
            this.workTypeColumnName,
            this.costColumn,
            this.departmentID,
            this.dateBeginColumn,
            this.dateEndColumn,
            this.realDateEndColumn});
            this.projectsDataGridView.Location = new System.Drawing.Point(432, 3);
            this.projectsDataGridView.MultiSelect = false;
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.ReadOnly = true;
            this.projectsDataGridView.RowHeadersWidth = 51;
            this.projectsDataGridView.RowTemplate.Height = 24;
            this.projectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectsDataGridView.Size = new System.Drawing.Size(768, 525);
            this.projectsDataGridView.TabIndex = 11;
            this.projectsDataGridView.SelectionChanged += new System.EventHandler(this.editProjects_CheckedChanged);
            // 
            // IDprojCol
            // 
            this.IDprojCol.FillWeight = 38.50267F;
            this.IDprojCol.HeaderText = "ID";
            this.IDprojCol.MinimumWidth = 6;
            this.IDprojCol.Name = "IDprojCol";
            this.IDprojCol.ReadOnly = true;
            // 
            // workTypeColumnName
            // 
            this.workTypeColumnName.FillWeight = 113.5829F;
            this.workTypeColumnName.HeaderText = "Название";
            this.workTypeColumnName.MinimumWidth = 6;
            this.workTypeColumnName.Name = "workTypeColumnName";
            this.workTypeColumnName.ReadOnly = true;
            // 
            // costColumn
            // 
            this.costColumn.FillWeight = 113.5829F;
            this.costColumn.HeaderText = "Стоимость";
            this.costColumn.MinimumWidth = 6;
            this.costColumn.Name = "costColumn";
            this.costColumn.ReadOnly = true;
            // 
            // departmentID
            // 
            this.departmentID.FillWeight = 93.58288F;
            this.departmentID.HeaderText = "Отдел";
            this.departmentID.MinimumWidth = 6;
            this.departmentID.Name = "departmentID";
            this.departmentID.ReadOnly = true;
            // 
            // dateBeginColumn
            // 
            this.dateBeginColumn.FillWeight = 113.5829F;
            this.dateBeginColumn.HeaderText = "Дата начала";
            this.dateBeginColumn.MinimumWidth = 6;
            this.dateBeginColumn.Name = "dateBeginColumn";
            this.dateBeginColumn.ReadOnly = true;
            // 
            // dateEndColumn
            // 
            this.dateEndColumn.FillWeight = 113.5829F;
            this.dateEndColumn.HeaderText = "Дата окончания";
            this.dateEndColumn.MinimumWidth = 6;
            this.dateEndColumn.Name = "dateEndColumn";
            this.dateEndColumn.ReadOnly = true;
            // 
            // realDateEndColumn
            // 
            this.realDateEndColumn.FillWeight = 113.5829F;
            this.realDateEndColumn.HeaderText = "Реальная дата окончания";
            this.realDateEndColumn.MinimumWidth = 6;
            this.realDateEndColumn.Name = "realDateEndColumn";
            this.realDateEndColumn.ReadOnly = true;
            // 
            // addWorkTypeButton
            // 
            this.addWorkTypeButton.BackColor = System.Drawing.Color.SpringGreen;
            this.addWorkTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkTypeButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWorkTypeButton.Location = new System.Drawing.Point(57, 463);
            this.addWorkTypeButton.Name = "addWorkTypeButton";
            this.addWorkTypeButton.Size = new System.Drawing.Size(320, 43);
            this.addWorkTypeButton.TabIndex = 10;
            this.addWorkTypeButton.Text = "Добавить";
            this.addWorkTypeButton.UseVisualStyleBackColor = false;
            this.addWorkTypeButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // realEndDateToAdd
            // 
            this.realEndDateToAdd.Cue = "Итоговая дата конца";
            this.realEndDateToAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realEndDateToAdd.Location = new System.Drawing.Point(57, 268);
            this.realEndDateToAdd.Name = "realEndDateToAdd";
            this.realEndDateToAdd.Size = new System.Drawing.Size(320, 44);
            this.realEndDateToAdd.TabIndex = 18;
            // 
            // endDateToAdd
            // 
            this.endDateToAdd.Cue = "Дата конца";
            this.endDateToAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateToAdd.Location = new System.Drawing.Point(57, 218);
            this.endDateToAdd.Name = "endDateToAdd";
            this.endDateToAdd.Size = new System.Drawing.Size(320, 44);
            this.endDateToAdd.TabIndex = 17;
            // 
            // begDateToAdd
            // 
            this.begDateToAdd.Cue = "Дата начала";
            this.begDateToAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begDateToAdd.Location = new System.Drawing.Point(57, 168);
            this.begDateToAdd.Name = "begDateToAdd";
            this.begDateToAdd.Size = new System.Drawing.Size(320, 44);
            this.begDateToAdd.TabIndex = 16;
            // 
            // costProjectToAdd
            // 
            this.costProjectToAdd.Cue = "Стоимость";
            this.costProjectToAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costProjectToAdd.Location = new System.Drawing.Point(57, 118);
            this.costProjectToAdd.Name = "costProjectToAdd";
            this.costProjectToAdd.Size = new System.Drawing.Size(320, 44);
            this.costProjectToAdd.TabIndex = 15;
            this.costProjectToAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBoxHandler);
            // 
            // ProjectsToAddTextBox
            // 
            this.ProjectsToAddTextBox.Cue = "Название";
            this.ProjectsToAddTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectsToAddTextBox.Location = new System.Drawing.Point(57, 68);
            this.ProjectsToAddTextBox.Name = "ProjectsToAddTextBox";
            this.ProjectsToAddTextBox.Size = new System.Drawing.Size(320, 44);
            this.ProjectsToAddTextBox.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::DataBaseApp.Properties.Resources.nulevaya_otchetnost;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.signOut);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1203, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 50.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(653, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 103);
            this.label1.TabIndex = 12;
            this.label1.Text = "БУХГАЛТЕРИЯ";
            // 
            // signOut
            // 
            this.signOut.BackColor = System.Drawing.Color.Transparent;
            this.signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOut.Font = new System.Drawing.Font("Calibri", 24.4F);
            this.signOut.ForeColor = System.Drawing.Color.Black;
            this.signOut.Location = new System.Drawing.Point(1046, 476);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(157, 55);
            this.signOut.TabIndex = 11;
            this.signOut.Text = "Выйти";
            this.signOut.UseVisualStyleBackColor = false;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // adminFormTabControl
            // 
            this.adminFormTabControl.Controls.Add(this.tabPage1);
            this.adminFormTabControl.Controls.Add(this.projectsPage);
            this.adminFormTabControl.Controls.Add(this.departmentsPage);
            this.adminFormTabControl.Controls.Add(this.employeesPage);
            this.adminFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFormTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminFormTabControl.Name = "adminFormTabControl";
            this.adminFormTabControl.SelectedIndex = 0;
            this.adminFormTabControl.Size = new System.Drawing.Size(1211, 560);
            this.adminFormTabControl.TabIndex = 0;
            this.adminFormTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.adminFormTabControl_Selected);
            // 
            // statGridView
            // 
            this.statGridView.AllowUserToAddRows = false;
            this.statGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column4,
            this.Column3,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.Column2});
            this.statGridView.Location = new System.Drawing.Point(432, 3);
            this.statGridView.MultiSelect = false;
            this.statGridView.Name = "statGridView";
            this.statGridView.ReadOnly = true;
            this.statGridView.RowHeadersWidth = 51;
            this.statGridView.RowTemplate.Height = 24;
            this.statGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statGridView.Size = new System.Drawing.Size(768, 525);
            this.statGridView.TabIndex = 33;
            this.statGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 38.50267F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Название";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отдел";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата конца";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 113.5829F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Затраты";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Прибыль";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 560);
            this.Controls.Add(this.adminFormTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            this.employeesPage.ResumeLayout(false);
            this.employeesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.departmentsPage.ResumeLayout(false);
            this.departmentsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empInDepGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView)).EndInit();
            this.projectsPage.ResumeLayout(false);
            this.projectsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.adminFormTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage employeesPage;
        private CueTextBox positionToAddEmployee;
        private CueTextBox fatherNameToAddEmployee;
        private CueTextBox lastNameToAddEmployee;
        private CueTextBox salaryToAddEmployee;
        private CueTextBox firstNameToAddEmployee;
        private System.Windows.Forms.Button cancelEmployeeButton;
        private System.Windows.Forms.CheckBox editEmployeeMode;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.TabPage departmentsPage;
        private CueTextBox depNameTextBox;
        private System.Windows.Forms.Button cancelDepButton;
        private System.Windows.Forms.CheckBox editDepMode;
        private System.Windows.Forms.DataGridView departmentGridView;
        private System.Windows.Forms.Button addDepButton;
        private System.Windows.Forms.TabPage projectsPage;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private CueTextBox realEndDateToAdd;
        private CueTextBox endDateToAdd;
        private CueTextBox begDateToAdd;
        private CueTextBox costProjectToAdd;
        private CueTextBox ProjectsToAddTextBox;
        private System.Windows.Forms.Button cancelChangesWorkTypeButton;
        private System.Windows.Forms.CheckBox editProjectsMode;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.Button addWorkTypeButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.TabControl adminFormTabControl;
        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.Button deleteFromDepButton;
        private System.Windows.Forms.Button addEmpToDepButton;
        private System.Windows.Forms.DataGridView empInDepGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmployeeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumnEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumnEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameEmpCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumnEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryColumnEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDprojCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realDateEndColumn;
        private System.Windows.Forms.Button deleteDepButton;
        private System.Windows.Forms.Button deleteEmpButton;
        private System.Windows.Forms.Button deleteProjectButton;
        private System.Windows.Forms.DataGridView statGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}