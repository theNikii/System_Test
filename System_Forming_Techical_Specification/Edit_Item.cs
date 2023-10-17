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
    public partial class Edit_Item : Form
    {
        void Search_Item_Func()
        {

        }

        void Delete_Item_Func()
        {

        }
        void Insert_Item_Func()
        {

        }
        public Edit_Item()
        {
            InitializeComponent();
        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
          
            this.Close();
            f1.ShowDialog();
        }

        private void Searh_Button_Click(object sender, EventArgs e)
        {
            Search_Item_Func();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Delete_Item_Func();
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            Insert_Item_Func();
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Edit_Items f1 = new Edit_Items();
            this.Close();
            f1.ShowDialog();
        }

        private void Change_OKPD2_Button_Click(object sender, EventArgs e)
        {
            Edit_OKPD2 f1 = new Edit_OKPD2();
            this.Close();
            f1.ShowDialog();
        }

        private void Change_Characteristic_Button_Click(object sender, EventArgs e)
        {
            Edit_Characteristic f1 = new Edit_Characteristic();
            this.Close();
            f1.ShowDialog();
        }
    }
}
