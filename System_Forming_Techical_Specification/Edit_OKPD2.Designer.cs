namespace System_Forming_Techical_Specification
{
    partial class Edit_OKPD2
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
            this.Code_Text = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.Label();
            this.Code_OKPD2_String = new System.Windows.Forms.TextBox();
            this.Name_OKPD2_String = new System.Windows.Forms.TextBox();
            this.End_Edit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Main_Info_Text
            // 
            this.Main_Info_Text.AutoSize = true;
            this.Main_Info_Text.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_Info_Text.Location = new System.Drawing.Point(273, 21);
            this.Main_Info_Text.Name = "Main_Info_Text";
            this.Main_Info_Text.Size = new System.Drawing.Size(250, 31);
            this.Main_Info_Text.TabIndex = 2;
            this.Main_Info_Text.Text = "Изменение ОКПД2";
            this.Main_Info_Text.Click += new System.EventHandler(this.Main_Info_Text_Click);
            // 
            // Code_Text
            // 
            this.Code_Text.AutoSize = true;
            this.Code_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code_Text.Location = new System.Drawing.Point(15, 161);
            this.Code_Text.Name = "Code_Text";
            this.Code_Text.Size = new System.Drawing.Size(45, 21);
            this.Code_Text.TabIndex = 15;
            this.Code_Text.Text = "Код:";
            this.Code_Text.Click += new System.EventHandler(this.Customer_Text_Click);
            // 
            // Name_Text
            // 
            this.Name_Text.AutoSize = true;
            this.Name_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Text.Location = new System.Drawing.Point(8, 93);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(88, 21);
            this.Name_Text.TabIndex = 14;
            this.Name_Text.Text = "Название:";
            this.Name_Text.Click += new System.EventHandler(this.Header_Text_Click);
            // 
            // Code_OKPD2_String
            // 
            this.Code_OKPD2_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code_OKPD2_String.Location = new System.Drawing.Point(12, 185);
            this.Code_OKPD2_String.Multiline = true;
            this.Code_OKPD2_String.Name = "Code_OKPD2_String";
            this.Code_OKPD2_String.Size = new System.Drawing.Size(906, 31);
            this.Code_OKPD2_String.TabIndex = 13;
            this.Code_OKPD2_String.TextChanged += new System.EventHandler(this.Customer_Document_String_TextChanged);
            // 
            // Name_OKPD2_String
            // 
            this.Name_OKPD2_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_OKPD2_String.Location = new System.Drawing.Point(12, 117);
            this.Name_OKPD2_String.Multiline = true;
            this.Name_OKPD2_String.Name = "Name_OKPD2_String";
            this.Name_OKPD2_String.Size = new System.Drawing.Size(906, 31);
            this.Name_OKPD2_String.TabIndex = 12;
            this.Name_OKPD2_String.TextChanged += new System.EventHandler(this.Header_Document_String_TextChanged);
            // 
            // End_Edit_Button
            // 
            this.End_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_Edit_Button.Location = new System.Drawing.Point(19, 680);
            this.End_Edit_Button.Name = "End_Edit_Button";
            this.End_Edit_Button.Size = new System.Drawing.Size(176, 49);
            this.End_Edit_Button.TabIndex = 22;
            this.End_Edit_Button.Text = "Готово";
            this.End_Edit_Button.UseVisualStyleBackColor = true;
            this.End_Edit_Button.Click += new System.EventHandler(this.End_Edit_Button_Click);
            // 
            // Edit_OKPD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.End_Edit_Button);
            this.Controls.Add(this.Code_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Code_OKPD2_String);
            this.Controls.Add(this.Name_OKPD2_String);
            this.Controls.Add(this.Main_Info_Text);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Edit_OKPD2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_Info_Text;
        private System.Windows.Forms.Label Code_Text;
        private System.Windows.Forms.Label Name_Text;
        private System.Windows.Forms.TextBox Code_OKPD2_String;
        private System.Windows.Forms.TextBox Name_OKPD2_String;
        private System.Windows.Forms.Button End_Edit_Button;
    }
}