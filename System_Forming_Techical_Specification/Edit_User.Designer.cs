namespace System_Forming_Techical_Specification
{
    partial class Edit_User
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
            this.Main_Info_Text = new System.Windows.Forms.Label();
            this.End_Edit_Button = new System.Windows.Forms.Button();
            this.Password_Text = new System.Windows.Forms.Label();
            this.Login_Text = new System.Windows.Forms.Label();
            this.Password_String = new System.Windows.Forms.TextBox();
            this.Login_String = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.Label();
            this.Name_String = new System.Windows.Forms.TextBox();
            this.Level_Accept_Text = new System.Windows.Forms.Label();
            this.Level_Accept_String = new System.Windows.Forms.TextBox();
            this.Role_Text = new System.Windows.Forms.Label();
            this.Role_String = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Main_Info_Text
            // 
            this.Main_Info_Text.AutoSize = true;
            this.Main_Info_Text.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_Info_Text.Location = new System.Drawing.Point(289, 21);
            this.Main_Info_Text.Name = "Main_Info_Text";
            this.Main_Info_Text.Size = new System.Drawing.Size(320, 31);
            this.Main_Info_Text.TabIndex = 1;
            this.Main_Info_Text.Text = "Изменение пользователя";
            this.Main_Info_Text.Click += new System.EventHandler(this.Main_Info_Text_Click);
            // 
            // End_Edit_Button
            // 
            this.End_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_Edit_Button.Location = new System.Drawing.Point(36, 665);
            this.End_Edit_Button.Name = "End_Edit_Button";
            this.End_Edit_Button.Size = new System.Drawing.Size(176, 49);
            this.End_Edit_Button.TabIndex = 27;
            this.End_Edit_Button.Text = "Готово";
            this.End_Edit_Button.UseVisualStyleBackColor = true;
            this.End_Edit_Button.Click += new System.EventHandler(this.End_Edit_Button_Click);
            // 
            // Password_Text
            // 
            this.Password_Text.AutoSize = true;
            this.Password_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_Text.Location = new System.Drawing.Point(32, 131);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(73, 21);
            this.Password_Text.TabIndex = 26;
            this.Password_Text.Text = "Пароль:";
            // 
            // Login_Text
            // 
            this.Login_Text.AutoSize = true;
            this.Login_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Text.Location = new System.Drawing.Point(25, 63);
            this.Login_Text.Name = "Login_Text";
            this.Login_Text.Size = new System.Drawing.Size(65, 21);
            this.Login_Text.TabIndex = 25;
            this.Login_Text.Text = "Логин:";
            // 
            // Password_String
            // 
            this.Password_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_String.Location = new System.Drawing.Point(29, 155);
            this.Password_String.Multiline = true;
            this.Password_String.Name = "Password_String";
            this.Password_String.Size = new System.Drawing.Size(906, 31);
            this.Password_String.TabIndex = 24;
            // 
            // Login_String
            // 
            this.Login_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_String.Location = new System.Drawing.Point(29, 87);
            this.Login_String.Multiline = true;
            this.Login_String.Name = "Login_String";
            this.Login_String.Size = new System.Drawing.Size(906, 31);
            this.Login_String.TabIndex = 23;
            // 
            // Name_Text
            // 
            this.Name_Text.AutoSize = true;
            this.Name_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Text.Location = new System.Drawing.Point(25, 195);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(48, 21);
            this.Name_Text.TabIndex = 29;
            this.Name_Text.Text = "Имя:";
            // 
            // Name_String
            // 
            this.Name_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_String.Location = new System.Drawing.Point(29, 219);
            this.Name_String.Multiline = true;
            this.Name_String.Name = "Name_String";
            this.Name_String.Size = new System.Drawing.Size(906, 31);
            this.Name_String.TabIndex = 28;
            // 
            // Level_Accept_Text
            // 
            this.Level_Accept_Text.AutoSize = true;
            this.Level_Accept_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level_Accept_Text.Location = new System.Drawing.Point(25, 269);
            this.Level_Accept_Text.Name = "Level_Accept_Text";
            this.Level_Accept_Text.Size = new System.Drawing.Size(150, 21);
            this.Level_Accept_Text.TabIndex = 31;
            this.Level_Accept_Text.Text = "Уровень доступа:";
            // 
            // Level_Accept_String
            // 
            this.Level_Accept_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Level_Accept_String.Location = new System.Drawing.Point(29, 293);
            this.Level_Accept_String.Multiline = true;
            this.Level_Accept_String.Name = "Level_Accept_String";
            this.Level_Accept_String.Size = new System.Drawing.Size(906, 31);
            this.Level_Accept_String.TabIndex = 30;
            // 
            // Role_Text
            // 
            this.Role_Text.AutoSize = true;
            this.Role_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Role_Text.Location = new System.Drawing.Point(25, 338);
            this.Role_Text.Name = "Role_Text";
            this.Role_Text.Size = new System.Drawing.Size(53, 21);
            this.Role_Text.TabIndex = 33;
            this.Role_Text.Text = "Роль:";
            // 
            // Role_String
            // 
            this.Role_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Role_String.Location = new System.Drawing.Point(29, 362);
            this.Role_String.Multiline = true;
            this.Role_String.Name = "Role_String";
            this.Role_String.Size = new System.Drawing.Size(906, 31);
            this.Role_String.TabIndex = 32;
            // 
            // Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.Role_Text);
            this.Controls.Add(this.Role_String);
            this.Controls.Add(this.Level_Accept_Text);
            this.Controls.Add(this.Level_Accept_String);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Name_String);
            this.Controls.Add(this.End_Edit_Button);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Login_Text);
            this.Controls.Add(this.Password_String);
            this.Controls.Add(this.Login_String);
            this.Controls.Add(this.Main_Info_Text);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Edit_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_Info_Text;
        private System.Windows.Forms.Button End_Edit_Button;
        private System.Windows.Forms.Label Password_Text;
        private System.Windows.Forms.Label Login_Text;
        private System.Windows.Forms.TextBox Password_String;
        private System.Windows.Forms.TextBox Login_String;
        private System.Windows.Forms.Label Name_Text;
        private System.Windows.Forms.TextBox Name_String;
        private System.Windows.Forms.Label Level_Accept_Text;
        private System.Windows.Forms.TextBox Level_Accept_String;
        private System.Windows.Forms.Label Role_Text;
        private System.Windows.Forms.TextBox Role_String;
    }
}