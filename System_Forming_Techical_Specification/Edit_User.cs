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
    public partial class Edit_User : Form
    {
        void Change_User_Func()
        {

        }
        public Edit_User()
        {
            InitializeComponent();
        }

        private void Main_Info_Text_Click(object sender, EventArgs e)
        {

        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Change_User_Func();
            Edit_Items f1 = new Edit_Items();
            this.Close();
            f1.ShowDialog();
        }
    }
}
