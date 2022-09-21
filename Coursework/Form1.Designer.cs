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
            this.mine1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.money1 = new System.Windows.Forms.Button();
            this.wood1 = new System.Windows.Forms.Button();
            this.help1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tile1
            // 
            this.tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tile1.Location = new System.Drawing.Point(97, 0);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(138, 126);
            this.tile1.TabIndex = 0;
            this.tile1.Text = "Lvl 1 Plantation: Free";
            this.tile1.UseVisualStyleBackColor = true;
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
            // mine1
            // 
            this.mine1.Location = new System.Drawing.Point(97, 125);
            this.mine1.Name = "mine1";
            this.mine1.Size = new System.Drawing.Size(138, 126);
            this.mine1.TabIndex = 3;
            this.mine1.Text = "Empty Tile";
            this.mine1.UseVisualStyleBackColor = true;
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(97, 199);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(141, 52);
            this.checkedListBox1.TabIndex = 8;
            // 
            // money1
            // 
            this.money1.Location = new System.Drawing.Point(0, 73);
            this.money1.Name = "money1";
            this.money1.Size = new System.Drawing.Size(98, 25);
            this.money1.TabIndex = 9;
            this.money1.Text = "Money: $0";
            this.money1.UseVisualStyleBackColor = true;
            // 
            // wood1
            // 
            this.wood1.BackColor = System.Drawing.Color.Sienna;
            this.wood1.Location = new System.Drawing.Point(0, 125);
            this.wood1.Name = "wood1";
            this.wood1.Size = new System.Drawing.Size(98, 25);
            this.wood1.TabIndex = 10;
            this.wood1.Text = "Wood: 0";
            this.wood1.UseVisualStyleBackColor = false;
            this.wood1.Click += new System.EventHandler(this.wood1_Click);
            // 
            // help1
            // 
            this.help1.AutoSize = true;
            this.help1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.help1.Location = new System.Drawing.Point(4, 98);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(95, 26);
            this.help1.TabIndex = 11;
            this.help1.Text = "Tap buttons below\r\n to cash in!";
            this.help1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1483, 749);
            this.Controls.Add(this.help1);
            this.Controls.Add(this.wood1);
            this.Controls.Add(this.money1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.mine1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.tile1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tile1;
        private System.Windows.Forms.Button exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button mine1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button money1;
        private System.Windows.Forms.Button wood1;
        private System.Windows.Forms.Label help1;
    }
}

