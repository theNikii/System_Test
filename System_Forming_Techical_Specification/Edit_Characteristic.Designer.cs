namespace System_Forming_Techical_Specification
{
    partial class Edit_Characteristic
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
            this.Unit_Text = new System.Windows.Forms.Label();
            this.Code_OKPD2_Item_Text = new System.Windows.Forms.TextBox();
            this.Value_Text = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.Label();
            this.Value_String = new System.Windows.Forms.TextBox();
            this.Name_Item_String = new System.Windows.Forms.TextBox();
            this.End_Edit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Main_Info_Text
            // 
            this.Main_Info_Text.AutoSize = true;
            this.Main_Info_Text.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_Info_Text.Location = new System.Drawing.Point(288, 9);
            this.Main_Info_Text.Name = "Main_Info_Text";
            this.Main_Info_Text.Size = new System.Drawing.Size(344, 31);
            this.Main_Info_Text.TabIndex = 3;
            this.Main_Info_Text.Text = "Изменение Характеристик";
            // 
            // Unit_Text
            // 
            this.Unit_Text.AutoSize = true;
            this.Unit_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit_Text.Location = new System.Drawing.Point(24, 221);
            this.Unit_Text.Name = "Unit_Text";
            this.Unit_Text.Size = new System.Drawing.Size(173, 21);
            this.Unit_Text.TabIndex = 35;
            this.Unit_Text.Text = "Единица измерения:";
            // 
            // Code_OKPD2_Item_Text
            // 
            this.Code_OKPD2_Item_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code_OKPD2_Item_Text.Location = new System.Drawing.Point(28, 245);
            this.Code_OKPD2_Item_Text.Multiline = true;
            this.Code_OKPD2_Item_Text.Name = "Code_OKPD2_Item_Text";
            this.Code_OKPD2_Item_Text.Size = new System.Drawing.Size(906, 31);
            this.Code_OKPD2_Item_Text.TabIndex = 34;
            // 
            // Value_Text
            // 
            this.Value_Text.AutoSize = true;
            this.Value_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Value_Text.Location = new System.Drawing.Point(25, 143);
            this.Value_Text.Name = "Value_Text";
            this.Value_Text.Size = new System.Drawing.Size(87, 21);
            this.Value_Text.TabIndex = 33;
            this.Value_Text.Text = "Значение:";
            // 
            // Name_Text
            // 
            this.Name_Text.AutoSize = true;
            this.Name_Text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Text.Location = new System.Drawing.Point(24, 75);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(88, 21);
            this.Name_Text.TabIndex = 32;
            this.Name_Text.Text = "Название:";
            // 
            // Value_String
            // 
            this.Value_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Value_String.Location = new System.Drawing.Point(28, 167);
            this.Value_String.Multiline = true;
            this.Value_String.Name = "Value_String";
            this.Value_String.Size = new System.Drawing.Size(906, 31);
            this.Value_String.TabIndex = 31;
            // 
            // Name_Item_String
            // 
            this.Name_Item_String.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Item_String.Location = new System.Drawing.Point(28, 99);
            this.Name_Item_String.Multiline = true;
            this.Name_Item_String.Name = "Name_Item_String";
            this.Name_Item_String.Size = new System.Drawing.Size(906, 31);
            this.Name_Item_String.TabIndex = 30;
            // 
            // End_Edit_Button
            // 
            this.End_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_Edit_Button.Location = new System.Drawing.Point(35, 672);
            this.End_Edit_Button.Name = "End_Edit_Button";
            this.End_Edit_Button.Size = new System.Drawing.Size(176, 49);
            this.End_Edit_Button.TabIndex = 38;
            this.End_Edit_Button.Text = "Готово";
            this.End_Edit_Button.UseVisualStyleBackColor = true;
            this.End_Edit_Button.Click += new System.EventHandler(this.End_Edit_Button_Click);
            // 
            // Edit_Characteristic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.End_Edit_Button);
            this.Controls.Add(this.Unit_Text);
            this.Controls.Add(this.Code_OKPD2_Item_Text);
            this.Controls.Add(this.Value_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Value_String);
            this.Controls.Add(this.Name_Item_String);
            this.Controls.Add(this.Main_Info_Text);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Edit_Characteristic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_Info_Text;
        private System.Windows.Forms.Label Unit_Text;
        private System.Windows.Forms.TextBox Code_OKPD2_Item_Text;
        private System.Windows.Forms.Label Value_Text;
        private System.Windows.Forms.Label Name_Text;
        private System.Windows.Forms.TextBox Value_String;
        private System.Windows.Forms.TextBox Name_Item_String;
        private System.Windows.Forms.Button End_Edit_Button;
    }
}