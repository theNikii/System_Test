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
    public partial class Edit_Characteristic : Form
    {
        void Change_Characteristic_Func()
        {

        }
        public Edit_Characteristic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Change_Characteristic_Func();
            Edit_Items f1 = new Edit_Items();
            this.Close();
            f1.ShowDialog();
        }
    }
}
