namespace System_Forming_Techical_Specification
{
    partial class Edit_Users
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
            this.Top_String_Text = new System.Windows.Forms.Label();
            this.User_Window_Data = new System.Windows.Forms.DataGridView();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.End_Edit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.User_Window_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_String_Text
            // 
            this.Top_String_Text.AutoSize = true;
            this.Top_String_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Top_String_Text.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_String_Text.Location = new System.Drawing.Point(238, 9);
            this.Top_String_Text.Name = "Top_String_Text";
            this.Top_String_Text.Size = new System.Drawing.Size(424, 32);
            this.Top_String_Text.TabIndex = 11;
            this.Top_String_Text.Text = "Редактирование пользователей";
            this.Top_String_Text.Click += new System.EventHandler(this.Top_String_Text_Click);
            // 
            // User_Window_Data
            // 
            this.User_Window_Data.AllowUserToOrderColumns = true;
            this.User_Window_Data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_Window_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_Window_Data.Location = new System.Drawing.Point(12, 57);
            this.User_Window_Data.Name = "User_Window_Data";
            this.User_Window_Data.Size = new System.Drawing.Size(954, 555);
            this.User_Window_Data.TabIndex = 12;
            this.User_Window_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_Window_Data_CellContentClick);
            // 
            // Change_Button
            // 
            this.Change_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Change_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Button.Location = new System.Drawing.Point(12, 650);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(152, 52);
            this.Change_Button.TabIndex = 21;
            this.Change_Button.Text = "Редактировать ";
            this.Change_Button.UseVisualStyleBackColor = false;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Button.Location = new System.Drawing.Point(170, 650);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(152, 52);
            this.Delete_Button.TabIndex = 22;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insert_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert_Button.Location = new System.Drawing.Point(328, 650);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(152, 52);
            this.Insert_Button.TabIndex = 23;
            this.Insert_Button.Text = "Добавить";
            this.Insert_Button.UseVisualStyleBackColor = false;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // End_Edit_Button
            // 
            this.End_Edit_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.End_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_Edit_Button.Location = new System.Drawing.Point(814, 650);
            this.End_Edit_Button.Name = "End_Edit_Button";
            this.End_Edit_Button.Size = new System.Drawing.Size(152, 52);
            this.End_Edit_Button.TabIndex = 24;
            this.End_Edit_Button.Text = "Готово";
            this.End_Edit_Button.UseVisualStyleBackColor = false;
            this.End_Edit_Button.Click += new System.EventHandler(this.End_Edit_Button_Click);
            // 
            // Edit_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.End_Edit_Button);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.User_Window_Data);
            this.Controls.Add(this.Top_String_Text);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Edit_Users";
            ((System.ComponentModel.ISupportInitialize)(this.User_Window_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Top_String_Text;
        private System.Windows.Forms.DataGridView User_Window_Data;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button End_Edit_Button;
    }
}