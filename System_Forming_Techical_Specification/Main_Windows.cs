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
    public partial class Main_Windows : Form
    {
    

        public Main_Windows()
        {         

         InitializeComponent();

        
        // this.Close();
           
        }

        private void Main_Windows_Load(object sender, EventArgs e)
        {
           
        }

        private void Enter_To_System_Button_Click(object sender, EventArgs e)
        {
            Personal_Cabinet_Window f1 = new Personal_Cabinet_Window();
           // this.Close();
            f1.ShowDialog();

        }
    }
}
