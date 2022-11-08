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
        Bitmap DrawArea;
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
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
            pictureBox1.BackgroundImage = Coursework.Properties.Resources.grass;
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
                a1.Text = "Level " + woodLvl + " plantation. Produces " + woodMult + " wood per sec. Upgrade cost: $" + woodLvlUp;
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
            btn_logCount.Text = "Wood: " + wood;
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
            btn_logCount.Text = "Wood: " + wood;
            money1.Text = "Money: $" + money;
            wood = 0;
        }

        private void btn_newTile_Click(object sender, EventArgs e)
        {

            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Black);

            int a = 10;
            int b = 10;
            int c = 100;
            int d = 100;

            for (int j = 0; j < 9; j++)
            {

                for (int i = 0; i < 16; i++)
                {
                    g.DrawRectangle(mypen, a, b, c, d);

                    a = a + 110;
                }
                a = 10;
                b = b + 110;
            }

            a = 10;
            b = 10;

            pictureBox1.Image = DrawArea;

            btn_choiceCancel.Visible = true;
        }

        private void btn_tileChoicePlantation_Click(object sender, EventArgs e)
        {
            

            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_tileChoiceMine_Click(object sender, EventArgs e)
        {
            //switch (tileCount)
            //{
            //    case 2:
            //        a2.Text = "Mine";
            //        a2.BackColor = Color.BlueViolet;
            //        break;
            //    case 3:
            //        a3.Text = "Mine";
            //        a3.BackColor = Color.BlueViolet;
            //        break;
            //    case 4:
            //        a4.Text = "Mine";
            //        a4.BackColor = Color.BlueViolet;
            //        break;
            //    case 5:
            //        a5.Text = "Mine";
            //        a5.BackColor = Color.BlueViolet;
            //        break;
            //    case 6:
            //        a6.Text = "Mine";
            //        a6.BackColor = Color.BlueViolet;
            //        break;
            //}
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_tileChoiceFarm_Click(object sender, EventArgs e)
        {
            //switch (tileCount)
            //{
            //    case 2:
            //        a2.Text = "Farm";
            //        a2.BackColor = Color.OrangeRed;
            //        break;
            //    case 3:
            //        a3.Text = "Farm";
            //        a3.BackColor = Color.OrangeRed;
            //        break;
            //    case 4:
            //        a4.Text = "Farm";
            //        a4.BackColor = Color.OrangeRed;
            //        break;
            //    case 5:
            //        a5.Text = "Farm";
            //        a5.BackColor = Color.OrangeRed;
            //        break;
            //    case 6:
            //        a6.Text = "Farm";
            //        a6.BackColor = Color.OrangeRed;
            //        break;
            //}
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_choiceCancel_Click(object sender, EventArgs e)
        {
            //switch (tileCount)
            //{
            //    case 2:
            //        a2.Visible = false;
            //        break;
            //    case 3:
            //        a3.Visible = false;
            //        break;
            //    case 4:
            //        a4.Visible = false;
            //        break;
            //    case 5:
            //        a5.Visible = false;
            //        break;
            //    case 6:
            //        a6.Visible = false;
            //        break;
            //}
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

        private void exit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);

                Pen mypen = new Pen(Color.Red);
                Point point = new Point(MousePosition.X - 105, MousePosition.Y - 31);

                int changeRectangle = 0;
                int a = 10;
                int b = 10;
                int c = 100;
                int d = 100;
                Rectangle rectangle1 = new Rectangle(a, b, c, d);

                for (int j = 0; j < 9; j++)
                {

                    for (int i = 0; i < 16; i++)
                    {
                        if (rectangle1.Contains(point))
                        {
                            changeRectangle = 1;
                            lbl_choice.Visible = true;
                            btn_choicePlantation.Visible = true;
                            btn_choiceMine.Visible = true;
                            btn_choiceFarm.Visible = true;
                        }
                        else
                        {
                            a = a + 110;
                            rectangle1 = new Rectangle(a, b, c, d);
                        }
                    }
                    if (changeRectangle == 0)
                    {
                        a = 10;
                        b = b + 110;
                        rectangle1 = new Rectangle(a, b, c, d);
                    }
                }

                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                g.FillRectangle(myBrush, rectangle1);
                myBrush.Dispose();
                formGraphics.Dispose();
                g.DrawRectangle(mypen, a, b, c, d);

                a = 10;
                b = 10;

                pictureBox1.Image = DrawArea;
        }

    }
}
