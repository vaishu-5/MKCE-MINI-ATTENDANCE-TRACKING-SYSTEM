﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKCE_Mini
{
    public partial class Admin_Screen : Form
    {
        public Admin_Screen()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FrmHome = new Home();
            FrmHome.Show();

        }
    }
}
