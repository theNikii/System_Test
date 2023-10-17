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
    public partial class Change_Password_Window : Form
    {

        void Generate_Password_Func()
        {

        }

        void Change_Password_Func()
        {
            Script_Password_Func();
        }

        void Script_Password_Func()
        {

        }
        public Change_Password_Window()
        {
            InitializeComponent();
        }

        private void Text_Log_Pass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Text_Password_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            bool error_check = false;

            Change_Password_Func();

            if(error_check == true)
            {
                Change_Password_Window f2 = new Change_Password_Window();
                this.Close();
                f2.ShowDialog();
            }
            else
            {
                Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
                this.Close();
                f1.ShowDialog();
            }
         
           
        }

        private void Generate_Password_Button_Click(object sender, EventArgs e)
        {
            Generate_Password_Func();
        }
    }
}
