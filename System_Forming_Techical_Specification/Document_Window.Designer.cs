﻿namespace System_Forming_Techical_Specification
{
    partial class Document_Window
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
            this.Top_String_Text = new System.Windows.Forms.Label();
            this.Info_Line_Technical_Specification_Text = new System.Windows.Forms.Label();
            this.Print_Document_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_System_Button = new System.Windows.Forms.Button();
            this.Role_User_String = new System.Windows.Forms.TextBox();
            this.Name_User_String = new System.Windows.Forms.TextBox();
            this.Change_User_Button = new System.Windows.Forms.Button();
            this.Change_Item_Button = new System.Windows.Forms.Button();
            this.Form_doc = new System.Windows.Forms.Button();
            this.Choose_tech_spec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pc_Window
            // 
            this.Pc_Window.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pc_Window.Location = new System.Drawing.Point(-1, 0);
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
            this.Personal_Cabinet.Location = new System.Drawing.Point(0, 407);
            this.Personal_Cabinet.Name = "Personal_Cabinet";
            this.Personal_Cabinet.Size = new System.Drawing.Size(166, 40);
            this.Personal_Cabinet.TabIndex = 3;
            this.Personal_Cabinet.Text = "Личный кабинет";
            this.Personal_Cabinet.UseVisualStyleBackColor = false;
            this.Personal_Cabinet.Click += new System.EventHandler(this.Personal_Cabinet_Click);
            // 
            // Main_Window_Info
            // 
            this.Main_Window_Info.Location = new System.Drawing.Point(201, 1);
            this.Main_Window_Info.Multiline = true;
            this.Main_Window_Info.Name = "Main_Window_Info";
            this.Main_Window_Info.Size = new System.Drawing.Size(1286, 761);
            this.Main_Window_Info.TabIndex = 6;
            this.Main_Window_Info.TextChanged += new System.EventHandler(this.Main_Window_Info_TextChanged);
            // 
            // Forming_Document_Button
            // 
            this.Forming_Document_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Forming_Document_Button.FlatAppearance.BorderSize = 2;
            this.Forming_Document_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forming_Document_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Forming_Document_Button.Location = new System.Drawing.Point(1, 314);
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
            this.Techi_Task_Button.Location = new System.Drawing.Point(1, 268);
            this.Techi_Task_Button.Name = "Techi_Task_Button";
            this.Techi_Task_Button.Size = new System.Drawing.Size(166, 40);
            this.Techi_Task_Button.TabIndex = 8;
            this.Techi_Task_Button.Text = "Техническое задание";
            this.Techi_Task_Button.UseVisualStyleBackColor = false;
            this.Techi_Task_Button.Click += new System.EventHandler(this.Techi_Task_Button_Click);
            // 
            // Top_String_Text
            // 
            this.Top_String_Text.AutoSize = true;
            this.Top_String_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Top_String_Text.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_String_Text.Location = new System.Drawing.Point(638, 21);
            this.Top_String_Text.Name = "Top_String_Text";
            this.Top_String_Text.Size = new System.Drawing.Size(435, 32);
            this.Top_String_Text.TabIndex = 12;
            this.Top_String_Text.Text = "Документ технического задания";
            // 
            // Info_Line_Technical_Specification_Text
            // 
            this.Info_Line_Technical_Specification_Text.AutoSize = true;
            this.Info_Line_Technical_Specification_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Info_Line_Technical_Specification_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_Line_Technical_Specification_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_Line_Technical_Specification_Text.Location = new System.Drawing.Point(234, 101);
            this.Info_Line_Technical_Specification_Text.Name = "Info_Line_Technical_Specification_Text";
            this.Info_Line_Technical_Specification_Text.Size = new System.Drawing.Size(383, 21);
            this.Info_Line_Technical_Specification_Text.TabIndex = 15;
            this.Info_Line_Technical_Specification_Text.Text = "Содержание документа технического задания:";
            // 
            // Print_Document_Button
            // 
            this.Print_Document_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print_Document_Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Print_Document_Button.Location = new System.Drawing.Point(1300, 592);
            this.Print_Document_Button.Name = "Print_Document_Button";
            this.Print_Document_Button.Size = new System.Drawing.Size(152, 52);
            this.Print_Document_Button.TabIndex = 16;
            this.Print_Document_Button.Text = "Перевод в электронный вид";
            this.Print_Document_Button.UseVisualStyleBackColor = false;
            this.Print_Document_Button.Click += new System.EventHandler(this.Print_Document_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1214, 415);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search_System_Button
            // 
            this.Search_System_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Search_System_Button.FlatAppearance.BorderSize = 2;
            this.Search_System_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_System_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_System_Button.Location = new System.Drawing.Point(1, 222);
            this.Search_System_Button.Name = "Search_System_Button";
            this.Search_System_Button.Size = new System.Drawing.Size(166, 40);
            this.Search_System_Button.TabIndex = 19;
            this.Search_System_Button.Text = "Поиск";
            this.Search_System_Button.UseVisualStyleBackColor = false;
            this.Search_System_Button.Click += new System.EventHandler(this.Search_System_Button_Click);
            // 
            // Role_User_String
            // 
            this.Role_User_String.Location = new System.Drawing.Point(4, 111);
            this.Role_User_String.Multiline = true;
            this.Role_User_String.Name = "Role_User_String";
            this.Role_User_String.Size = new System.Drawing.Size(163, 46);
            this.Role_User_String.TabIndex = 25;
            this.Role_User_String.TextChanged += new System.EventHandler(this.Role_User_String_TextChanged);
            // 
            // Name_User_String
            // 
            this.Name_User_String.Location = new System.Drawing.Point(3, 21);
            this.Name_User_String.Multiline = true;
            this.Name_User_String.Name = "Name_User_String";
            this.Name_User_String.Size = new System.Drawing.Size(163, 46);
            this.Name_User_String.TabIndex = 24;
            this.Name_User_String.TextChanged += new System.EventHandler(this.Name_User_String_TextChanged);
            // 
            // Change_User_Button
            // 
            this.Change_User_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Change_User_Button.FlatAppearance.BorderSize = 2;
            this.Change_User_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_User_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_User_Button.Location = new System.Drawing.Point(0, 504);
            this.Change_User_Button.Name = "Change_User_Button";
            this.Change_User_Button.Size = new System.Drawing.Size(166, 45);
            this.Change_User_Button.TabIndex = 41;
            this.Change_User_Button.Text = "Редактирование пользователей";
            this.Change_User_Button.UseVisualStyleBackColor = false;
            // 
            // Change_Item_Button
            // 
            this.Change_Item_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Change_Item_Button.FlatAppearance.BorderSize = 2;
            this.Change_Item_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Item_Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Item_Button.Location = new System.Drawing.Point(0, 453);
            this.Change_Item_Button.Name = "Change_Item_Button";
            this.Change_Item_Button.Size = new System.Drawing.Size(166, 45);
            this.Change_Item_Button.TabIndex = 40;
            this.Change_Item_Button.Text = "Редактирование нуменклатуры";
            this.Change_Item_Button.UseVisualStyleBackColor = false;
            // 
            // Form_doc
            // 
            this.Form_doc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Form_doc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form_doc.Location = new System.Drawing.Point(1142, 592);
            this.Form_doc.Name = "Form_doc";
            this.Form_doc.Size = new System.Drawing.Size(152, 52);
            this.Form_doc.TabIndex = 42;
            this.Form_doc.Text = "Сформировать документ";
            this.Form_doc.UseVisualStyleBackColor = false;
            this.Form_doc.Click += new System.EventHandler(this.Form_doc_Click);
            // 
            // Choose_tech_spec
            // 
            this.Choose_tech_spec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Choose_tech_spec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose_tech_spec.Location = new System.Drawing.Point(984, 592);
            this.Choose_tech_spec.Name = "Choose_tech_spec";
            this.Choose_tech_spec.Size = new System.Drawing.Size(152, 52);
            this.Choose_tech_spec.TabIndex = 43;
            this.Choose_tech_spec.Text = "Выбрать тех задание";
            this.Choose_tech_spec.UseVisualStyleBackColor = false;
            this.Choose_tech_spec.Click += new System.EventHandler(this.Choose_tech_spec_Click);
            // 
            // Document_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.Choose_tech_spec);
            this.Controls.Add(this.Form_doc);
            this.Controls.Add(this.Change_User_Button);
            this.Controls.Add(this.Change_Item_Button);
            this.Controls.Add(this.Role_User_String);
            this.Controls.Add(this.Name_User_String);
            this.Controls.Add(this.Search_System_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Print_Document_Button);
            this.Controls.Add(this.Info_Line_Technical_Specification_Text);
            this.Controls.Add(this.Top_String_Text);
            this.Controls.Add(this.Forming_Document_Button);
            this.Controls.Add(this.Techi_Task_Button);
            this.Controls.Add(this.Main_Window_Info);
            this.Controls.Add(this.Personal_Cabinet);
            this.Controls.Add(this.Pc_Window);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Document_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Document_Window_Load);
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
        private System.Windows.Forms.Label Top_String_Text;
        private System.Windows.Forms.Label Info_Line_Technical_Specification_Text;
        private System.Windows.Forms.Button Print_Document_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search_System_Button;
        private System.Windows.Forms.TextBox Role_User_String;
        private System.Windows.Forms.TextBox Name_User_String;
        private System.Windows.Forms.Button Change_User_Button;
        private System.Windows.Forms.Button Change_Item_Button;
        private System.Windows.Forms.Button Form_doc;
        private System.Windows.Forms.Button Choose_tech_spec;
    }
}