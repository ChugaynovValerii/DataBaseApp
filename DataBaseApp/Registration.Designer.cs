namespace DataBaseApp
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.signUpRegistrationButton = new System.Windows.Forms.Button();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.cancelRegButton = new System.Windows.Forms.Button();
            this.passwordConfirmInRegistrationTextBox = new CueTextBox();
            this.usernameInRegistrationTextBox = new CueTextBox();
            this.passwordInRegistrationTextBox = new CueTextBox();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.panel1.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registrationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 100);
            this.panel1.TabIndex = 3;
            // 
            // registrationLabel
            // 
            this.registrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationLabel.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(0, 0);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(621, 100);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Регистрация";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpRegistrationButton
            // 
            this.signUpRegistrationButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signUpRegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.signUpRegistrationButton.FlatAppearance.BorderSize = 0;
            this.signUpRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpRegistrationButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpRegistrationButton.Location = new System.Drawing.Point(112, 287);
            this.signUpRegistrationButton.Name = "signUpRegistrationButton";
            this.signUpRegistrationButton.Size = new System.Drawing.Size(378, 50);
            this.signUpRegistrationButton.TabIndex = 5;
            this.signUpRegistrationButton.Text = "Зарегистрироваться";
            this.signUpRegistrationButton.UseVisualStyleBackColor = false;
            this.signUpRegistrationButton.Click += new System.EventHandler(this.signUpRegistrationButton_Click);
            // 
            // registrationPanel
            // 
            this.registrationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrationPanel.Controls.Add(this.cancelRegButton);
            this.registrationPanel.Controls.Add(this.passwordConfirmInRegistrationTextBox);
            this.registrationPanel.Controls.Add(this.usernameInRegistrationTextBox);
            this.registrationPanel.Controls.Add(this.signUpRegistrationButton);
            this.registrationPanel.Controls.Add(this.panel1);
            this.registrationPanel.Controls.Add(this.passwordInRegistrationTextBox);
            this.registrationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationPanel.Location = new System.Drawing.Point(0, 0);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(621, 448);
            this.registrationPanel.TabIndex = 1;
            // 
            // cancelRegButton
            // 
            this.cancelRegButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelRegButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelRegButton.FlatAppearance.BorderSize = 0;
            this.cancelRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRegButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelRegButton.Location = new System.Drawing.Point(112, 343);
            this.cancelRegButton.Name = "cancelRegButton";
            this.cancelRegButton.Size = new System.Drawing.Size(378, 50);
            this.cancelRegButton.TabIndex = 27;
            this.cancelRegButton.Text = "Отменить";
            this.cancelRegButton.UseVisualStyleBackColor = false;
            this.cancelRegButton.Click += new System.EventHandler(this.cancelRegButton_Click);
            // 
            // passwordConfirmInRegistrationTextBox
            // 
            this.passwordConfirmInRegistrationTextBox.Cue = "Подтвердить пароль";
            this.passwordConfirmInRegistrationTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordConfirmInRegistrationTextBox.Location = new System.Drawing.Point(112, 206);
            this.passwordConfirmInRegistrationTextBox.Name = "passwordConfirmInRegistrationTextBox";
            this.passwordConfirmInRegistrationTextBox.Size = new System.Drawing.Size(378, 44);
            this.passwordConfirmInRegistrationTextBox.TabIndex = 7;
            this.passwordConfirmInRegistrationTextBox.UseSystemPasswordChar = true;
            // 
            // usernameInRegistrationTextBox
            // 
            this.usernameInRegistrationTextBox.Cue = "Имя пользователя";
            this.usernameInRegistrationTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameInRegistrationTextBox.Location = new System.Drawing.Point(112, 106);
            this.usernameInRegistrationTextBox.Name = "usernameInRegistrationTextBox";
            this.usernameInRegistrationTextBox.Size = new System.Drawing.Size(378, 44);
            this.usernameInRegistrationTextBox.TabIndex = 6;
            // 
            // passwordInRegistrationTextBox
            // 
            this.passwordInRegistrationTextBox.Cue = "Пароль";
            this.passwordInRegistrationTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInRegistrationTextBox.Location = new System.Drawing.Point(112, 156);
            this.passwordInRegistrationTextBox.Name = "passwordInRegistrationTextBox";
            this.passwordInRegistrationTextBox.Size = new System.Drawing.Size(378, 44);
            this.passwordInRegistrationTextBox.TabIndex = 2;
            this.passwordInRegistrationTextBox.UseSystemPasswordChar = true;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 448);
            this.Controls.Add(this.registrationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CueTextBox passwordInRegistrationTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button signUpRegistrationButton;
        private CueTextBox usernameInRegistrationTextBox;
        private System.Windows.Forms.Panel registrationPanel;
        private CueTextBox passwordConfirmInRegistrationTextBox;
        private System.Windows.Forms.Button cancelRegButton;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}