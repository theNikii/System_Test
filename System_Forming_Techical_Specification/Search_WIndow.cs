using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System_Forming_Techical_Specification
{
    public partial class Search_WIndow : Form
    {
       

        void Perconal_Info_OutPut_Func()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");

            conn.Open();
            string comText = "select user_name from \"User\" where user_login = 'admin'";
            NpgsqlCommand comm = new NpgsqlCommand(comText, conn);
            Name_User_String.Text = comm.ExecuteScalar().ToString();

            string comText1 = "select user_role from \"User\" where user_login = 'admin'";
            NpgsqlCommand comn = new NpgsqlCommand(comText1, conn);
            Role_User_String.Text = comn.ExecuteScalar().ToString();
        }
        public Search_WIndow()
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

        private void Search_System_Button_Click(object sender, EventArgs e)
        {
            Search_WIndow f1 = new Search_WIndow();
            
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
           string search_string = "%" + Search_Item_String.Text + "%";

         

            // SELECT* FROM "okpd2" WHERE okpd2.okpd2_name LIKE '%электронных%' ORDER BY okpd2.okpd2_name

            Window_OKPD2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Window_OKPD2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Window_OKPD2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select okpd2.ocpd2_code as \"Код\", okpd2.okpd2_name  as \"Наименование \" from \"okpd2\"  WHERE okpd2.okpd2_name LIKE :_search ORDER BY okpd2.okpd2_name ";
            comm.Parameters.AddWithValue("_search", search_string);

            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                Window_OKPD2.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();


            Window_KTRY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Window_KTRY.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Window_KTRY.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn1 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn1.Open();
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn1;
            comm1.CommandType = CommandType.Text;
            comm1.CommandText = "select ktru.ktru_code as \"Код\", ktru.ktru_name  as \"Наименование \" from \"ktru\"  WHERE ktru.ktru_name LIKE :_search ORDER BY ktru.ktru_name ";
            comm1.Parameters.AddWithValue("_search", search_string);

            NpgsqlDataReader dr1 = comm1.ExecuteReader();
            if (dr1.HasRows)
            {
                System.Data.DataTable dt1 = new System.Data.DataTable();
                dt1.Load(dr1);
                Window_KTRY.DataSource = dt1;
            }
            comm1.Dispose();
            conn1.Close();


        }

        private void Main_Window_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_User_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_User_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Window_OKPD2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Window_KTRY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Window_OKPD2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string okpdtoktry = Window_OKPD2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

            Window_KTRY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Window_KTRY.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Window_KTRY.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn1 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn1.Open();
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn1;
            comm1.CommandType = CommandType.Text;
            comm1.CommandText = "select ktru.ktru_code as \"Код\", ktru.ktru_name  as \"Наименование \" from \"ktru\"  WHERE ktru.ocpd2_code = :_search ORDER BY ktru.ktru_name ";
            comm1.Parameters.AddWithValue("_search", okpdtoktry);
           

            NpgsqlDataReader dr1 = comm1.ExecuteReader();
            if (dr1.HasRows)
            {
                System.Data.DataTable dt1 = new System.Data.DataTable();
                dt1.Load(dr1);
                Window_KTRY.DataSource = dt1;
            }
            comm1.Dispose();
            conn1.Close();

        }

        private void Window_KTRY_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string x = Window_KTRY.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            string y = Window_KTRY.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            Item_Window myForm = new Item_Window();
            myForm.Item_name = x;
            myForm.Item_name_code_ktry = y;
            myForm.ShowDialog();

        }

        private void Search_Item_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_WIndow_Load(object sender, EventArgs e)
        {

        }
    }
}
