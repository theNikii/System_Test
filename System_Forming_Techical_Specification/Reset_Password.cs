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
    public partial class Reset_Password : Form
    {

        void Check_Login_Func()
        {

        }

        void New_Passowrd_Func()
        {

            Script_Password_Func();
        }

        void Script_Password_Func()
        {

        }
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void End_Reset_Button_Click(object sender, EventArgs e)
        {
            bool accept_password = false;

            Check_Login_Func();
            if(accept_password == false)
            {
                Error_Reset_Password f2 = new Error_Reset_Password();
                this.Close();
                f2.ShowDialog();
            }
            else
            {
                New_Passowrd_Func();
                Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
                this.Close();
                f1.ShowDialog();
            }


        }

        private void Go_To_Pc_Button_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
            this.Close();
            f1.ShowDialog();
        }
    }
}
