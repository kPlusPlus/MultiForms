﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class frmMain : Form
    {
        Form1 form1;
        Form2 form2;
        Form3 form3;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            form1 = new Form1();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            form2 = new Form2();
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            form3 = new Form3();
            form3.TopLevel = false;
            panel1.Controls.Add(form3);
            form3.Show();
        }
    }
}
