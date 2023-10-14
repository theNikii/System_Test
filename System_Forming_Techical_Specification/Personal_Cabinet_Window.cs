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
    public partial class Personal_Cabinet_Window : Form
    {
        public Personal_Cabinet_Window()
        {
            InitializeComponent();
        }

        private void Main_Window_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password_Window f1 = new Change_Password_Window();
            f1.ShowDialog();
            this.Close();
        }

        private void Change_User_Button_Click(object sender, EventArgs e)
        {
            Edit_Users f1 = new Edit_Users();
            f1.ShowDialog();
            this.Close();
        }

        private void Reset_Password_Button_Click(object sender, EventArgs e)
        {
            Reset_Password f1 = new Reset_Password();
            f1.ShowDialog();
            this.Close();
        }

        private void Change_Iten_Button_Click(object sender, EventArgs e)
        {
            Edit_Item f1 = new Edit_Item();
            f1.ShowDialog();
            this.Close();
        }
    }
}
