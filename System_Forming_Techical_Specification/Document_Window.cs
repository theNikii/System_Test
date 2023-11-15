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
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace System_Forming_Techical_Specification
{
    public partial class Document_Window : Form
    {
        public string Tech_Spec0 = string.Empty;
        public string Tech_Spec1 = string.Empty;
        public string Tech_Spec2 = string.Empty;
        public string Tech_Spec3 = string.Empty;
        public string Tech_Spec4 = string.Empty;

        public string Doc0 = string.Empty;
        public string Doc1 = string.Empty;
        public string Doc2 = string.Empty;
        public string Doc3 = string.Empty;
        public string Doc4 = string.Empty;
        public string Doc5 = string.Empty;
        public string Doc6 = string.Empty;
        public string Doc7 = string.Empty;
        public string Doc8 = string.Empty;
        public string Doc9 = string.Empty;

        int Tech_spec_id;
        int Doc_id;
        List<int> Tech_id = new List<int>();

        int count_tech_spec=0;
        // public string Doc10 = string.Empty;
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

        void New_Table_Func()
        {

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                Doc0 = dataGridView1.Rows[i].Cells[0].Value + "";
                Doc1 = dataGridView1.Rows[i].Cells[1].Value + "";
                Doc2 = dataGridView1.Rows[i].Cells[2].Value + "";
                Doc3 = dataGridView1.Rows[i].Cells[3].Value + "";
                Doc4 = dataGridView1.Rows[i].Cells[4].Value + "";
                Doc5 = dataGridView1.Rows[i].Cells[5].Value + "";
                Doc6 = dataGridView1.Rows[i].Cells[6].Value + "";
                Doc7 = dataGridView1.Rows[i].Cells[7].Value + "";
                Doc8 = dataGridView1.Rows[i].Cells[8].Value + "";
                Doc9 = dataGridView1.Rows[i].Cells[9].Value + "";
         
            }

            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn2.Open();
            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            comm2.CommandText = "Insert into document (doc_header,doc_customer,doc_finance,doc_place,doc_time,doc_start_price,doc_info_price," +
                "doc_time_term_price, doc_info_application, doc_info_contract, user_login,doc_id, doc_date" +
                ")" +
                "Values(:_search0,:_search1,:_search2,:_search3,:_search4,:_search5,:_search6,:_search7," +
                ":_search8, :_search9, :_search11, default, default)";
            comm2.Parameters.AddWithValue("_search0", Doc0);
            comm2.Parameters.AddWithValue("_search1", Doc1);
            comm2.Parameters.AddWithValue("_search2", Doc2);
            comm2.Parameters.AddWithValue("_search3", Doc3);
            comm2.Parameters.AddWithValue("_search4", Doc4);
            comm2.Parameters.AddWithValue("_search5", Doc5);
            comm2.Parameters.AddWithValue("_search6", Doc6);
            comm2.Parameters.AddWithValue("_search7", Doc7);
            comm2.Parameters.AddWithValue("_search8", Doc8);
            comm2.Parameters.AddWithValue("_search9", Doc9);
          
            comm2.Parameters.AddWithValue("_search11", "admin");
            //user прорабоатть
            comm2.ExecuteNonQuery();
            //Item_names
            //Item_characteristic
            conn2.Close();

            MessageBox.Show("Добавлено");


            NpgsqlConnection conn3 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn3.Open();
            NpgsqlCommand comm3 = new NpgsqlCommand();
            comm3.Connection = conn3;
            comm3.CommandType = CommandType.Text;

            comm3.CommandText = "Select doc_id from \"document\" Where doc_header = :_search0 and doc_customer = :_search1 and doc_finance= :_search2 and " +
                "doc_place = :_search3 and doc_time= :_search4 and doc_start_price= :_search5 and doc_info_price = :_search6 and " +
                "doc_time_term_price = :_search7 and doc_info_application = :_search8 and doc_info_contract = :_search9";
            
            comm3.Parameters.AddWithValue("_search0", Doc0);
            comm3.Parameters.AddWithValue("_search1", Doc1);
            comm3.Parameters.AddWithValue("_search2", Doc2);
            comm3.Parameters.AddWithValue("_search3", Doc3);
            comm3.Parameters.AddWithValue("_search4", Doc4);
            comm3.Parameters.AddWithValue("_search5", Doc5);
            comm3.Parameters.AddWithValue("_search6", Doc6);
            comm3.Parameters.AddWithValue("_search7", Doc7);
            comm3.Parameters.AddWithValue("_search8", Doc8);
            comm3.Parameters.AddWithValue("_search9", Doc9);

            Doc_id = ((int)comm3.ExecuteScalar());
            //MessageBox.Show(" ID - "+ Doc_id + " ");
            conn3.Close();




            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select doc_header as \"Заголовок\", doc_customer  as \"Заказчик \"," +
               " doc_finance as \" Источник финансирования \", doc_place as \"Место доставки товаров\", " +
               "doc_time as \"Сроки поставок товаров\"," +
               "doc_start_price as \"Максимальная цена договора\", doc_info_price as \" Сведение о включенных в цену товара расходах\"," +
               "doc_time_term_price as \"Срок и условия оплаты товаров\",doc_info_application as \"требования обеспечения заявки\"," +
               "doc_info_contract as \"Требования обеспечения контракта\" from document where doc_id = :_search0";
            comm.Parameters.AddWithValue("_search0", Doc_id);
            
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

        

        public Document_Window()
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

       

        private void Print_Document_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                if ((bool)dataGridView1.Rows[i].Cells[5].Value == true)
                {
                    
                        Tech_Spec0 = dataGridView1.Rows[i].Cells[0].Value + "";
                        Tech_Spec1 = dataGridView1.Rows[i].Cells[1].Value + "";
                        Tech_Spec2 = dataGridView1.Rows[i].Cells[2].Value + "";
                        Tech_Spec3 = dataGridView1.Rows[i].Cells[3].Value + "";
                        Tech_Spec4 = dataGridView1.Rows[i].Cells[4].Value + "";

                   
                    NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
                    conn2.Open();
                    NpgsqlCommand comm2 = new NpgsqlCommand();
                    comm2.Connection = conn2;
                    comm2.CommandType = CommandType.Text;
                    
                    comm2.CommandText = "Select tech_spec_id from \"technical_specification\" Where tech_spec_name_item = :_search0 and tech_spec_value_char = :_search1 and " +
                        "tech_spec_unit_char= :_search2 and  " +
                        "tech_spec_count = :_search3 and tech_spec_price= :_search4  ";
                    
                    comm2.Parameters.AddWithValue("_search0", Tech_Spec0);
                    comm2.Parameters.AddWithValue("_search1", Tech_Spec1);
                    comm2.Parameters.AddWithValue("_search2", Tech_Spec2);
                    comm2.Parameters.AddWithValue("_search3", Tech_Spec3);
                    comm2.Parameters.AddWithValue("_search4", Tech_Spec4);
                    Tech_spec_id = ((int)comm2.ExecuteScalar());
                    conn2.Close();
                    count_tech_spec = count_tech_spec + 1;
                    Tech_id.Add(Tech_spec_id);
                    

                }


                
            }
            NpgsqlConnection conn4 = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn4.Open();
            NpgsqlCommand comm4 = new NpgsqlCommand();
            comm4.Connection = conn4;
            comm4.CommandType = CommandType.Text;



            foreach (var id in Tech_id)
            {
                comm4.CommandText = "INSERT INTO  \"include\" (tech_spec_id,doc_id)  VALUES (:_search0,:_search1)  ";

                comm4.Parameters.AddWithValue("_search0", id);
                comm4.Parameters.AddWithValue("_search1", Doc_id);
                comm4.ExecuteNonQuery();
                MessageBox.Show(" Готово ");
            }
           

            conn4.Close();


            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Техническое задание";
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();

            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            oTable = oDoc.Tables.Add(wrdRng, 9, 3, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.ApplyStyleHeadingRows = true;
            oTable.ApplyStyleLastRow = false;
            oTable.ApplyStyleFirstColumn = true;
            oTable.ApplyStyleLastColumn = false;
            oTable.ApplyStyleRowBands = true;
            oTable.ApplyStyleColumnBands = false;
            oTable.Borders.Enable = 1;

            oTable.Columns[1].Width = 20;
            oTable.Columns[2].Width = 200;
            oTable.Columns[3].Width = 230;

            int r, c;
            string strText;
            for (r = 1; r <= 9; r++)
            {




                for (c = 1; c <= 1; c++)
                {
                    strText = "" + r + "";
                    oTable.Cell(r, c).Range.Text = strText;
                }
                for (c = 2; c <= 2; c++)
                {
                    if (r == 1)
                    {
                        strText = "Заказчик";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 2)
                    {
                        strText = "Источник финансирования";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 3)
                    {
                        strText = "Место доставки товаров (оказания услуг, выполнения работ)";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 4)
                    {
                        strText = "Сроки поставок товаров (оказания услуг, выполнения работ)";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 5)
                    {
                        strText = "Максимальная (начальная) цена договора)";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 6)
                    {
                        strText = "Сведение о включенных в цену товара расходов";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 7)
                    {
                        strText = "Срок и условия оплаты товаров (работ, услуг)";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 8)
                    {
                        strText = "Требование обеспечения заявки для конкурсов и аукционов (от 0 до 5% от начальной (максимальной) цены договора)";
                        oTable.Cell(r, c).Range.Text = strText;
                    }
                    if (r == 9)
                    {
                        strText = "Требование обеспечения исполнения контракта для цонкурсов и аукционов (от 0 до 30% от начальной (максимальной) цены договора)";
                        oTable.Cell(r, c).Range.Text = strText;
                    }

                }
                for (c = 3; c <= 3; c++)
                {
                    if (r == 1)
                    {
                      
                        oTable.Cell(r, c).Range.Text = Doc0;
                    }
                    if (r == 2)
                    {
                       
                        oTable.Cell(r, c).Range.Text = Doc1;
                    }
                    if (r == 3)
                    {
                        
                        oTable.Cell(r, c).Range.Text = Doc2;
                    }
                    if (r == 4)
                    {
                       
                        oTable.Cell(r, c).Range.Text = Doc3;
                    }
                    if (r == 5)
                    {
                        
                        oTable.Cell(r, c).Range.Text = Doc4;
                    }
                    if (r == 6)
                    {
                       
                        oTable.Cell(r, c).Range.Text = Doc5;
                    }
                    if (r == 7)
                    {
                       
                        oTable.Cell(r, c).Range.Text = Doc6;
                    }
                    if (r == 8)
                    {
                        
                        oTable.Cell(r, c).Range.Text = Doc7;
                    }
                    if (r == 9)
                    {
                      
                        oTable.Cell(r, c).Range.Text = Doc8;
                    }
                }
            }


            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Описание товаров, работ, услуг.";
           
            oPara1.Format.SpaceAfter = 24;//24 pt spacing after paragraph.
            oPara1.Range.Font.Bold = 0;
            oPara1.Range.InsertParagraphAfter();

            count_tech_spec+=1;
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, count_tech_spec, 6, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 1;
            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.ApplyStyleHeadingRows = true;
            oTable.ApplyStyleLastRow = false;
            oTable.ApplyStyleFirstColumn = true;
            oTable.ApplyStyleLastColumn = false;
            oTable.ApplyStyleRowBands = true;
            oTable.ApplyStyleColumnBands = false;
            oTable.Borders.Enable = 1;

            oTable.Columns[1].Width = 30;
            oTable.Columns[2].Width = 105;
            oTable.Columns[3].Width = 155;
            oTable.Columns[4].Width = 60;
            oTable.Columns[5].Width = 40;
            oTable.Columns[6].Width = 60;

           oTable.Cell(1, 1).Range.Text = "Номер п/п";
           oTable.Cell(1, 2).Range.Text = "Наименование товара";
           oTable.Cell(1, 3).Range.Text = "Наименование функциональных, эксплуатационных, технических характеристик и потребительских характеристих свойств, а так же требований по комплектации";
           oTable.Cell(1, 4).Range.Text = "Единица измерения";
           oTable.Cell(1, 5).Range.Text = "Количество (меры, объемы, вес, шт., комплект и т.д.)";
           oTable.Cell(1, 6).Range.Text = "Цена за ед. товара";

           

            for (r = 2; r <= count_tech_spec; r++)
            {

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    if ((bool)dataGridView1.Rows[i].Cells[5].Value == true)
                    {

                        Tech_Spec0 = dataGridView1.Rows[i].Cells[0].Value + "";
                        Tech_Spec1 = dataGridView1.Rows[i].Cells[1].Value + "";
                        Tech_Spec2 = dataGridView1.Rows[i].Cells[2].Value + "";
                        Tech_Spec3 = dataGridView1.Rows[i].Cells[3].Value + "";
                        Tech_Spec4 = dataGridView1.Rows[i].Cells[4].Value + "";

                        for (c = 1; c <= 1; c++)
                        {
                            oTable.Cell(1, 1).Range.Text = "Номер п/п";
                            int count_tech_sp = r-1;
                            strText = "" + count_tech_sp + "";
                            oTable.Cell(r, c).Range.Text = strText;

                        }
                        for (c = 2; c <= 2; c++)
                        {
                            oTable.Cell(1, 2).Range.Text = "Наименование товара";
                            strText = Tech_Spec0;
                            oTable.Cell(r, c).Range.Text = strText;
                        }
                        for (c = 3; c <= 3; c++)
                        {
                            oTable.Cell(1, 3).Range.Text = "Наименование функциональных, эксплуатационных, технических характеристик и потребительских характеристих свойств, а так же требований по комплектации";
                            strText = Tech_Spec1;
                            oTable.Cell(r, c).Range.Text = strText;
                        }
                        for (c = 4; c <= 4; c++)
                        {
                            oTable.Cell(1, 4).Range.Text = "Единица измерения";
                            strText = Tech_Spec2;
                            oTable.Cell(r, c).Range.Text = strText;
                        }
                        for (c = 5; c <= 5; c++)
                        {
                            oTable.Cell(1, 5).Range.Text = "Количество (меры, объемы, вес, шт., комплект и т.д.)";
                            strText = Tech_Spec3;
                            oTable.Cell(r, c).Range.Text = strText;
                        }
                        for (c = 6; c <= 6; c++)
                        {
                            oTable.Cell(1, 6).Range.Text = "Цена за ед. товара";

                            strText = Tech_Spec4;
                            oTable.Cell(r, c).Range.Text = strText;
                        }

                    }
                }

            }



            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Ответсвенное лицо _____________________/______________/";
           // oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.Font.Bold = 0;
            oPara1.Range.InsertParagraphAfter();

            //Close this form.
            this.Close();


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

        private void Document_Window_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=System;User id=postgres;Password=Nikrus48;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select doc_header as \"Заголовок\", doc_customer  as \"Заказчик \"," +
               " doc_finance as \" Источник финансирования \", doc_place as \"Место доставки товаров\", " +
               "doc_time as \"Сроки поставок товаров\"," +
               "doc_start_price as \"Максимальная цена договора\", doc_info_price as \" Сведение о включенных в цену товара расходах\"," +
               "doc_time_term_price as \"Срок и условия оплаты товаров\",doc_info_application as \"требования обеспечения заявки\"," +
               "doc_info_contract as \"Требования обеспечения контракта\" from document where doc_id = 0";

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

        private void Form_doc_Click(object sender, EventArgs e)
        {
            New_Table_Func();
        }

        private void Choose_tech_spec_Click(object sender, EventArgs e)
        {

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
                " tech_spec_price as \"Цена за ед. товара\", tech_spec_to_doc as \"Добавить в документ\" from technical_specification Where tech_spec_id > 0 Order by tech_spec_date ";
            
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
    }
}
