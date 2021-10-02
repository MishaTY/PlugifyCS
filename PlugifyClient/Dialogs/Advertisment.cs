﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS
{
    public partial class Advertisment : Form
    {
        public Advertisment()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = SystemColors.Control;
            }
        }

        private void btnBuyLater_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ad = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://plugify.cf");
        }
    }
}
