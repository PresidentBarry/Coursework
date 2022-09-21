using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Coursework
{

    public partial class Form1 : Form
    {
        double wood = 0;
        double money = 0;
        double woodUpgrade = 0;
        double woodLvl = 0;
        double woodMult = 0.5;
        double woodUpgCount = 0;
        double woodCount = 0.2;
        public Form1()
        {
            InitializeComponent();
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            if (money >= woodUpgrade)
            {
                if (woodUpgCount == 0)
                {
                    woodUpgrade = 25;
                    woodUpgCount++;
                    woodCount = woodCount + 0.2;
                }
                else
                {
                    woodCount = woodCount + 0.2;
                    money = money - woodUpgrade;
                    woodUpgrade = woodCount * 15;
                    woodUpgCount++;
                }
                woodMult = woodMult * 2;
                woodLvl = woodLvl + 1;
                tile1.Text = "Lvl " + woodLvl + " Plantation " +
                    "Produces " + woodMult + " wood per sec " +
                    "Upgrade: $" + woodUpgrade;
                wood1.Text = "Wood: " + wood;
            }
            else
            {
                tile1.Text = "Insufficient Funds!";
                Thread.Sleep(3000);
                tile1.Text = "Lvl " + woodLvl + " Plantation " +
                    "Produces " + woodMult + " wood per sec " +
                    "Upgrade: $" + woodUpgrade;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            wood1.Text = "Wood: " + wood;
            money1.Text = "Money: $" + money;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (0 == 0)
            {
                Thread.Sleep(1000);
                wood = wood + woodMult;
                backgroundWorker1.ReportProgress(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wood1_Click(object sender, EventArgs e)
        {
            money = money + wood;
            wood1.Text = "Wood: " + wood;
            money1.Text = "Money: $" + money;
            wood = 0;
        }
    }
}
