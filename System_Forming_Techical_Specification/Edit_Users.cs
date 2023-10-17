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
    public partial class Edit_Users : Form
    {
        void Delete_User_Func()
        {

        }
        void Insert_User_Func()
        {

        }
        public Edit_Users()
        {
            InitializeComponent();
        }

        private void Top_String_Text_Click(object sender, EventArgs e)
        {

        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();           
            this.Close();
            f1.ShowDialog();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Delete_User_Func();
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            Insert_User_Func();
        }

        private void User_Window_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Edit_User f1 = new Edit_User();
            this.Close();
            f1.ShowDialog();
        }
    }
}
