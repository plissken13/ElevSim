﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElevSim
{
    public partial class ChangeRules : Form
    {
        public ChangeRules()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Close();
        }
    }
}
