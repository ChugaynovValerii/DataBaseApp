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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            connection.Open();
            
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            OracleCommand command = new OracleCommand("SELECT ID FROM USERS WHERE LOGIN=:LOGIN AND PASSWORD=:PASSWORD", connection);
            command.Parameters.Add("LOGIN", OracleDbType.Varchar2, 50).Value = usernameTextBox.Text;
            command.Parameters.Add("PASSWORD", OracleDbType.Varchar2, 50).Value = passwordTextBox.Text;

            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            { 
                this.Hide();
                AdminMainForm adminMainForm = new AdminMainForm(connection);
                adminMainForm.Show();   
            }
            else
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                MessageBox.Show("Неверный логин или пароль!");
            }
            reader.Close();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm(connection);
            registrationForm.Show();
        }

    }
}
