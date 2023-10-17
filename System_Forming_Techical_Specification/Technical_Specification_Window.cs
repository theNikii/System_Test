using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Forming_Techical_Specification
{
    public partial class Technical_Specification_Window : Form
    {
        void Delete_Row_Func()
        {

        }
        public Technical_Specification_Window()
        {
            InitializeComponent();
        }

        private void Top_String_Text_Click(object sender, EventArgs e)
        {

        }

        private void Info_Line_Charistic_Text_Click(object sender, EventArgs e)
        {
           
        }

        private void Personal_Cabinet_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
            
            this.Close();
            f1.ShowDialog();

        }

        private void Info_System_Button_Click(object sender, EventArgs e)
        {
            Info_About_System_Window f1 = new Info_About_System_Window();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Techi_Task_Button_Click(object sender, EventArgs e)
        {
            Technical_Specification_Window f1 = new Technical_Specification_Window();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Forming_Document_Button_Click(object sender, EventArgs e)
        {
            Document_Window f1 = new Document_Window();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Search_System_Button_Click(object sender, EventArgs e)
        {
            Search_WIndow f1 = new Search_WIndow();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Change_Technical_Specification_Button_Click(object sender, EventArgs e)
        {
            Edit_Technical_Specification f1 = new Edit_Technical_Specification();
           
            this.Close();
            f1.ShowDialog();
        }

        private void Send_Info_To_Document_Click(object sender, EventArgs e)
        {
            Edit_Document f1 = new Edit_Document();
            this.Close();
            f1.ShowDialog();
        }

        private void Delete_Rows_Technical_Specification_Button_Click(object sender, EventArgs e)
        {
            Delete_Row_Func();
        }
    }
}
