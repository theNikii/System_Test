namespace System_Forming_Techical_Specification
{
    partial class Error_Authorization_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_Authorization_Window));
            this.Text_Log_Pass = new System.Windows.Forms.Label();
            this.Text_Login = new System.Windows.Forms.Label();
            this.Login_String = new System.Windows.Forms.TextBox();
            this.Text_Password = new System.Windows.Forms.Label();
            this.Password_String = new System.Windows.Forms.TextBox();
            this.Enter_To_System_Button = new System.Windows.Forms.Button();
            this.Forget_Password_Button = new System.Windows.Forms.Button();
            this.Text_Error_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_Log_Pass
            // 
            resources.ApplyResources(this.Text_Log_Pass, "Text_Log_Pass");
            this.Text_Log_Pass.Name = "Text_Log_Pass";
            this.Text_Log_Pass.Click += new System.EventHandler(this.Text_Log_Pass_Click);
            // 
            // Text_Login
            // 
            resources.ApplyResources(this.Text_Login, "Text_Login");
            this.Text_Login.Name = "Text_Login";
            // 
            // Login_String
            // 
            resources.ApplyResources(this.Login_String, "Login_String");
            this.Login_String.Name = "Login_String";
            // 
            // Text_Password
            // 
            resources.ApplyResources(this.Text_Password, "Text_Password");
            this.Text_Password.Name = "Text_Password";
            // 
            // Password_String
            // 
            resources.ApplyResources(this.Password_String, "Password_String");
            this.Password_String.Name = "Password_String";
            // 
            // Enter_To_System_Button
            // 
            this.Enter_To_System_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Enter_To_System_Button.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.Enter_To_System_Button, "Enter_To_System_Button");
            this.Enter_To_System_Button.Name = "Enter_To_System_Button";
            this.Enter_To_System_Button.UseVisualStyleBackColor = false;
            this.Enter_To_System_Button.Click += new System.EventHandler(this.Enter_To_System_Button_Click);
            // 
            // Forget_Password_Button
            // 
            this.Forget_Password_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Forget_Password_Button.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.Forget_Password_Button, "Forget_Password_Button");
            this.Forget_Password_Button.Name = "Forget_Password_Button";
            this.Forget_Password_Button.UseVisualStyleBackColor = false;
            // 
            // Text_Error_Info
            // 
            resources.ApplyResources(this.Text_Error_Info, "Text_Error_Info");
            this.Text_Error_Info.ForeColor = System.Drawing.Color.Red;
            this.Text_Error_Info.Name = "Text_Error_Info";
            // 
            // Error_Authorization_Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.Text_Error_Info);
            this.Controls.Add(this.Forget_Password_Button);
            this.Controls.Add(this.Enter_To_System_Button);
            this.Controls.Add(this.Password_String);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Login_String);
            this.Controls.Add(this.Text_Login);
            this.Controls.Add(this.Text_Log_Pass);
            this.Name = "Error_Authorization_Window";
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
        private System.Windows.Forms.Button Forget_Password_Button;
        private System.Windows.Forms.Label Text_Error_Info;
    }
}