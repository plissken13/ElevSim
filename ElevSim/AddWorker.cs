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
    public partial class AddWorker : Form, IAddWorker
    {
        public string WorkerName => textBox1.Text;

        public string StartFloor => textBox2.Text;

        public string EndFloor => textBox3.Text;

        public AddWorker()
        {
            InitializeComponent();
        }

        public event Action AddW;

        private void button1_Click(object sender, EventArgs e)
        {
            AddW?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //////////RANDOM DATA GENERATING
        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
