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
        int woodLvlUp = 25;
        double woodLvl = 0;
        double woodMult = 0;

        //Mine variables
        double ore = 0;
        int oreLvlUp = 85;

        //Farm variables
        double fruit = 0;
        int fruitLvlUp = 55;

        bool tilesMade = false;

        int tileCount = 0;
        Dictionary<int, string> tileType = new Dictionary<int, string>();
        Dictionary<int, Rectangle> tilePos = new Dictionary<int, Rectangle>();
        int soldTileKey;
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
                money1.Text = "Money: $" + money;


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
            //Graphics g;
            //g = Graphics.FromImage(DrawArea);

            //Pen mypen = new Pen(Color.Black);

            //int a = 10;
            //int b = 10;
            //int c = 100;
            //int d = 100;

            //for (int j = 0; j < 9; j++)
            //{

            //    for (int i = 0; i < 16; i++)
            //    {
            //        g.DrawRectangle(mypen, a, b, c, d);

            //        a = a + 110;
            //    }
            //    a = 10;
            //    b = b + 110;
            //}

            //a = 10;
            //b = 10;

            //pictureBox1.Image = DrawArea;

            if (tilesMade == false)
            {
                CreateTiles();
                tilesMade = true;
            }

            btn_choiceCancel.Visible = true;
            btn_choiceCancel.BringToFront();
        }

        public int Count()
        {
            int count = 0;
            return count;
        }

        private void btn_tileChoicePlantation_Click(object sender, EventArgs e)
        {
            //btn_DecisionMade.Visible = true;
            //tileType.Add(tileCount, "Plantation");
            //Graphics g;
            //g = Graphics.FromImage(DrawArea);

            //Pen mypen = new Pen(Color.Red);

            //Rectangle rectangle = drawRect();
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.SaddleBrown);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //g.FillRectangle(myBrush, rectangle);
            //myBrush.Dispose();
            //formGraphics.Dispose();
            //g.DrawRectangle(mypen, rectangle);

            //PictureBox pb_tile = new PictureBox();

            //pb_tile.SizeMode = PictureBoxSizeMode.AutoSize;
            //pb_tile.Image = Properties.Resources.Plantation;
            //pb_tile.Location = new Point((rectangle.Right + 5), (rectangle.Top + 9));
            //tilePos.Add(tileCount, rectangle);

            //this.Controls.Add(pb_tile);
            //pb_tile.BringToFront();
            if (money >= woodLvlUp)
            {
                money = money - woodLvlUp;
                woodLvlUp = (int)(woodLvlUp * 1.2);
            }

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
            //tileType.Add(tileCount, "Mine");
            //Graphics g;
            //g = Graphics.FromImage(DrawArea);

            //Pen mypen = new Pen(Color.Red);

            //Rectangle rectangle = drawRect();
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.MediumPurple);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //g.FillRectangle(myBrush, rectangle);
            //myBrush.Dispose();
            //formGraphics.Dispose();
            //g.DrawRectangle(mypen, rectangle);

            //PictureBox pb_tile = new PictureBox();

            //pb_tile.SizeMode = PictureBoxSizeMode.AutoSize;
            //pb_tile.Image = Properties.Resources.Mine;
            //pb_tile.Location = new Point((rectangle.Right + 5), (rectangle.Top + 9));
            //tilePos.Add(tileCount, rectangle);

            //this.Controls.Add(pb_tile);
            //pb_tile.BringToFront();
            if (money >= oreLvlUp)
            {
                money = money - oreLvlUp;
                oreLvlUp = (int)(oreLvlUp * 1.2);
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
            btn_DecisionMade.Visible = true;
            //tileType.Add(tileCount, "Farm");
            //Graphics g;
            //g = Graphics.FromImage(DrawArea);

            //Pen mypen = new Pen(Color.Red);

            //Rectangle rectangle = drawRect();
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //g.FillRectangle(myBrush, rectangle);
            //myBrush.Dispose();
            //formGraphics.Dispose();
            //g.DrawRectangle(mypen, rectangle);

            //PictureBox pb_tile = new PictureBox();

            //pb_tile.SizeMode = PictureBoxSizeMode.AutoSize;
            //pb_tile.Image = Properties.Resources.Farm;
            //pb_tile.Location = new Point((rectangle.Right + 5), (rectangle.Top + 9));
            //tilePos.Add(tileCount, rectangle);

            //this.Controls.Add(pb_tile);
            //pb_tile.BringToFront();
            if (money >= fruitLvlUp)
            {
                money = money - fruitLvlUp;
                fruitLvlUp = (int)(fruitLvlUp * 1.2);
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
            lbl_choice.Visible = false;
            btn_choiceCancel.Visible = false;
            btn_choicePlantation.Visible = false;
            btn_choiceMine.Visible = false;
            btn_choiceFarm.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_upgrades.Visible = true;
            btn_upgradesCancel.Visible = true;
            lbl_upgradesTile.Visible = true;
        }

        private void btn_UpgradesCancel_Click(object sender, EventArgs e)
        {
            lbl_upgrades.Visible = false;
            btn_upgradesCancel.Visible = false;
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
                //Point userClick = new Point(0, 0);
                //if ((btn_choiceCancel.Visible == true) && (lbl_choice.Visible == false))
                //{
                //    userClick = verifyRect();
                //}
                //if (btn_choiceCancel.Visible == true)
                //{
                //    Rectangle drawTile = new Rectangle(0, 0, 0, 0);
                //    drawTile = drawRect();
                //    if (!drawTile.Contains(userClick))
                //    {

                //    }

                //}
        }

        public Point verifyRect()
        {
            Point mousePos = new Point(MousePosition.X - 105, MousePosition.Y - 31);
            return mousePos;
        }

        //public Rectangle drawRect()
        //{
        //    Graphics g;
        //    g = Graphics.FromImage(DrawArea);

        //    Pen mypen = new Pen(Color.Red);
        //    Point mousePos = new Point(MousePosition.X - 105, MousePosition.Y - 31);

        //    if (btn_DecisionMade.Visible == true)
        //    {

        //    }
        //    else
        //    {

        //    }
        //    int changeRectangle = 0;
        //    int a = 10;
        //    int b = 10;
        //    int c = 100;
        //    int d = 100;
        //    Point labelPos = new Point(MousePosition.X - a, MousePosition.Y - 50);
        //    Point plantPos = new Point(MousePosition.X - a, MousePosition.Y - 7);
        //    Point minePos = new Point(MousePosition.X - a, MousePosition.Y - -17);
        //    Point farmPos = new Point(MousePosition.X - a, MousePosition.Y - -39);
        //    Rectangle rectangle1 = new Rectangle(a, b, c, d);

        //    for (int j = 0; j < 9; j++)
        //    {

        //        for (int i = 0; i < 16; i++)
        //        {
        //            if (rectangle1.Contains(mousePos))
        //            {
        //                changeRectangle = 1;
        //                lbl_choice.Visible = true;
        //                btn_choicePlantation.Visible = true;
        //                btn_choiceMine.Visible = true;
        //                btn_choiceFarm.Visible = true;
        //                btn_choiceCancel.Location = mousePos;
        //                lbl_choice.Location = labelPos;
        //                btn_choicePlantation.Location = plantPos;
        //                btn_choiceMine.Location = minePos;
        //                btn_choiceFarm.Location = farmPos;
        //            }
        //            else
        //            {
        //                a = a + 110;
        //                rectangle1 = new Rectangle(a, b, c, d);
        //            }
        //        }
        //        if (changeRectangle == 0)
        //        {
        //            a = 10;
        //            b = b + 110;
        //            rectangle1 = new Rectangle(a, b, c, d);
        //        }
        //    }

        //    System.Drawing.Graphics formGraphics;
        //    formGraphics = this.CreateGraphics();
        //    formGraphics.Dispose();
        //    g.DrawRectangle(mypen, a, b, c, d);


        //    a = 10;
        //    b = 10;

        //    pictureBox1.Image = DrawArea;

            

        //    return rectangle1;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_sellTile_Click(object sender, EventArgs e)
        {
            lbl_sell.Visible = true;
            btn_sellCancel.Visible = true;

            //Point mousePos = new Point(MousePosition.X - 105, MousePosition.Y - 31);
            //int a = 10;
            //int b = 10;
            //int c = 100;
            //int d = 100;
            //Rectangle rectangle1 = new Rectangle(a, b, c, d);
            //int changeRectangle = 0;

            //for (int j = 0; j < 9; j++)
            //{

            //    for (int i = 0; i < 16; i++)
            //    {
            //        if (rectangle1.Contains(mousePos))
            //        {
            //            changeRectangle = 1;
            //            lbl_sell.Visible = true;
            //            btn_sellCancel.Visible = true;
            //            btn_sellCancel.Location = mousePos;
            //        }
            //        else
            //        {
            //            a = a + 110;
            //            rectangle1 = new Rectangle(a, b, c, d);
            //        }
            //    }
            //    if (changeRectangle == 0)
            //    {
            //        a = 10;
            //        b = b + 110;
            //        rectangle1 = new Rectangle(a, b, c, d);
            //    }
            //}

            //lbl_sell.Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //if (btn_sellCancel.Visible == true)
            //{
            //    foreach (Rectangle item in tilePos.Values)
            //    {
            //        if (item.Contains(MousePosition))
            //        {
            //            btn_sellCancel.Visible = false;
            //        }
            //    }
            //}
        }

        public Dictionary<int, string> updateTilePlant()
        {
            tileType.Add(tileCount, "Plantation");
            return tileType;
        }

        private void btn_sellCancel_Click(object sender, EventArgs e)
        {
        }

        private void btn_sellCancel_Click_1(object sender, EventArgs e)
        {
            btn_sellCancel.Visible = false;
            lbl_sell.Visible = false;
        }

        private void CreateTiles()
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 16; j++)
                {
                    Control tile = new Control();
                    tile.Name = $"Tile_{i}_{j}";
                    tile.Width = 100;
                    tile.Height = 100;
                    tile.Left = (j * 120);
                    tile.Top = (i * 122) - 85;
                    tile.BackColor = Color.White;
                    tile.Click += Tile_Click;
                    this.Controls.Add(tile);
                    tile.BringToFront();
                }
            }
        }
        private void Tile_Click(object sender, EventArgs e)
        {
            Control tile = (Control)sender;

            if (btn_sellCancel.Visible == true)
            {
                tile.BackColor = Color.Red;
            }
            else if (btn_choiceCancel.Visible == true)
            {
                lbl_choice.Visible = true;
                btn_choicePlantation.Visible = true;
                btn_choiceMine.Visible = true;
                btn_choiceFarm.Visible = true;
                lbl_choice.BringToFront();
                btn_choicePlantation.BringToFront();
                btn_choiceMine.BringToFront();
                btn_choiceFarm.BringToFront();
                tile.BackColor = Color.Blue;
            }
        }
    }
}
    

    
