﻿namespace System_Forming_Techical_Specification
{
    partial class Main_Windows
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
            this.Text_Log_Pass = new System.Windows.Forms.Label();
            this.Text_Login = new System.Windows.Forms.Label();
            this.Login_String = new System.Windows.Forms.TextBox();
            this.Text_Password = new System.Windows.Forms.Label();
            this.Password_String = new System.Windows.Forms.TextBox();
            this.Enter_To_System_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Log_Pass
            // 
            this.Text_Log_Pass.AutoSize = true;
            this.Text_Log_Pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Log_Pass.Location = new System.Drawing.Point(94, 163);
            this.Text_Log_Pass.Name = "Text_Log_Pass";
            this.Text_Log_Pass.Size = new System.Drawing.Size(373, 22);
            this.Text_Log_Pass.TabIndex = 1;
            this.Text_Log_Pass.Text = "Введите логин и пароль для авторизации";
            // 
            // Text_Login
            // 
            this.Text_Login.AutoSize = true;
            this.Text_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Login.Location = new System.Drawing.Point(94, 218);
            this.Text_Login.Name = "Text_Login";
            this.Text_Login.Size = new System.Drawing.Size(70, 22);
            this.Text_Login.TabIndex = 4;
            this.Text_Login.Text = "Логин:";
            // 
            // Login_String
            // 
            this.Login_String.Location = new System.Drawing.Point(98, 243);
            this.Login_String.Multiline = true;
            this.Login_String.Name = "Login_String";
            this.Login_String.Size = new System.Drawing.Size(369, 42);
            this.Login_String.TabIndex = 5;
            // 
            // Text_Password
            // 
            this.Text_Password.AutoSize = true;
            this.Text_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Password.Location = new System.Drawing.Point(94, 301);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(80, 22);
            this.Text_Password.TabIndex = 6;
            this.Text_Password.Text = "Пароль:";
            // 
            // Password_String
            // 
            this.Password_String.Location = new System.Drawing.Point(98, 326);
            this.Password_String.Multiline = true;
            this.Password_String.Name = "Password_String";
            this.Password_String.Size = new System.Drawing.Size(369, 42);
            this.Password_String.TabIndex = 7;
            // 
            // Enter_To_System_Button
            // 
            this.Enter_To_System_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Enter_To_System_Button.FlatAppearance.BorderSize = 2;
            this.Enter_To_System_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_To_System_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_To_System_Button.Location = new System.Drawing.Point(192, 391);
            this.Enter_To_System_Button.Name = "Enter_To_System_Button";
            this.Enter_To_System_Button.Size = new System.Drawing.Size(101, 42);
            this.Enter_To_System_Button.TabIndex = 12;
            this.Enter_To_System_Button.Text = "Войти ";
            this.Enter_To_System_Button.UseVisualStyleBackColor = false;
            this.Enter_To_System_Button.Click += new System.EventHandler(this.Enter_To_System_Button_Click);
            // 
            // Main_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Enter_To_System_Button);
            this.Controls.Add(this.Password_String);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Login_String);
            this.Controls.Add(this.Text_Login);
            this.Controls.Add(this.Text_Log_Pass);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Main_Windows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Windows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_Log_Pass;
        private System.Windows.Forms.Label Text_Login;
        private System.Windows.Forms.TextBox Login_String;
        private System.Windows.Forms.Label Text_Password;
        private System.Windows.Forms.TextBox Password_String;
        private System.Windows.Forms.Button Enter_To_System_Button;
    }
}

