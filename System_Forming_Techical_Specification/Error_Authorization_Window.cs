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
    public partial class Error_Authorization_Window : Form
    {
        void Check_Password_Accept_Func()
        {
            Descript_Password_Func();
            
        }

        void Descript_Password_Func()
        {

        }

        public Error_Authorization_Window()
        {
            InitializeComponent();
        }

        private void Text_Log_Pass_Click(object sender, EventArgs e)
        {

        }

        private void Enter_To_System_Button_Click(object sender, EventArgs e)
        {
            bool accept_password = false;
            Check_Password_Accept_Func();

            if (accept_password == false)
            {
                Error_Authorization_Window f2 = new Error_Authorization_Window();
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
    }
}
