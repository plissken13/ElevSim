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

        public int StartFloor => int.Parse(textBox2.Text);

        public int EndFloor => int.Parse(textBox3.Text);

        List<string> names = new List<string>
        {
            "Vlad",
            "Ilya",
            "Kyle",
            "Lloyd",
            "Oleg",
            "Mario",
            "Samuel",
            "Yury",
            "Max",
            "Basil"
        };

        public AddWorker()
        {
            InitializeComponent();

       
        }

        public event Action AddW;

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Close();
            //AddW?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(1, names.Count);
            textBox1.Text = names[num];
            textBox2.Text = rand.Next(1, 10).ToString();
            textBox3.Text = rand.Next(1, 10).ToString();
        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }

    }
}
