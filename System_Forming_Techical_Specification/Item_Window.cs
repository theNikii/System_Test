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
    public partial class Item_Window : Form
    {
        public Item_Window()
        {
            InitializeComponent();
        }

        private void Info_Line_System_Text_Click(object sender, EventArgs e)
        {

        }

        private void Top_String_Text_Click(object sender, EventArgs e)
        {

        }

        private void Personal_Cabinet_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
            f1.ShowDialog();
            this.Close();
        }

        private void Info_System_Button_Click(object sender, EventArgs e)
        {
            Info_About_System_Window f1 = new Info_About_System_Window();
            f1.ShowDialog();
            this.Close();
        }

        private void Techi_Task_Button_Click(object sender, EventArgs e)
        {
            Technical_Specification_Window f1 = new Technical_Specification_Window();
            f1.ShowDialog();
            this.Close();
        }

        private void Forming_Document_Button_Click(object sender, EventArgs e)
        {
            Document_Window f1 = new Document_Window();
            f1.ShowDialog();
            this.Close();
        }

        private void Search_System_Button_Click(object sender, EventArgs e)
        {
            Search_WIndow f1 = new Search_WIndow();
            f1.ShowDialog();
            this.Close();
        }

        private void Insert_To_Technical_Specification_Button_Click(object sender, EventArgs e)
        {
            Technical_Specification_Window f1 = new Technical_Specification_Window();
            f1.ShowDialog();
            this.Close();
        }

        private void Back_To_Search_Button_Click(object sender, EventArgs e)
        {
            Search_WIndow f1 = new Search_WIndow();
            f1.ShowDialog();
            this.Close();
        }
    }
}
