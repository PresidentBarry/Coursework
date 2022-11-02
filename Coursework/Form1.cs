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
        //Wood variables
        double wood = 0;
        double money = 50;
        int woodLvlUp = 5;
        double woodLvl = 0;
        double woodMult = 0;

        double tileCount = 2;
        public Form1()
        {
            InitializeComponent();
            money1.Text = "Money: $" + money;
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            if (money >= woodLvlUp)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                woodLvl++;
                money = money - woodLvlUp;
                if (woodMult == 0)
                {
                    woodMult = 0.25;
                }
                else
                {
                    woodMult = woodMult * 2;
                }
                woodLvlUp = (int)(woodLvlUp * 1.95);
                tile1.Text = "Level " + woodLvl + " plantation. Produces " + woodMult + " wood per sec. Upgrade cost: $" + woodLvlUp;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            lbl_exitConfirm.Visible = true;
            btn_exitYes.Visible = true;
            btn_exitNo.Visible = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btn_WoodCount.Text = "Wood: " + wood;
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
            btn_WoodCount.Text = "Wood: " + wood;
            money1.Text = "Money: $" + money;
            wood = 0;
        }

        private void btn_newTile_Click(object sender, EventArgs e)
        {
            //switch (tileCount)
            //{
            //    case 2:
            //        tile2.Visible = true;
            //        break;
            //    case 3:
            //        tile3.Visible = true;
            //        break;
            //    case 4:
            //        tile4.Visible = true;
            //        break;
            //    case 5:
            //        tile5.Visible = true;
            //        break;
            //    case 6:
            //        tile6.Visible = true;
            //        break;
            //}

            //for (int i = 0; i < 84; i++)
            //{
            //    string tile = String.Concat("tile", i);
            //    $tile
            //}
            

            //for (int i = 0; i < 84; i++)
            //{
            //    tile(i).visible = true;
            //}

            lbl_choice.Visible = true;
            btn_choiceCancel.Visible = true;
            btn_choicePlantation.Visible = true;
            btn_choiceMine.Visible = true;
            btn_choiceFarm.Visible = true;
        }

        private void btn_tileChoicePlantation_Click(object sender, EventArgs e)
        {
            switch (tileCount)
            {
                case 2:
                    tile2.Text = "Plantation";
                    tile2.BackColor = Color.SaddleBrown;
                    break;
                case 3:
                    tile3.Text = "Plantation";
                    tile3.BackColor = Color.SaddleBrown;
                    break;
                case 4:
                    tile4.Text = "Plantation";
                    tile4.BackColor = Color.SaddleBrown;
                    break;
                case 5:
                    tile5.Text = "Plantation";
                    tile5.BackColor = Color.SaddleBrown;
                    break;
                case 6:
                    tile6.Text = "Plantation";
                    tile6.BackColor = Color.SaddleBrown;
                    break;
            }
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_tileChoiceMine_Click(object sender, EventArgs e)
        {
            switch (tileCount)
            {
                case 2:
                    tile2.Text = "Mine";
                    tile2.BackColor = Color.BlueViolet;
                    break;
                case 3:
                    tile3.Text = "Mine";
                    tile3.BackColor = Color.BlueViolet;
                    break;
                case 4:
                    tile4.Text = "Mine";
                    tile4.BackColor = Color.BlueViolet;
                    break;
                case 5:
                    tile5.Text = "Mine";
                    tile5.BackColor = Color.BlueViolet;
                    break;
                case 6:
                    tile6.Text = "Mine";
                    tile6.BackColor = Color.BlueViolet;
                    break;
            }
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_tileChoiceFarm_Click(object sender, EventArgs e)
        {
            switch (tileCount)
            {
                case 2:
                    tile2.Text = "Farm";
                    tile2.BackColor = Color.OrangeRed;
                    break;
                case 3:
                    tile3.Text = "Farm";
                    tile3.BackColor = Color.OrangeRed;
                    break;
                case 4:
                    tile4.Text = "Farm";
                    tile4.BackColor = Color.OrangeRed;
                    break;
                case 5:
                    tile5.Text = "Farm";
                    tile5.BackColor = Color.OrangeRed;
                    break;
                case 6:
                    tile6.Text = "Farm";
                    tile6.BackColor = Color.OrangeRed;
                    break;
            }
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_choiceCancel_Click(object sender, EventArgs e)
        {
            switch (tileCount)
            {
                case 2:
                    tile2.Visible = false;
                    break;
                case 3:
                    tile3.Visible = false;
                    break;
                case 4:
                    tile4.Visible = false;
                    break;
                case 5:
                    tile5.Visible = false;
                    break;
                case 6:
                    tile6.Visible = false;
                    break;
            }
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_upgrades.Visible = true;
            btn_UpgradesCancel.Visible = true;
            lbl_upgradesTile.Visible = true;
        }

        private void btn_UpgradesCancel_Click(object sender, EventArgs e)
        {
            lbl_upgrades.Visible = false;
            btn_UpgradesCancel.Visible = false;
            lbl_upgradesTile.Visible = false;
            btn_woodUpg1.Visible = false;
        }

        private void btn_exitYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exitNo_Click(object sender, EventArgs e)
        {
            lbl_exitConfirm.Visible = false;
            btn_exitYes.Visible = false;
            btn_exitNo.Visible = false;
        }

        private void lbl_upgradesTile_Click(object sender, EventArgs e)
        {

        }
    }
}
