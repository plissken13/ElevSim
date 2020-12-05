using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentation;

namespace ElevSim
{
    public partial class NewBuilding : Form, INewBuilding
    {
        public int FloorsNumber => int.Parse(textBox1.Text);

        public int LiftsNumber => int.Parse(textBox2.Text);

        public NewBuilding()
        {
            InitializeComponent();
        }

        public event Action NewB;

        private void button3_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Close();
        }
    }
}
