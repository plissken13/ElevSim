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

       public int LiftsNumber => int.Parse(textBox17.Text);
        /*public int Capacity1 => int.Parse(textBox2.Text);
       public int Capacity2 => int.Parse(textBox5.Text);
       public int Capacity3 => int.Parse(textBox8.Text);
       public int Capacity4 => int.Parse(textBox11.Text);
       public int Capacity5 => int.Parse(textBox14.Text);*/

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
