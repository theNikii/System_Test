﻿using System;
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
    public partial class Edit_Document : Form
    {
        void Change_Document_Func()
        {

        }
        public Edit_Document()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void End_Edit_Button_Click(object sender, EventArgs e)
        {
            Change_Document_Func();
            Document_Window f1 = new Document_Window();
            this.Close();
            f1.ShowDialog();
        }
    }
}
