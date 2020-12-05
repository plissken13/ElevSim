using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace ElevSim
{
    public partial class StartForm : Form, IStartForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public event Action ShowAddWorker;

    
        private void button1_Click(object sender, EventArgs e)
        {
            NewBuilding newBuilding = new NewBuilding();
            newBuilding.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.Show();
            //ShowAddWorker?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeRules changeRules = new ChangeRules();
            changeRules.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
        }


        /* public void Show()
         {
             throw new NotImplementedException();
         }

         public void Close()
         {
             throw new NotImplementedException();
         }

         */
    }
}
