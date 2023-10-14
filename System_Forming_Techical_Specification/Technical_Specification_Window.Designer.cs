namespace System_Forming_Techical_Specification
{
    partial class Technical_Specification_Window
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
            this.Pc_Window = new System.Windows.Forms.TextBox();
            this.Personal_Cabinet = new System.Windows.Forms.Button();
            this.Main_Window_Info = new System.Windows.Forms.TextBox();
            this.Forming_Document_Button = new System.Windows.Forms.Button();
            this.Techi_Task_Button = new System.Windows.Forms.Button();
            this.Info_System_Button = new System.Windows.Forms.Button();
            this.Top_String_Text = new System.Windows.Forms.Label();
            this.Info_Line_Charistic_Text = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Change_Rows_Technical_Specification_Button = new System.Windows.Forms.Button();
            this.Send_Info_To_Document = new System.Windows.Forms.Button();
            this.Search_System_Button = new System.Windows.Forms.Button();
            this.Delete_Rows_Technical_Specification_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pc_Window
            // 
            this.Pc_Window.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pc_Window.Location = new System.Drawing.Point(0, 0);
            this.Pc_Window.Multiline = true;
            this.Pc_Window.Name = "Pc_Window";
            this.Pc_Window.Size = new System.Drawing.Size(167, 194);
            this.Pc_Window.TabIndex = 1;
            // 
            // Personal_Cabinet
            // 
            this.Personal_Cabinet.BackColor = System.Drawing.SystemColors.Control;
            this.Personal_Cabinet.FlatAppearance.BorderSize = 2;
            this.Personal_Cabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal_Cabinet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal_Cabinet.Location = new System.Drawing.Point(1, 228);
            this.Personal_Cabinet.Name = "Personal_Cabinet";
            this.Personal_Cabinet.Size = new System.Drawing.Size(166, 40);
            this.Personal_Cabinet.TabIndex = 3;
            this.Personal_Cabinet.Text = "Личный кабинет";
            this.Personal_Cabinet.UseVisualStyleBackColor = false;
            this.Personal_Cabinet.Click += new System.EventHandler(this.Personal_Cabinet_Click);
            // 
            // Main_Window_Info
            // 
            this.Main_Window_Info.Location = new System.Drawing.Point(199, 1);
            this.Main_Window_Info.Multiline = true;
            this.Main_Window_Info.Name = "Main_Window_Info";
            this.Main_Window_Info.Size = new System.Drawing.Size(1286, 761);
            this.Main_Window_Info.TabIndex = 6;
            // 
            // Forming_Document_Button
            // 
            this.Forming_Document_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Forming_Document_Button.FlatAppearance.BorderSize = 2;
            this.Forming_Document_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forming_Document_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Forming_Document_Button.Location = new System.Drawing.Point(0, 412);
            this.Forming_Document_Button.Name = "Forming_Document_Button";
            this.Forming_Document_Button.Size = new System.Drawing.Size(166, 40);
            this.Forming_Document_Button.TabIndex = 9;
            this.Forming_Document_Button.Text = "Формирование документа";
            this.Forming_Document_Button.UseVisualStyleBackColor = false;
            this.Forming_Document_Button.Click += new System.EventHandler(this.Forming_Document_Button_Click);
            // 
            // Techi_Task_Button
            // 
            this.Techi_Task_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Techi_Task_Button.FlatAppearance.BorderSize = 2;
            this.Techi_Task_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Techi_Task_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Techi_Task_Button.Location = new System.Drawing.Point(0, 366);
            this.Techi_Task_Button.Name = "Techi_Task_Button";
            this.Techi_Task_Button.Size = new System.Drawing.Size(166, 40);
            this.Techi_Task_Button.TabIndex = 8;
            this.Techi_Task_Button.Text = "Техническое задание";
            this.Techi_Task_Button.UseVisualStyleBackColor = false;
            this.Techi_Task_Button.Click += new System.EventHandler(this.Techi_Task_Button_Click);
            // 
            // Info_System_Button
            // 
            this.Info_System_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Info_System_Button.FlatAppearance.BorderSize = 2;
            this.Info_System_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_System_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_System_Button.Location = new System.Drawing.Point(0, 320);
            this.Info_System_Button.Name = "Info_System_Button";
            this.Info_System_Button.Size = new System.Drawing.Size(166, 40);
            this.Info_System_Button.TabIndex = 7;
            this.Info_System_Button.Text = "Справочная система";
            this.Info_System_Button.UseVisualStyleBackColor = false;
            this.Info_System_Button.Click += new System.EventHandler(this.Info_System_Button_Click);
            // 
            // Top_String_Text
            // 
            this.Top_String_Text.AutoSize = true;
            this.Top_String_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Top_String_Text.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_String_Text.Location = new System.Drawing.Point(736, 21);
            this.Top_String_Text.Name = "Top_String_Text";
            this.Top_String_Text.Size = new System.Drawing.Size(286, 32);
            this.Top_String_Text.TabIndex = 12;
            this.Top_String_Text.Text = "Техническое задание";
            this.Top_String_Text.Click += new System.EventHandler(this.Top_String_Text_Click);
            // 
            // Info_Line_Charistic_Text
            // 
            this.Info_Line_Charistic_Text.AutoSize = true;
            this.Info_Line_Charistic_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Info_Line_Charistic_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_Line_Charistic_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_Line_Charistic_Text.Location = new System.Drawing.Point(230, 91);
            this.Info_Line_Charistic_Text.Name = "Info_Line_Charistic_Text";
            this.Info_Line_Charistic_Text.Size = new System.Drawing.Size(294, 21);
            this.Info_Line_Charistic_Text.TabIndex = 15;
            this.Info_Line_Charistic_Text.Text = "Содержание технического задания:";
            this.Info_Line_Charistic_Text.Click += new System.EventHandler(this.Info_Line_Charistic_Text_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1214, 415);
            this.dataGridView1.TabIndex = 16;
            // 
            // Change_Rows_Technical_Specification_Button
            // 
            this.Change_Rows_Technical_Specification_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Change_Rows_Technical_Specification_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Rows_Technical_Specification_Button.Location = new System.Drawing.Point(234, 578);
            this.Change_Rows_Technical_Specification_Button.Name = "Change_Rows_Technical_Specification_Button";
            this.Change_Rows_Technical_Specification_Button.Size = new System.Drawing.Size(152, 52);
            this.Change_Rows_Technical_Specification_Button.TabIndex = 17;
            this.Change_Rows_Technical_Specification_Button.Text = "Редактировать строку";
            this.Change_Rows_Technical_Specification_Button.UseVisualStyleBackColor = false;
            this.Change_Rows_Technical_Specification_Button.Click += new System.EventHandler(this.Change_Technical_Specification_Button_Click);
            // 
            // Send_Info_To_Document
            // 
            this.Send_Info_To_Document.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Send_Info_To_Document.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send_Info_To_Document.Location = new System.Drawing.Point(1294, 578);
            this.Send_Info_To_Document.Name = "Send_Info_To_Document";
            this.Send_Info_To_Document.Size = new System.Drawing.Size(152, 52);
            this.Send_Info_To_Document.TabIndex = 18;
            this.Send_Info_To_Document.Text = "Добавить информацию в документ";
            this.Send_Info_To_Document.UseVisualStyleBackColor = false;
            this.Send_Info_To_Document.Click += new System.EventHandler(this.Send_Info_To_Document_Click);
            // 
            // Search_System_Button
            // 
            this.Search_System_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Search_System_Button.FlatAppearance.BorderSize = 2;
            this.Search_System_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_System_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_System_Button.Location = new System.Drawing.Point(0, 274);
            this.Search_System_Button.Name = "Search_System_Button";
            this.Search_System_Button.Size = new System.Drawing.Size(166, 40);
            this.Search_System_Button.TabIndex = 19;
            this.Search_System_Button.Text = "Поиск";
            this.Search_System_Button.UseVisualStyleBackColor = false;
            this.Search_System_Button.Click += new System.EventHandler(this.Search_System_Button_Click);
            // 
            // Delete_Rows_Technical_Specification_Button
            // 
            this.Delete_Rows_Technical_Specification_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Rows_Technical_Specification_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Rows_Technical_Specification_Button.Location = new System.Drawing.Point(414, 578);
            this.Delete_Rows_Technical_Specification_Button.Name = "Delete_Rows_Technical_Specification_Button";
            this.Delete_Rows_Technical_Specification_Button.Size = new System.Drawing.Size(152, 52);
            this.Delete_Rows_Technical_Specification_Button.TabIndex = 20;
            this.Delete_Rows_Technical_Specification_Button.Text = "Удалить строку";
            this.Delete_Rows_Technical_Specification_Button.UseVisualStyleBackColor = false;
            // 
            // Technical_Specification_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Delete_Rows_Technical_Specification_Button);
            this.Controls.Add(this.Search_System_Button);
            this.Controls.Add(this.Send_Info_To_Document);
            this.Controls.Add(this.Change_Rows_Technical_Specification_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Info_Line_Charistic_Text);
            this.Controls.Add(this.Top_String_Text);
            this.Controls.Add(this.Forming_Document_Button);
            this.Controls.Add(this.Techi_Task_Button);
            this.Controls.Add(this.Info_System_Button);
            this.Controls.Add(this.Main_Window_Info);
            this.Controls.Add(this.Personal_Cabinet);
            this.Controls.Add(this.Pc_Window);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Technical_Specification_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pc_Window;
        private System.Windows.Forms.Button Personal_Cabinet;
        private System.Windows.Forms.TextBox Main_Window_Info;
        private System.Windows.Forms.Button Forming_Document_Button;
        private System.Windows.Forms.Button Techi_Task_Button;
        private System.Windows.Forms.Button Info_System_Button;
        private System.Windows.Forms.Label Top_String_Text;
        private System.Windows.Forms.Label Info_Line_Charistic_Text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Change_Rows_Technical_Specification_Button;
        private System.Windows.Forms.Button Send_Info_To_Document;
        private System.Windows.Forms.Button Search_System_Button;
        private System.Windows.Forms.Button Delete_Rows_Technical_Specification_Button;
    }
}