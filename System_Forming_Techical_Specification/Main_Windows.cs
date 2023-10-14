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
    public partial class Main_Windows : Form
    {
    

        public Main_Windows()
        {         

         InitializeComponent();

         Authorization_Window f1 = new Authorization_Window();
         f1.ShowDialog();
         this.Close();
           
        }

        private void Main_Windows_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Personal_Cabinet_Click(object sender, EventArgs e)
        {
           
        }

        private void Info_System_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void Techi_Task_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void Forming_Document_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void Main_Window_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_System_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Pc_Window_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Search_Item_Click(object sender, EventArgs e)
        {

        }

        private void Search_Item_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searh_Button_Click(object sender, EventArgs e)
        {

        }

        private void Clean_Item_String_Button_Click(object sender, EventArgs e)
        {

        }

        private void Window_KTRY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Text_KTRY_Click(object sender, EventArgs e)
        {

        }

        private void Window_OKPD2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
