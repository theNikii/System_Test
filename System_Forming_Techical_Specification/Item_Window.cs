using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System_Forming_Techical_Specification
{
    public partial class Item_Window : Form
    {
        public string Item_name = string.Empty;

        public string Item_name_code_ktry = string.Empty;


      
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

        public Item_Window()
        {
            InitializeComponent();
            

            Perconal_Info_OutPut_Func();
        }

        private void Info_Line_System_Text_Click(object sender, EventArgs e)
        {

        }

        private void Top_String_Text_Click(object sender, EventArgs e)
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

        private void Insert_To_Technical_Specification_Button_Click(object sender, EventArgs e)
        {

            string x = Item_name;
            string y = " ";
            
            
            
            Technical_Specification_Window f1 = new Technical_Specification_Window();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Back_To_Search_Button_Click(object sender, EventArgs e)
        {
            Search_WIndow f1 = new Search_WIndow();
            
            this.Close();
            f1.ShowDialog();
        }

        private void Main_Window_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_User_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_User_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Window_Load(object sender, EventArgs e)
        {
           Item_String.Text = Item_name;

            int Nome_id;
            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn2.Open();
            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            //Select nomenclature_id_nomenclature from "nomenclature" Where ktru_code = '58.21.20.000-00000001' :_search 
            comm2.CommandText = "Select nomenclature_id from \"nomenclature\" Where ktru_code = :_search ";
            comm2.Parameters.AddWithValue("_search", Item_name_code_ktry);
            Nome_id = Convert.ToInt32(comm2.ExecuteScalar().ToString());
            Nome_id = ((int)comm2.ExecuteScalar());
            conn2.Close();
            //Item_String.Text = Nome_id.ToString();


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            /*SELECT characteristic.characteristic_name, characteristic.characteristic_value, 
            characteristic.characteristic_unit,
            characteristic.characteristic_into_technical_s FROM "characteristic"
            LEFT JOIN "describe" ds ON ds.characteristic_id_characteristi = characteristic.characteristic_id_characteristi
            LEFT JOIN nomenclature  ON nomenclature.nomenclature_id_nomenclature = ds.nomenclature_id_nomenclature
            WHERE ds.nomenclature_id_nomenclature = 1;*/
            
            comm.CommandText = "select characteristic.characteristic_necessarily as \"Обязательность\",characteristic.characteristic_into_tech_spec as \"Добавить в тз\", " +
                "" +
                "characteristic.characteristic_name as \"Наименование\", characteristic.characteristic_unit as \"Единица измерения\", characteristic.characteristic_value as \"Значение \" from characteristic " +
                "LEFT JOIN \"describe\" ds ON ds.characteristic_id = characteristic.characteristic_id " +
                "LEFT JOIN nomenclature  ON nomenclature.nomenclature_id = ds.nomenclature_id" +
                " WHERE ds.nomenclature_id = :_search" +
                " ORDER By characteristic.characteristic_necessarily";
            comm.Parameters.AddWithValue("_search", Nome_id);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
