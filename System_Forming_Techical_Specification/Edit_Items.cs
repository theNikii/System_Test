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
   
    public partial class Edit_Items : Form
    {
        void Change_Items_Func()
        {

        }
        public Edit_Items()
        {
            InitializeComponent();
        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Change_Items_Func();
            Edit_Items f1 = new Edit_Items();
            this.Close();
            f1.ShowDialog();
        }
    }
}
