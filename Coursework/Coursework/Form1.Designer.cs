namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tile1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tile2 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.money1 = new System.Windows.Forms.Button();
            this.btn_WoodCount = new System.Windows.Forms.Button();
            this.help1 = new System.Windows.Forms.Label();
            this.btn_newTile = new System.Windows.Forms.Button();
            this.tile3 = new System.Windows.Forms.Button();
            this.tile4 = new System.Windows.Forms.Button();
            this.tile5 = new System.Windows.Forms.Button();
            this.lbl_Choice = new System.Windows.Forms.Label();
            this.btn_choicePlantation = new System.Windows.Forms.Button();
            this.btn_choiceMine = new System.Windows.Forms.Button();
            this.btn_choiceFarm = new System.Windows.Forms.Button();
            this.btn_choiceCancel = new System.Windows.Forms.Button();
            this.lbl_Upgrades = new System.Windows.Forms.Label();
            this.btn_Upgrades = new System.Windows.Forms.Button();
            this.btn_UpgradesCancel = new System.Windows.Forms.Button();
            this.tile6 = new System.Windows.Forms.Button();
            this.btn_OreCount = new System.Windows.Forms.Button();
            this.btn_FruitCount = new System.Windows.Forms.Button();
            this.pcb_nugget = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nugget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.SaddleBrown;
            this.tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tile1.Location = new System.Drawing.Point(114, 14);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(138, 126);
            this.tile1.TabIndex = 0;
            this.tile1.Text = "Lvl 1 Plantation: Free";
            this.tile1.UseVisualStyleBackColor = false;
            this.tile1.Click += new System.EventHandler(this.tile1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(0, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(98, 29);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit Program";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tile2
            // 
            this.tile2.Location = new System.Drawing.Point(114, 144);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(138, 126);
            this.tile2.TabIndex = 3;
            this.tile2.Text = "Empty Tile";
            this.tile2.UseVisualStyleBackColor = true;
            this.tile2.Visible = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(0, 27);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(98, 25);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(0, 50);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(98, 25);
            this.load.TabIndex = 6;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.button2_Click);
            // 
            // money1
            // 
            this.money1.Location = new System.Drawing.Point(0, 73);
            this.money1.Name = "money1";
            this.money1.Size = new System.Drawing.Size(98, 25);
            this.money1.TabIndex = 9;
            this.money1.Text = "Money: $25";
            this.money1.UseVisualStyleBackColor = true;
            // 
            // btn_WoodCount
            // 
            this.btn_WoodCount.BackColor = System.Drawing.Color.Sienna;
            this.btn_WoodCount.Location = new System.Drawing.Point(0, 172);
            this.btn_WoodCount.Name = "btn_WoodCount";
            this.btn_WoodCount.Size = new System.Drawing.Size(98, 25);
            this.btn_WoodCount.TabIndex = 10;
            this.btn_WoodCount.Text = "Wood: 0";
            this.btn_WoodCount.UseVisualStyleBackColor = false;
            this.btn_WoodCount.Click += new System.EventHandler(this.wood1_Click);
            // 
            // help1
            // 
            this.help1.AutoSize = true;
            this.help1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.help1.Location = new System.Drawing.Point(4, 145);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(95, 26);
            this.help1.TabIndex = 11;
            this.help1.Text = "Tap buttons below\r\n to cash in!";
            this.help1.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_newTile
            // 
            this.btn_newTile.Location = new System.Drawing.Point(0, 95);
            this.btn_newTile.Name = "btn_newTile";
            this.btn_newTile.Size = new System.Drawing.Size(98, 25);
            this.btn_newTile.TabIndex = 13;
            this.btn_newTile.Text = "New Tile";
            this.btn_newTile.UseVisualStyleBackColor = true;
            this.btn_newTile.Click += new System.EventHandler(this.btn_newTile_Click);
            // 
            // tile3
            // 
            this.tile3.Location = new System.Drawing.Point(114, 276);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(138, 126);
            this.tile3.TabIndex = 14;
            this.tile3.Text = "Empty Tile";
            this.tile3.UseVisualStyleBackColor = true;
            this.tile3.Visible = false;
            // 
            // tile4
            // 
            this.tile4.Location = new System.Drawing.Point(114, 408);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(138, 126);
            this.tile4.TabIndex = 15;
            this.tile4.Text = "Empty Tile";
            this.tile4.UseVisualStyleBackColor = true;
            this.tile4.Visible = false;
            // 
            // tile5
            // 
            this.tile5.Location = new System.Drawing.Point(114, 540);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(138, 126);
            this.tile5.TabIndex = 16;
            this.tile5.Text = "Empty Tile";
            this.tile5.UseVisualStyleBackColor = true;
            this.tile5.Visible = false;
            // 
            // lbl_Choice
            // 
            this.lbl_Choice.AutoSize = true;
            this.lbl_Choice.Location = new System.Drawing.Point(664, 91);
            this.lbl_Choice.Name = "lbl_Choice";
            this.lbl_Choice.Size = new System.Drawing.Size(107, 16);
            this.lbl_Choice.TabIndex = 18;
            this.lbl_Choice.Text = "Select Tile Type";
            this.lbl_Choice.Visible = false;
            // 
            // btn_choicePlantation
            // 
            this.btn_choicePlantation.Location = new System.Drawing.Point(667, 143);
            this.btn_choicePlantation.Name = "btn_choicePlantation";
            this.btn_choicePlantation.Size = new System.Drawing.Size(104, 30);
            this.btn_choicePlantation.TabIndex = 19;
            this.btn_choicePlantation.Text = "Plantation";
            this.btn_choicePlantation.UseVisualStyleBackColor = true;
            this.btn_choicePlantation.Visible = false;
            this.btn_choicePlantation.Click += new System.EventHandler(this.btn_tileChoicePlantation_Click);
            // 
            // btn_choiceMine
            // 
            this.btn_choiceMine.Location = new System.Drawing.Point(667, 179);
            this.btn_choiceMine.Name = "btn_choiceMine";
            this.btn_choiceMine.Size = new System.Drawing.Size(104, 30);
            this.btn_choiceMine.TabIndex = 20;
            this.btn_choiceMine.Text = "Mine";
            this.btn_choiceMine.UseVisualStyleBackColor = true;
            this.btn_choiceMine.Visible = false;
            this.btn_choiceMine.Click += new System.EventHandler(this.btn_tileChoiceMine_Click);
            // 
            // btn_choiceFarm
            // 
            this.btn_choiceFarm.Location = new System.Drawing.Point(667, 215);
            this.btn_choiceFarm.Name = "btn_choiceFarm";
            this.btn_choiceFarm.Size = new System.Drawing.Size(104, 30);
            this.btn_choiceFarm.TabIndex = 21;
            this.btn_choiceFarm.Text = "Farm";
            this.btn_choiceFarm.UseVisualStyleBackColor = true;
            this.btn_choiceFarm.Visible = false;
            this.btn_choiceFarm.Click += new System.EventHandler(this.btn_tileChoiceFarm_Click);
            // 
            // btn_choiceCancel
            // 
            this.btn_choiceCancel.BackColor = System.Drawing.Color.Red;
            this.btn_choiceCancel.ForeColor = System.Drawing.Color.White;
            this.btn_choiceCancel.Location = new System.Drawing.Point(667, 110);
            this.btn_choiceCancel.Name = "btn_choiceCancel";
            this.btn_choiceCancel.Size = new System.Drawing.Size(104, 30);
            this.btn_choiceCancel.TabIndex = 22;
            this.btn_choiceCancel.Text = "Cancel";
            this.btn_choiceCancel.UseVisualStyleBackColor = false;
            this.btn_choiceCancel.Visible = false;
            this.btn_choiceCancel.Click += new System.EventHandler(this.btn_choiceCancel_Click);
            // 
            // lbl_Upgrades
            // 
            this.lbl_Upgrades.AutoSize = true;
            this.lbl_Upgrades.Location = new System.Drawing.Point(828, 91);
            this.lbl_Upgrades.Name = "lbl_Upgrades";
            this.lbl_Upgrades.Size = new System.Drawing.Size(69, 16);
            this.lbl_Upgrades.TabIndex = 23;
            this.lbl_Upgrades.Text = "Upgrades";
            this.lbl_Upgrades.Visible = false;
            // 
            // btn_Upgrades
            // 
            this.btn_Upgrades.Location = new System.Drawing.Point(0, 118);
            this.btn_Upgrades.Name = "btn_Upgrades";
            this.btn_Upgrades.Size = new System.Drawing.Size(98, 24);
            this.btn_Upgrades.TabIndex = 24;
            this.btn_Upgrades.Text = "Upgrades";
            this.btn_Upgrades.UseVisualStyleBackColor = true;
            this.btn_Upgrades.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_UpgradesCancel
            // 
            this.btn_UpgradesCancel.BackColor = System.Drawing.Color.Red;
            this.btn_UpgradesCancel.ForeColor = System.Drawing.Color.White;
            this.btn_UpgradesCancel.Location = new System.Drawing.Point(810, 110);
            this.btn_UpgradesCancel.Name = "btn_UpgradesCancel";
            this.btn_UpgradesCancel.Size = new System.Drawing.Size(104, 30);
            this.btn_UpgradesCancel.TabIndex = 25;
            this.btn_UpgradesCancel.Text = "Cancel";
            this.btn_UpgradesCancel.UseVisualStyleBackColor = false;
            this.btn_UpgradesCancel.Visible = false;
            this.btn_UpgradesCancel.Click += new System.EventHandler(this.btn_UpgradesCancel_Click);
            // 
            // tile6
            // 
            this.tile6.Location = new System.Drawing.Point(114, 672);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(138, 126);
            this.tile6.TabIndex = 26;
            this.tile6.Text = "Empty Tile";
            this.tile6.UseVisualStyleBackColor = true;
            this.tile6.Visible = false;
            // 
            // btn_OreCount
            // 
            this.btn_OreCount.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_OreCount.Location = new System.Drawing.Point(0, 196);
            this.btn_OreCount.Name = "btn_OreCount";
            this.btn_OreCount.Size = new System.Drawing.Size(98, 25);
            this.btn_OreCount.TabIndex = 27;
            this.btn_OreCount.Text = "Ore: 0";
            this.btn_OreCount.UseVisualStyleBackColor = false;
            // 
            // btn_FruitCount
            // 
            this.btn_FruitCount.BackColor = System.Drawing.Color.Coral;
            this.btn_FruitCount.Location = new System.Drawing.Point(0, 220);
            this.btn_FruitCount.Name = "btn_FruitCount";
            this.btn_FruitCount.Size = new System.Drawing.Size(98, 25);
            this.btn_FruitCount.TabIndex = 28;
            this.btn_FruitCount.Text = "Fruit: 0";
            this.btn_FruitCount.UseVisualStyleBackColor = false;
            // 
            // pcb_nugget
            // 
            this.pcb_nugget.Image = global::Coursework.Properties.Resources.spinning_chicken;
            this.pcb_nugget.Location = new System.Drawing.Point(1236, 91);
            this.pcb_nugget.Name = "pcb_nugget";
            this.pcb_nugget.Size = new System.Drawing.Size(429, 517);
            this.pcb_nugget.TabIndex = 29;
            this.pcb_nugget.TabStop = false;
            this.pcb_nugget.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Coursework.Properties.Resources.grass;
            this.pictureBox1.Location = new System.Drawing.Point(104, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1808, 1004);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcb_nugget);
            this.Controls.Add(this.btn_FruitCount);
            this.Controls.Add(this.btn_OreCount);
            this.Controls.Add(this.tile6);
            this.Controls.Add(this.btn_UpgradesCancel);
            this.Controls.Add(this.btn_Upgrades);
            this.Controls.Add(this.lbl_Upgrades);
            this.Controls.Add(this.btn_choiceCancel);
            this.Controls.Add(this.btn_choiceFarm);
            this.Controls.Add(this.btn_choiceMine);
            this.Controls.Add(this.btn_choicePlantation);
            this.Controls.Add(this.lbl_Choice);
            this.Controls.Add(this.tile5);
            this.Controls.Add(this.tile4);
            this.Controls.Add(this.tile3);
            this.Controls.Add(this.btn_newTile);
            this.Controls.Add(this.tile2);
            this.Controls.Add(this.tile1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help1);
            this.Controls.Add(this.btn_WoodCount);
            this.Controls.Add(this.money1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nugget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tile1;
        private System.Windows.Forms.Button exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button tile2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button money1;
        private System.Windows.Forms.Button btn_WoodCount;
        private System.Windows.Forms.Label help1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newTile;
        private System.Windows.Forms.Button tile3;
        private System.Windows.Forms.Button tile4;
        private System.Windows.Forms.Button tile5;
        private System.Windows.Forms.Label lbl_Choice;
        private System.Windows.Forms.Button btn_choicePlantation;
        private System.Windows.Forms.Button btn_choiceMine;
        private System.Windows.Forms.Button btn_choiceFarm;
        private System.Windows.Forms.Button btn_choiceCancel;
        private System.Windows.Forms.Label lbl_Upgrades;
        private System.Windows.Forms.Button btn_Upgrades;
        private System.Windows.Forms.Button btn_UpgradesCancel;
        private System.Windows.Forms.Button tile6;
        private System.Windows.Forms.Button btn_OreCount;
        private System.Windows.Forms.Button btn_FruitCount;
        private System.Windows.Forms.PictureBox pcb_nugget;
        private System.Windows.Forms.Button button1;
    }
}

