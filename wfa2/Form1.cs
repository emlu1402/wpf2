﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hej, Info. Ännu lite mer info. Ytterligare info. Lägger till ännu mer info. Ännu mera info - och så lite till.");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("en knapp och i denna branch kommer fler och fler funktioner att läggas till");
        }
    }
}
