﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_TA.Forms
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Gunakan jasa kami (Stay at Home)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Gunakan jasa kami (Stay at Home)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pesanSekarang1.BringToFront();
            labelTitle.Text = "Pesan Sekarang";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu.BringToFront();
            labelTitle.Text = "Menu takjil";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
