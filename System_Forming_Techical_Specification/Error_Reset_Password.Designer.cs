namespace System_Forming_Techical_Specification
{
    partial class Error_Reset_Password
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
            this.End_Reset_Button = new System.Windows.Forms.Button();
            this.Login_String = new System.Windows.Forms.TextBox();
            this.Info_Line_Login_User_Text = new System.Windows.Forms.Label();
            this.Top_String_Text = new System.Windows.Forms.Label();
            this.Error_Reset_Text = new System.Windows.Forms.Label();
            this.Go_To_Pc_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // End_Reset_Button
            // 
            this.End_Reset_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.End_Reset_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_Reset_Button.Location = new System.Drawing.Point(623, 272);
            this.End_Reset_Button.Name = "End_Reset_Button";
            this.End_Reset_Button.Size = new System.Drawing.Size(152, 36);
            this.End_Reset_Button.TabIndex = 29;
            this.End_Reset_Button.Text = "Готово";
            this.End_Reset_Button.UseVisualStyleBackColor = false;
            this.End_Reset_Button.Click += new System.EventHandler(this.End_Reset_Button_Click);
            // 
            // Login_String
            // 
            this.Login_String.Location = new System.Drawing.Point(174, 272);
            this.Login_String.Multiline = true;
            this.Login_String.Name = "Login_String";
            this.Login_String.Size = new System.Drawing.Size(413, 36);
            this.Login_String.TabIndex = 28;
            // 
            // Info_Line_Login_User_Text
            // 
            this.Info_Line_Login_User_Text.AutoSize = true;
            this.Info_Line_Login_User_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Info_Line_Login_User_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_Line_Login_User_Text.Location = new System.Drawing.Point(251, 232);
            this.Info_Line_Login_User_Text.Name = "Info_Line_Login_User_Text";
            this.Info_Line_Login_User_Text.Size = new System.Drawing.Size(243, 21);
            this.Info_Line_Login_User_Text.TabIndex = 27;
            this.Info_Line_Login_User_Text.Text = "Введите логин пользователя:";
            // 
            // Top_String_Text
            // 
            this.Top_String_Text.AutoSize = true;
            this.Top_String_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Top_String_Text.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_String_Text.Location = new System.Drawing.Point(193, 25);
            this.Top_String_Text.Name = "Top_String_Text";
            this.Top_String_Text.Size = new System.Drawing.Size(374, 32);
            this.Top_String_Text.TabIndex = 26;
            this.Top_String_Text.Text = "Сброс пароля пользователя";
            // 
            // Error_Reset_Text
            // 
            this.Error_Reset_Text.AutoSize = true;
            this.Error_Reset_Text.BackColor = System.Drawing.SystemColors.Control;
            this.Error_Reset_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_Reset_Text.ForeColor = System.Drawing.Color.Red;
            this.Error_Reset_Text.Location = new System.Drawing.Point(172, 196);
            this.Error_Reset_Text.Name = "Error_Reset_Text";
            this.Error_Reset_Text.Size = new System.Drawing.Size(415, 22);
            this.Error_Reset_Text.TabIndex = 30;
            this.Error_Reset_Text.Text = "Ошибка: Данного пользователя не существует";
            // 
            // Go_To_Pc_Button
            // 
            this.Go_To_Pc_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Go_To_Pc_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go_To_Pc_Button.Location = new System.Drawing.Point(623, 387);
            this.Go_To_Pc_Button.Name = "Go_To_Pc_Button";
            this.Go_To_Pc_Button.Size = new System.Drawing.Size(152, 36);
            this.Go_To_Pc_Button.TabIndex = 31;
            this.Go_To_Pc_Button.Text = "Вернуться";
            this.Go_To_Pc_Button.UseVisualStyleBackColor = false;
            this.Go_To_Pc_Button.Click += new System.EventHandler(this.Go_To_Pc_Button_Click);
            // 
            // Error_Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Go_To_Pc_Button);
            this.Controls.Add(this.Error_Reset_Text);
            this.Controls.Add(this.End_Reset_Button);
            this.Controls.Add(this.Login_String);
            this.Controls.Add(this.Info_Line_Login_User_Text);
            this.Controls.Add(this.Top_String_Text);
            this.Name = "Error_Reset_Password";
            this.Text = "Error_Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button End_Reset_Button;
        private System.Windows.Forms.TextBox Login_String;
        private System.Windows.Forms.Label Info_Line_Login_User_Text;
        private System.Windows.Forms.Label Top_String_Text;
        private System.Windows.Forms.Label Error_Reset_Text;
        private System.Windows.Forms.Button Go_To_Pc_Button;
    }
}