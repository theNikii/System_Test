using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace System_Forming_Techical_Specification
{
    public partial class Technical_Specification_Window : Form
    {

        void Table_Output_Func()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select technical_specification_name_nu as \"Наименование товара\", technical_specification_value_c as \"Наименование характеристик\"," +
                " technical_specification_unit_ch as \"Единица измерения\", technical_specification_count as \"Количество\"," +
                " technical_specification_price as \"Цена за ед. товара\" from technical_specification";

            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

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

        void Delete_Row_Func()
        {

        }
        public Technical_Specification_Window()
        {
            InitializeComponent();
            Table_Output_Func();

            Perconal_Info_OutPut_Func();   
     
        }

        private void Top_String_Text_Click(object sender, EventArgs e)
        {

        }

        private void Info_Line_Charistic_Text_Click(object sender, EventArgs e)
        {
           
        }

        private void Personal_Cabinet_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
            
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

      

        private void Send_Info_To_Document_Click(object sender, EventArgs e)
        {
           
        }

        private void Delete_Rows_Technical_Specification_Button_Click(object sender, EventArgs e)
        {
            Delete_Row_Func();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
