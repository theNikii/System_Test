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
    public partial class Edit_OKPD2 : Form
    {
        void Change_OKPD2_Func()
        {

        }
        public Edit_OKPD2()
        {
            InitializeComponent();
        }

        private void Main_Info_Text_Click(object sender, EventArgs e)
        {

        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Change_OKPD2_Func();
            Edit_Item f1 = new Edit_Item();
            this.Close();
            f1.ShowDialog();
        }

        private void Header_Document_String_TextChanged(object sender, EventArgs e)
        {

        }

        private void Header_Text_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Text_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Document_String_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
