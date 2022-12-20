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
        double logs = 0;
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
            btn_logCount.Text = "Wood: " + logs;
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
                logs = logs + woodMult;
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
            money = money + logs;
            btn_logCount.Text = "Logs: " + logs;
            money1.Text = "Money: $" + money;
            logs = 0;
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
                drawRect();

            btn_choiceCancel.Visible = true;
        }

        private void btn_tileChoicePlantation_Click(object sender, EventArgs e)
        {
            btn_DecisionMade.Visible = true;
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Red);

            Rectangle rectangle = drawRect();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.SaddleBrown);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            g.FillRectangle(myBrush, rectangle);
            myBrush.Dispose();
            formGraphics.Dispose();
            g.DrawRectangle(mypen, rectangle);



            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            btn_DecisionMade.Visible = false;
            tileCount++;
        }

        private void btn_tileChoiceMine_Click(object sender, EventArgs e)
        {
            btn_DecisionMade.Visible = true;
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Red);

            Rectangle rectangle = drawRect();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.MediumPurple);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            g.FillRectangle(myBrush, rectangle);
            myBrush.Dispose();
            formGraphics.Dispose();
            g.DrawRectangle(mypen, rectangle);


            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
            tileCount++;
        }

        private void btn_tileChoiceFarm_Click(object sender, EventArgs e)
        {
            btn_DecisionMade.Visible = true;
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Red);

            Rectangle rectangle = drawRect();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            g.FillRectangle(myBrush, rectangle);
            myBrush.Dispose();
            formGraphics.Dispose();
            g.DrawRectangle(mypen, rectangle);

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
            Point userClick = new Point(0, 0);
            if ((btn_choiceCancel.Visible == true) && (lbl_choice.Visible == false))
            {
                userClick = verifyRect();
            }
            if (btn_choiceCancel.Visible == true)
            {
                Rectangle drawTile = new Rectangle(0, 0, 0, 0);
                drawTile = drawRect();
                if (!drawTile.Contains(userClick))
                {

                }

            }
        }

        public Point verifyRect()
        {
            Point mousePos = new Point(MousePosition.X - 105, MousePosition.Y - 31);
            return mousePos;
        }

        public Rectangle drawRect()
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Red);
            Point mousePos = new Point(MousePosition.X - 105, MousePosition.Y - 31);

            if (btn_DecisionMade.Visible == true)
            {

            }
            else
            {

            }
            int changeRectangle = 0;
            int a = 10;
            int b = 10;
            int c = 100;
            int d = 100;
            Point labelPos = new Point(MousePosition.X - a, MousePosition.Y - 50);
            Point plantPos = new Point(MousePosition.X - a, MousePosition.Y - 7);
            Point minePos = new Point(MousePosition.X - a, MousePosition.Y - -17);
            Point farmPos = new Point(MousePosition.X - a, MousePosition.Y - -39);
            Rectangle rectangle1 = new Rectangle(a, b, c, d);

            for (int j = 0; j < 9; j++)
            {

                for (int i = 0; i < 16; i++)
                {
                    if (rectangle1.Contains(mousePos))
                    {
                        changeRectangle = 1;
                        lbl_choice.Visible = true;
                        btn_choicePlantation.Visible = true;
                        btn_choiceMine.Visible = true;
                        btn_choiceFarm.Visible = true;
                        btn_choiceCancel.Location = mousePos;
                        lbl_choice.Location = labelPos;
                        btn_choicePlantation.Location = plantPos;
                        btn_choiceMine.Location = minePos;
                        btn_choiceFarm.Location = farmPos;
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

            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.Dispose();
            g.DrawRectangle(mypen, a, b, c, d);


            a = 10;
            b = 10;

            pictureBox1.Image = DrawArea;

            return rectangle1;
        }
    }
}
    

    
