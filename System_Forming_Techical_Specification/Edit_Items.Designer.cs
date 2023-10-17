namespace System_Forming_Techical_Specification
{
    partial class Edit_Items
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
            this.Code_KTRY_Text = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.Label();
            this.Code_KTPY_String = new System.Windows.Forms.TextBox();
            this.Name_Item_String = new System.Windows.Forms.TextBox();
            this.Code_OKPD2_Text = new System.Windows.Forms.Label();
            this.Code_OKPD2_Item_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Main_Info_Text
            // 
            this.Main_Info_Text.AutoSize = true;
            this.Main_Info_Text.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_Info_Text.Location = new System.Drawing.Point(287, 18);
            this.Main_Info_Text.Name = "Main_Info_Text";
            this.Main_Info_Text.Size = new System.Drawing.Size(335, 31);
            this.Main_Info_Text.TabIndex = 2;
            this.Main_Info_Text.Text = "Изменение нуменклатуры";
            // 
            // End_Edit_Button
            // 
            this.End_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_Edit_Button.Location = new System.Drawing.Point(29, 650);
            this.End_Edit_Button.Name = "End_Edit_Button";
            this.End_Edit_Button.Size = new System.Drawing.Size(176, 49);
            this.End_Edit_Button.TabIndex = 27;
            this.End_Edit_Button.Text = "Готово";
            this.End_Edit_Button.UseVisualStyleBackColor = true;
            this.End_Edit_Button.Click += new System.EventHandler(this.End_Edit_Button_Click);
            // 
            // Code_KTRY_Text
            // 
            this.Code_KTRY_Text.AutoSize = true;
            this.Code_KTRY_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code_KTRY_Text.Location = new System.Drawing.Point(25, 131);
            this.Code_KTRY_Text.Name = "Code_KTRY_Text";
            this.Code_KTRY_Text.Size = new System.Drawing.Size(98, 21);
            this.Code_KTRY_Text.TabIndex = 26;
            this.Code_KTRY_Text.Text = "Код КТРУ:";
            // 
            // Name_Text
            // 
            this.Name_Text.AutoSize = true;
            this.Name_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Text.Location = new System.Drawing.Point(18, 63);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(88, 21);
            this.Name_Text.TabIndex = 25;
            this.Name_Text.Text = "Название:";
            this.Name_Text.Click += new System.EventHandler(this.Name_Text_Click);
            // 
            // Code_KTPY_String
            // 
            this.Code_KTPY_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code_KTPY_String.Location = new System.Drawing.Point(22, 155);
            this.Code_KTPY_String.Multiline = true;
            this.Code_KTPY_String.Name = "Code_KTPY_String";
            this.Code_KTPY_String.Size = new System.Drawing.Size(906, 31);
            this.Code_KTPY_String.TabIndex = 24;
            // 
            // Name_Item_String
            // 
            this.Name_Item_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Item_String.Location = new System.Drawing.Point(22, 87);
            this.Name_Item_String.Multiline = true;
            this.Name_Item_String.Name = "Name_Item_String";
            this.Name_Item_String.Size = new System.Drawing.Size(906, 31);
            this.Name_Item_String.TabIndex = 23;
            this.Name_Item_String.TextChanged += new System.EventHandler(this.Name_Item_String_TextChanged);
            // 
            // Code_OKPD2_Text
            // 
            this.Code_OKPD2_Text.AutoSize = true;
            this.Code_OKPD2_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code_OKPD2_Text.Location = new System.Drawing.Point(18, 209);
            this.Code_OKPD2_Text.Name = "Code_OKPD2_Text";
            this.Code_OKPD2_Text.Size = new System.Drawing.Size(112, 21);
            this.Code_OKPD2_Text.TabIndex = 29;
            this.Code_OKPD2_Text.Text = "Код ОКПД2:";
            // 
            // Code_OKPD2_Item_Text
            // 
            this.Code_OKPD2_Item_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code_OKPD2_Item_Text.Location = new System.Drawing.Point(22, 233);
            this.Code_OKPD2_Item_Text.Multiline = true;
            this.Code_OKPD2_Item_Text.Name = "Code_OKPD2_Item_Text";
            this.Code_OKPD2_Item_Text.Size = new System.Drawing.Size(906, 31);
            this.Code_OKPD2_Item_Text.TabIndex = 28;
            // 
            // Edit_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.Code_OKPD2_Text);
            this.Controls.Add(this.Code_OKPD2_Item_Text);
            this.Controls.Add(this.End_Edit_Button);
            this.Controls.Add(this.Code_KTRY_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Code_KTPY_String);
            this.Controls.Add(this.Name_Item_String);
            this.Controls.Add(this.Main_Info_Text);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Edit_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_Info_Text;
        private System.Windows.Forms.Button End_Edit_Button;
        private System.Windows.Forms.Label Code_KTRY_Text;
        private System.Windows.Forms.Label Name_Text;
        private System.Windows.Forms.TextBox Code_KTPY_String;
        private System.Windows.Forms.TextBox Name_Item_String;
        private System.Windows.Forms.Label Code_OKPD2_Text;
        private System.Windows.Forms.TextBox Code_OKPD2_Item_Text;
    }
}