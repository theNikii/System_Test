using Npgsql;
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
    public partial class Info_About_System_Window : Form
    {

        void Perconal_Info_OutPut_Func()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");

            conn.Open();
            string comText = "select user_name from \"User\" where user_login = 'test_Super_Admin'";
            NpgsqlCommand comm = new NpgsqlCommand(comText, conn);
            Name_User_String.Text = comm.ExecuteScalar().ToString();

            string comText1 = "select user_role from \"User\" where user_login = 'test_Super_Admin'";
            NpgsqlCommand comn = new NpgsqlCommand(comText1, conn);
            Role_User_String.Text = comn.ExecuteScalar().ToString();
        }

        void Open_Document_System_Func()
        {

        }

        void Open_Document_Terms_Func()
        {

        }
        public Info_About_System_Window()
        {
            InitializeComponent();

            Perconal_Info_OutPut_Func();
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

        private void System_Info_Document_Button_Click(object sender, EventArgs e)
        {
            Open_Document_System_Func();
        }

        private void Termin_Info_Document_Button_Click(object sender, EventArgs e)
        {
            Open_Document_Terms_Func();
        }

        private void Pc_Window_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_User_String_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
