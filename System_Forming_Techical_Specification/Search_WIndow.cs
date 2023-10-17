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
    public partial class Search_WIndow : Form
    {

        void Search_Item_Func()
        {

        }
        public Search_WIndow()
        {
            InitializeComponent();
        }

        private void Personal_Cabinet_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Search_System_Button_Click(object sender, EventArgs e)
        {
            Search_WIndow f1 = new Search_WIndow();
            
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

        private void Go_To_Item_Button_Click(object sender, EventArgs e)
        {
            Item_Window f1 = new Item_Window();
           
            this.Close();
            f1.ShowDialog();
        }

        private void Searh_Button_Click(object sender, EventArgs e)
        {
            Search_Item_Func();
        }
    }
}
