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
        public string WorkerName => textBox3.Text;

        public int StartFloor => int.Parse(textBox1.Text);

        public int EndFloor => int.Parse(textBox2.Text);

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
            textBox3.Text = names[num];
            textBox1.Text = rand.Next(1, 10).ToString();
            textBox2.Text = rand.Next(1, 10).ToString();
        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }

    }
}
