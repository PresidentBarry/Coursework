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
            this.a1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.money1 = new System.Windows.Forms.Button();
            this.btn_logCount = new System.Windows.Forms.Button();
            this.lbl_help1 = new System.Windows.Forms.Label();
            this.btn_newTile = new System.Windows.Forms.Button();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.btn_choicePlantation = new System.Windows.Forms.Button();
            this.btn_choiceMine = new System.Windows.Forms.Button();
            this.btn_choiceFarm = new System.Windows.Forms.Button();
            this.btn_choiceCancel = new System.Windows.Forms.Button();
            this.lbl_upgrades = new System.Windows.Forms.Label();
            this.btn_Upgrades = new System.Windows.Forms.Button();
            this.btn_UpgradesCancel = new System.Windows.Forms.Button();
            this.btn_oreCount = new System.Windows.Forms.Button();
            this.btn_cropCount = new System.Windows.Forms.Button();
            this.lbl_exitConfirm = new System.Windows.Forms.Label();
            this.btn_exitYes = new System.Windows.Forms.Button();
            this.btn_exitNo = new System.Windows.Forms.Button();
            this.lbl_upgradesTile = new System.Windows.Forms.Label();
            this.btn_woodUpg1 = new System.Windows.Forms.Button();
            this.btn_DecisionMade = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sellTile = new System.Windows.Forms.Button();
            this.btn_lumberCount = new System.Windows.Forms.Button();
            this.btn_flourChoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.SaddleBrown;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.a1.Location = new System.Drawing.Point(114, 14);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(138, 126);
            this.a1.TabIndex = 0;
            this.a1.Tag = "tile";
            this.a1.Text = "Lvl 1 Plantation: $5";
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Visible = false;
            this.a1.Click += new System.EventHandler(this.tile1_Click);
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
            this.exit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exit_KeyPress);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            this.money1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.money1.Location = new System.Drawing.Point(0, 73);
            this.money1.Name = "money1";
            this.money1.Size = new System.Drawing.Size(98, 25);
            this.money1.TabIndex = 9;
            this.money1.Text = "Money: $50";
            this.money1.UseVisualStyleBackColor = true;
            // 
            // btn_logCount
            // 
            this.btn_logCount.BackColor = System.Drawing.Color.Sienna;
            this.btn_logCount.Location = new System.Drawing.Point(0, 192);
            this.btn_logCount.Name = "btn_logCount";
            this.btn_logCount.Size = new System.Drawing.Size(98, 25);
            this.btn_logCount.TabIndex = 10;
            this.btn_logCount.Text = "Logs: 0";
            this.btn_logCount.UseVisualStyleBackColor = false;
            this.btn_logCount.Click += new System.EventHandler(this.wood1_Click);
            // 
            // lbl_help1
            // 
            this.lbl_help1.AutoSize = true;
            this.lbl_help1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_help1.Location = new System.Drawing.Point(4, 165);
            this.lbl_help1.Name = "lbl_help1";
            this.lbl_help1.Size = new System.Drawing.Size(95, 26);
            this.lbl_help1.TabIndex = 11;
            this.lbl_help1.Text = "Tap buttons below\r\n to cash in!";
            this.lbl_help1.Click += new System.EventHandler(this.label2_Click);
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
            // lbl_choice
            // 
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Location = new System.Drawing.Point(664, 91);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(107, 16);
            this.lbl_choice.TabIndex = 18;
            this.lbl_choice.Text = "Select Tile Type";
            this.lbl_choice.Visible = false;
            // 
            // btn_choicePlantation
            // 
            this.btn_choicePlantation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btn_choicePlantation.Location = new System.Drawing.Point(694, 134);
            this.btn_choicePlantation.Name = "btn_choicePlantation";
            this.btn_choicePlantation.Size = new System.Drawing.Size(54, 22);
            this.btn_choicePlantation.TabIndex = 19;
            this.btn_choicePlantation.Text = "Plantation";
            this.btn_choicePlantation.UseVisualStyleBackColor = true;
            this.btn_choicePlantation.Visible = false;
            this.btn_choicePlantation.Click += new System.EventHandler(this.btn_tileChoicePlantation_Click);
            // 
            // btn_choiceMine
            // 
            this.btn_choiceMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btn_choiceMine.Location = new System.Drawing.Point(700, 158);
            this.btn_choiceMine.Name = "btn_choiceMine";
            this.btn_choiceMine.Size = new System.Drawing.Size(39, 20);
            this.btn_choiceMine.TabIndex = 20;
            this.btn_choiceMine.Text = "Mine";
            this.btn_choiceMine.UseVisualStyleBackColor = true;
            this.btn_choiceMine.Visible = false;
            this.btn_choiceMine.Click += new System.EventHandler(this.btn_tileChoiceMine_Click);
            // 
            // btn_choiceFarm
            // 
            this.btn_choiceFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btn_choiceFarm.Location = new System.Drawing.Point(700, 180);
            this.btn_choiceFarm.Name = "btn_choiceFarm";
            this.btn_choiceFarm.Size = new System.Drawing.Size(39, 21);
            this.btn_choiceFarm.TabIndex = 21;
            this.btn_choiceFarm.Text = "Farm";
            this.btn_choiceFarm.UseVisualStyleBackColor = true;
            this.btn_choiceFarm.Visible = false;
            this.btn_choiceFarm.Click += new System.EventHandler(this.btn_tileChoiceFarm_Click);
            // 
            // btn_choiceCancel
            // 
            this.btn_choiceCancel.BackColor = System.Drawing.Color.Red;
            this.btn_choiceCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.btn_choiceCancel.ForeColor = System.Drawing.Color.White;
            this.btn_choiceCancel.Location = new System.Drawing.Point(664, 110);
            this.btn_choiceCancel.Name = "btn_choiceCancel";
            this.btn_choiceCancel.Size = new System.Drawing.Size(47, 23);
            this.btn_choiceCancel.TabIndex = 22;
            this.btn_choiceCancel.Text = "Cancel";
            this.btn_choiceCancel.UseVisualStyleBackColor = false;
            this.btn_choiceCancel.Visible = false;
            this.btn_choiceCancel.Click += new System.EventHandler(this.btn_choiceCancel_Click);
            // 
            // lbl_upgrades
            // 
            this.lbl_upgrades.AutoSize = true;
            this.lbl_upgrades.Location = new System.Drawing.Point(828, 91);
            this.lbl_upgrades.Name = "lbl_upgrades";
            this.lbl_upgrades.Size = new System.Drawing.Size(69, 16);
            this.lbl_upgrades.TabIndex = 23;
            this.lbl_upgrades.Text = "Upgrades";
            this.lbl_upgrades.Visible = false;
            // 
            // btn_Upgrades
            // 
            this.btn_Upgrades.Location = new System.Drawing.Point(0, 140);
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
            // btn_oreCount
            // 
            this.btn_oreCount.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_oreCount.Location = new System.Drawing.Point(0, 216);
            this.btn_oreCount.Name = "btn_oreCount";
            this.btn_oreCount.Size = new System.Drawing.Size(98, 25);
            this.btn_oreCount.TabIndex = 27;
            this.btn_oreCount.Text = "Ore: 0";
            this.btn_oreCount.UseVisualStyleBackColor = false;
            // 
            // btn_cropCount
            // 
            this.btn_cropCount.BackColor = System.Drawing.Color.Coral;
            this.btn_cropCount.Location = new System.Drawing.Point(0, 240);
            this.btn_cropCount.Name = "btn_cropCount";
            this.btn_cropCount.Size = new System.Drawing.Size(98, 25);
            this.btn_cropCount.TabIndex = 28;
            this.btn_cropCount.Text = "Crops: 0";
            this.btn_cropCount.UseVisualStyleBackColor = false;
            // 
            // lbl_exitConfirm
            // 
            this.lbl_exitConfirm.AutoSize = true;
            this.lbl_exitConfirm.Location = new System.Drawing.Point(441, 91);
            this.lbl_exitConfirm.Name = "lbl_exitConfirm";
            this.lbl_exitConfirm.Size = new System.Drawing.Size(202, 32);
            this.lbl_exitConfirm.TabIndex = 29;
            this.lbl_exitConfirm.Text = "Are you sure you want to exit? \r\nAll unsaved progress will be lost.";
            this.lbl_exitConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_exitConfirm.Visible = false;
            // 
            // btn_exitYes
            // 
            this.btn_exitYes.Location = new System.Drawing.Point(444, 135);
            this.btn_exitYes.Name = "btn_exitYes";
            this.btn_exitYes.Size = new System.Drawing.Size(89, 30);
            this.btn_exitYes.TabIndex = 30;
            this.btn_exitYes.Text = "Exit";
            this.btn_exitYes.UseVisualStyleBackColor = true;
            this.btn_exitYes.Visible = false;
            this.btn_exitYes.Click += new System.EventHandler(this.btn_exitYes_Click);
            // 
            // btn_exitNo
            // 
            this.btn_exitNo.Location = new System.Drawing.Point(554, 135);
            this.btn_exitNo.Name = "btn_exitNo";
            this.btn_exitNo.Size = new System.Drawing.Size(89, 30);
            this.btn_exitNo.TabIndex = 31;
            this.btn_exitNo.Text = "Cancel";
            this.btn_exitNo.UseVisualStyleBackColor = true;
            this.btn_exitNo.Visible = false;
            this.btn_exitNo.Click += new System.EventHandler(this.btn_exitNo_Click);
            // 
            // lbl_upgradesTile
            // 
            this.lbl_upgradesTile.AutoSize = true;
            this.lbl_upgradesTile.Location = new System.Drawing.Point(786, 145);
            this.lbl_upgradesTile.Name = "lbl_upgradesTile";
            this.lbl_upgradesTile.Size = new System.Drawing.Size(161, 16);
            this.lbl_upgradesTile.TabIndex = 32;
            this.lbl_upgradesTile.Text = "Select tile to be upgraded";
            this.lbl_upgradesTile.Visible = false;
            this.lbl_upgradesTile.Click += new System.EventHandler(this.lbl_upgradesTile_Click);
            // 
            // btn_woodUpg1
            // 
            this.btn_woodUpg1.Location = new System.Drawing.Point(798, 164);
            this.btn_woodUpg1.Name = "btn_woodUpg1";
            this.btn_woodUpg1.Size = new System.Drawing.Size(137, 30);
            this.btn_woodUpg1.TabIndex = 33;
            this.btn_woodUpg1.UseVisualStyleBackColor = true;
            this.btn_woodUpg1.Visible = false;
            // 
            // btn_DecisionMade
            // 
            this.btn_DecisionMade.Location = new System.Drawing.Point(361, 154);
            this.btn_DecisionMade.Name = "btn_DecisionMade";
            this.btn_DecisionMade.Size = new System.Drawing.Size(16, 16);
            this.btn_DecisionMade.TabIndex = 34;
            this.btn_DecisionMade.Text = "Text";
            this.btn_DecisionMade.UseVisualStyleBackColor = true;
            this.btn_DecisionMade.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Coursework.Properties.Resources.grass;
            this.pictureBox1.Location = new System.Drawing.Point(104, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1808, 1003);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_sellTile
            // 
            this.btn_sellTile.Location = new System.Drawing.Point(0, 118);
            this.btn_sellTile.Name = "btn_sellTile";
            this.btn_sellTile.Size = new System.Drawing.Size(98, 24);
            this.btn_sellTile.TabIndex = 35;
            this.btn_sellTile.Text = "Sell Tile";
            this.btn_sellTile.UseVisualStyleBackColor = true;
            this.btn_sellTile.Click += new System.EventHandler(this.btn_sellTile_Click);
            // 
            // btn_lumberCount
            // 
            this.btn_lumberCount.BackColor = System.Drawing.Color.Chocolate;
            this.btn_lumberCount.Location = new System.Drawing.Point(0, 264);
            this.btn_lumberCount.Name = "btn_lumberCount";
            this.btn_lumberCount.Size = new System.Drawing.Size(98, 25);
            this.btn_lumberCount.TabIndex = 36;
            this.btn_lumberCount.Text = "Lumber: 0";
            this.btn_lumberCount.UseVisualStyleBackColor = false;
            // 
            // btn_flourChoice
            // 
            this.btn_flourChoice.BackColor = System.Drawing.Color.Coral;
            this.btn_flourChoice.Location = new System.Drawing.Point(0, 289);
            this.btn_flourChoice.Name = "btn_flourChoice";
            this.btn_flourChoice.Size = new System.Drawing.Size(98, 25);
            this.btn_flourChoice.TabIndex = 37;
            this.btn_flourChoice.Text = "Flour: 0";
            this.btn_flourChoice.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btn_flourChoice);
            this.Controls.Add(this.btn_lumberCount);
            this.Controls.Add(this.btn_sellTile);
            this.Controls.Add(this.btn_woodUpg1);
            this.Controls.Add(this.lbl_upgradesTile);
            this.Controls.Add(this.btn_exitNo);
            this.Controls.Add(this.btn_exitYes);
            this.Controls.Add(this.lbl_exitConfirm);
            this.Controls.Add(this.btn_cropCount);
            this.Controls.Add(this.btn_oreCount);
            this.Controls.Add(this.btn_UpgradesCancel);
            this.Controls.Add(this.btn_Upgrades);
            this.Controls.Add(this.lbl_upgrades);
            this.Controls.Add(this.btn_choiceCancel);
            this.Controls.Add(this.btn_choiceFarm);
            this.Controls.Add(this.btn_choiceMine);
            this.Controls.Add(this.btn_choicePlantation);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.btn_newTile);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_help1);
            this.Controls.Add(this.btn_logCount);
            this.Controls.Add(this.money1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btn_DecisionMade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button money1;
        private System.Windows.Forms.Button btn_logCount;
        private System.Windows.Forms.Label lbl_help1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newTile;
        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Button btn_choicePlantation;
        private System.Windows.Forms.Button btn_choiceMine;
        private System.Windows.Forms.Button btn_choiceFarm;
        private System.Windows.Forms.Button btn_choiceCancel;
        private System.Windows.Forms.Label lbl_upgrades;
        private System.Windows.Forms.Button btn_Upgrades;
        private System.Windows.Forms.Button btn_UpgradesCancel;
        private System.Windows.Forms.Button btn_oreCount;
        private System.Windows.Forms.Button btn_cropCount;
        private System.Windows.Forms.Label lbl_exitConfirm;
        private System.Windows.Forms.Button btn_exitYes;
        private System.Windows.Forms.Button btn_exitNo;
        private System.Windows.Forms.Label lbl_upgradesTile;
        private System.Windows.Forms.Button btn_woodUpg1;
        private System.Windows.Forms.Button btn_DecisionMade;
        private System.Windows.Forms.Button btn_sellTile;
        private System.Windows.Forms.Button btn_lumberCount;
        private System.Windows.Forms.Button btn_flourChoice;
    }
}

