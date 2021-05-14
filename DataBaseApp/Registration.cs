using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DataBaseApp
{
    public partial class RegistrationForm : Form
    {
        private OracleConnection connection;

        public RegistrationForm(OracleConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void signUpRegistrationButton_Click(object sender, EventArgs e)
        {
            if (usernameInRegistrationTextBox.Text == "")
            {
                MessageBox.Show("Введите логин");
            }
            else if (passwordInRegistrationTextBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }
            else if (!passwordConfirmInRegistrationTextBox.Text.Equals(passwordInRegistrationTextBox.Text))
            {
                MessageBox.Show("Пароли не совпали");
                passwordInRegistrationTextBox.Text = "";
                passwordConfirmInRegistrationTextBox.Text = "";
            }
            else
            {
                OracleCommand command = new OracleCommand("SELECT * FROM Users WHERE LOGIN=:LOGIN", connection);
                command.Parameters.Add("LOGIN", OracleDbType.Varchar2, 50).Value = usernameInRegistrationTextBox.Text;

                OracleDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Аккаунт с таким логином уже есть");
                    usernameInRegistrationTextBox.Text = "";
                    passwordInRegistrationTextBox.Text = "";
                    passwordConfirmInRegistrationTextBox.Text = "";
                    return;
                }
                reader.Close();

                command = new OracleCommand("INSERT INTO USERS (LOGIN, PASSWORD) VALUES(:LOGIN, :PASSWORD)", connection);
                command.Parameters.Add("LOGIN", OracleDbType.Varchar2, 50).Value = usernameInRegistrationTextBox.Text;
                command.Parameters.Add("PASSWORD", OracleDbType.Varchar2, 50).Value = passwordInRegistrationTextBox.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Аккаунт создан!");
                connection.Close();
                this.Hide();
                Authorization authorization = new Authorization();
                authorization.Show();
            }
        }

        private void cancelRegButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }
    }
}
