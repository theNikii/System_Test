namespace System_Forming_Techical_Specification
{
    partial class Change_Password_Window
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
            this.Text_Pass_Need = new System.Windows.Forms.Label();
            this.Text_Example_Password = new System.Windows.Forms.Label();
            this.Repeat_New_Password_Button = new System.Windows.Forms.TextBox();
            this.New_Password_String = new System.Windows.Forms.TextBox();
            this.Old_Password_String = new System.Windows.Forms.TextBox();
            this.Text_Old_Password = new System.Windows.Forms.Label();
            this.Text_New_Password = new System.Windows.Forms.Label();
            this.Text_Repeat_New_Password = new System.Windows.Forms.Label();
            this.Generate_Password_Button = new System.Windows.Forms.Button();
            this.Change_Password_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Pass_Need
            // 
            this.Text_Pass_Need.AutoSize = true;
            this.Text_Pass_Need.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Pass_Need.Location = new System.Drawing.Point(134, 102);
            this.Text_Pass_Need.Name = "Text_Pass_Need";
            this.Text_Pass_Need.Size = new System.Drawing.Size(243, 22);
            this.Text_Pass_Need.TabIndex = 1;
            this.Text_Pass_Need.Text = "Пароль должен содержать:";
            this.Text_Pass_Need.Click += new System.EventHandler(this.Text_Log_Pass_Click);
            // 
            // Text_Example_Password
            // 
            this.Text_Example_Password.AutoSize = true;
            this.Text_Example_Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Example_Password.Location = new System.Drawing.Point(122, 124);
            this.Text_Example_Password.Name = "Text_Example_Password";
            this.Text_Example_Password.Size = new System.Drawing.Size(270, 15);
            this.Text_Example_Password.TabIndex = 2;
            this.Text_Example_Password.Text = "Заглавную букву, цифру, специальный символ";
            this.Text_Example_Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // Repeat_New_Password_Button
            // 
            this.Repeat_New_Password_Button.Location = new System.Drawing.Point(88, 340);
            this.Repeat_New_Password_Button.Multiline = true;
            this.Repeat_New_Password_Button.Name = "Repeat_New_Password_Button";
            this.Repeat_New_Password_Button.Size = new System.Drawing.Size(369, 42);
            this.Repeat_New_Password_Button.TabIndex = 3;
            // 
            // New_Password_String
            // 
            this.New_Password_String.Location = new System.Drawing.Point(88, 270);
            this.New_Password_String.Multiline = true;
            this.New_Password_String.Name = "New_Password_String";
            this.New_Password_String.Size = new System.Drawing.Size(369, 42);
            this.New_Password_String.TabIndex = 4;
            // 
            // Old_Password_String
            // 
            this.Old_Password_String.Location = new System.Drawing.Point(88, 200);
            this.Old_Password_String.Multiline = true;
            this.Old_Password_String.Name = "Old_Password_String";
            this.Old_Password_String.Size = new System.Drawing.Size(369, 42);
            this.Old_Password_String.TabIndex = 5;
            // 
            // Text_Old_Password
            // 
            this.Text_Old_Password.AutoSize = true;
            this.Text_Old_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Old_Password.Location = new System.Drawing.Point(84, 175);
            this.Text_Old_Password.Name = "Text_Old_Password";
            this.Text_Old_Password.Size = new System.Drawing.Size(151, 22);
            this.Text_Old_Password.TabIndex = 6;
            this.Text_Old_Password.Text = "Старый пароль:";
            this.Text_Old_Password.Click += new System.EventHandler(this.Text_Password_Click);
            // 
            // Text_New_Password
            // 
            this.Text_New_Password.AutoSize = true;
            this.Text_New_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_New_Password.Location = new System.Drawing.Point(84, 245);
            this.Text_New_Password.Name = "Text_New_Password";
            this.Text_New_Password.Size = new System.Drawing.Size(142, 22);
            this.Text_New_Password.TabIndex = 7;
            this.Text_New_Password.Text = "Новый пароль:";
            this.Text_New_Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // Text_Repeat_New_Password
            // 
            this.Text_Repeat_New_Password.AutoSize = true;
            this.Text_Repeat_New_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Repeat_New_Password.Location = new System.Drawing.Point(83, 315);
            this.Text_Repeat_New_Password.Name = "Text_Repeat_New_Password";
            this.Text_Repeat_New_Password.Size = new System.Drawing.Size(236, 22);
            this.Text_Repeat_New_Password.TabIndex = 8;
            this.Text_Repeat_New_Password.Text = "Повторите новый пароль:";
            this.Text_Repeat_New_Password.Click += new System.EventHandler(this.label3_Click);
            // 
            // Generate_Password_Button
            // 
            this.Generate_Password_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Generate_Password_Button.FlatAppearance.BorderSize = 2;
            this.Generate_Password_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_Password_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate_Password_Button.Location = new System.Drawing.Point(471, 270);
            this.Generate_Password_Button.Name = "Generate_Password_Button";
            this.Generate_Password_Button.Size = new System.Drawing.Size(101, 42);
            this.Generate_Password_Button.TabIndex = 9;
            this.Generate_Password_Button.Text = "Сгенерировать ";
            this.Generate_Password_Button.UseVisualStyleBackColor = false;
            this.Generate_Password_Button.Click += new System.EventHandler(this.Generate_Password_Button_Click);
            // 
            // Change_Password_Button
            // 
            this.Change_Password_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Change_Password_Button.FlatAppearance.BorderSize = 2;
            this.Change_Password_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Password_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Password_Button.Location = new System.Drawing.Point(88, 397);
            this.Change_Password_Button.Name = "Change_Password_Button";
            this.Change_Password_Button.Size = new System.Drawing.Size(101, 42);
            this.Change_Password_Button.TabIndex = 10;
            this.Change_Password_Button.Text = "Изменить";
            this.Change_Password_Button.UseVisualStyleBackColor = false;
            this.Change_Password_Button.Click += new System.EventHandler(this.Change_Password_Button_Click);
            // 
            // Change_Password_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Change_Password_Button);
            this.Controls.Add(this.Generate_Password_Button);
            this.Controls.Add(this.Text_Repeat_New_Password);
            this.Controls.Add(this.Text_New_Password);
            this.Controls.Add(this.Text_Old_Password);
            this.Controls.Add(this.Old_Password_String);
            this.Controls.Add(this.New_Password_String);
            this.Controls.Add(this.Repeat_New_Password_Button);
            this.Controls.Add(this.Text_Example_Password);
            this.Controls.Add(this.Text_Pass_Need);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Change_Password_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_Pass_Need;
        private System.Windows.Forms.Label Text_Example_Password;
        private System.Windows.Forms.TextBox Repeat_New_Password_Button;
        private System.Windows.Forms.TextBox New_Password_String;
        private System.Windows.Forms.TextBox Old_Password_String;
        private System.Windows.Forms.Label Text_Old_Password;
        private System.Windows.Forms.Label Text_New_Password;
        private System.Windows.Forms.Label Text_Repeat_New_Password;
        private System.Windows.Forms.Button Generate_Password_Button;
        private System.Windows.Forms.Button Change_Password_Button;
    }
}