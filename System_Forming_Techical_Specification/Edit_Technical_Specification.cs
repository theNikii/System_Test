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
    public partial class Edit_Technical_Specification : Form
    {
        public Edit_Technical_Specification()
        {
            InitializeComponent();
        }

        private void Header_Text_Click(object sender, EventArgs e)
        {

        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Technical_Specification_Window f1 = new Technical_Specification_Window();
            f1.ShowDialog();
            this.Close();
        }
    }
}
