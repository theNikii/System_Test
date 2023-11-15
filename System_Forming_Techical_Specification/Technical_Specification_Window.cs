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
using static System.Net.Mime.MediaTypeNames;

namespace System_Forming_Techical_Specification
{
    public partial class Technical_Specification_Window : Form
    {
        public string Item_names = string.Empty;

        public string Item_characteristic  = string.Empty;
       
        public string Tech_Spec0 = string.Empty;
        public string Tech_Spec1 = string.Empty;
        public string Tech_Spec2 = string.Empty;
        public string Tech_Spec3 = string.Empty;
        public string Tech_Spec4 = string.Empty;


        void New_Table_Func()
        {
           
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
               
                    Tech_Spec0 = dataGridView1.Rows[i].Cells[0].Value + "";
                    Tech_Spec1 = dataGridView1.Rows[i].Cells[1].Value + "";
                    Tech_Spec2 = dataGridView1.Rows[i].Cells[2].Value + "";
                    Tech_Spec3 = dataGridView1.Rows[i].Cells[3].Value + "";
                    Tech_Spec4 = dataGridView1.Rows[i].Cells[4].Value + "";               
            }

            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn2.Open();
            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            comm2.CommandText = "Insert into technical_specification (tech_spec_name_item,tech_spec_value_char,tech_spec_unit_char,tech_spec_count,tech_spec_price," +
                "tech_spec_id,tech_spec_date,tech_spec_to_doc)" +
                "Values(:_search0,:_search1,:_search2,:_search3,:_search4,default, default,default)";
            comm2.Parameters.AddWithValue("_search0", Tech_Spec0);
            comm2.Parameters.AddWithValue("_search1", Tech_Spec1);
            comm2.Parameters.AddWithValue("_search2", Tech_Spec2);
            comm2.Parameters.AddWithValue("_search3", Tech_Spec3);
            comm2.Parameters.AddWithValue("_search4", Tech_Spec4);
            comm2.ExecuteNonQuery();
            //Item_names
            //Item_characteristic
            conn2.Close();

            MessageBox.Show("Добавлено");


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select tech_spec_name_item as \"Наименование товара\", tech_spec_value_char as \"Наименование характеристик\"," +
                " tech_spec_unit_char as \"Единица измерения\", tech_spec_count as \"Количество\"," +
                " tech_spec_price as \"Цена за ед. товара\" from technical_specification where tech_spec_id = 1";
            //id пофиксить потом
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

      
        public Technical_Specification_Window()
        {
            InitializeComponent();
        

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
            Document_Window f1 = new Document_Window();

            this.Close();
            f1.ShowDialog();
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

        private void Technical_Specification_Window_Load(object sender, EventArgs e)
        {

            //here
           
            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn2.Open();
            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            comm2.CommandText = "Update technical_specification SET tech_spec_name_item = @_search , tech_spec_value_char = @_search1 where tech_spec_id = 0";
            comm2.Parameters.AddWithValue("_search", Item_names);
            comm2.Parameters.AddWithValue("_search1", Item_characteristic);
            comm2.ExecuteNonQuery();
            //Item_names
            //Item_characteristic
            conn2.Close();


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select tech_spec_name_item as \"Наименование товара\", tech_spec_value_char as \"Наименование характеристик\"," +
                " tech_spec_unit_char as \"Единица измерения\", tech_spec_count as \"Количество\"," +
                " tech_spec_price as \"Цена за ед. товара\" from technical_specification where tech_spec_id = 0";

            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();


           // New_Table_Func();
        }

        private void Form_tech_spec_Click(object sender, EventArgs e)
        {
            New_Table_Func();
        }

        private void Pc_Window_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
