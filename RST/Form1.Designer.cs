
namespace RST
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbplayer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pbhover = new System.Windows.Forms.PictureBox();
            this._lblscore = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.pbexplosion = new System.Windows.Forms.PictureBox();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.pbshield = new System.Windows.Forms.PictureBox();
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.pblives3 = new System.Windows.Forms.PictureBox();
            this.pblives2 = new System.Windows.Forms.PictureBox();
            this.pblives1 = new System.Windows.Forms.PictureBox();
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbexplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblives3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblives2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblives1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbplayer
            // 
            this.pbplayer.BackColor = System.Drawing.Color.Transparent;
            this.pbplayer.Image = global::RST.Properties.Resources.car20_removebg_preview1;
            this.pbplayer.Location = new System.Drawing.Point(86, 382);
            this.pbplayer.Name = "pbplayer";
            this.pbplayer.Size = new System.Drawing.Size(119, 46);
            this.pbplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbplayer.TabIndex = 0;
            this.pbplayer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pbhover
            // 
            this.pbhover.BackColor = System.Drawing.Color.Transparent;
            this.pbhover.Image = global::RST.Properties.Resources.hover_removebg_preview;
            this.pbhover.Location = new System.Drawing.Point(91, 439);
            this.pbhover.Name = "pbhover";
            this.pbhover.Size = new System.Drawing.Size(106, 19);
            this.pbhover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbhover.TabIndex = 1;
            this.pbhover.TabStop = false;
            // 
            // _lblscore
            // 
            this._lblscore.AutoSize = true;
            this._lblscore.BackColor = System.Drawing.Color.Transparent;
            this._lblscore.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblscore.ForeColor = System.Drawing.Color.White;
            this._lblscore.Location = new System.Drawing.Point(501, 9);
            this._lblscore.Name = "_lblscore";
            this._lblscore.Size = new System.Drawing.Size(95, 45);
            this._lblscore.TabIndex = 3;
            this._lblscore.Text = "Score:";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.White;
            this.lblscore.Location = new System.Drawing.Point(609, 11);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(35, 45);
            this.lblscore.TabIndex = 4;
            this.lblscore.Text = "0";
            // 
            // timer5
            // 
            this.timer5.Interval = 25;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // pbexplosion
            // 
            this.pbexplosion.BackColor = System.Drawing.Color.Transparent;
            this.pbexplosion.Image = global::RST.Properties.Resources.blowup;
            this.pbexplosion.Location = new System.Drawing.Point(0, -2);
            this.pbexplosion.Name = "pbexplosion";
            this.pbexplosion.Size = new System.Drawing.Size(234, 100);
            this.pbexplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbexplosion.TabIndex = 5;
            this.pbexplosion.TabStop = false;
            // 
            // timer7
            // 
            this.timer7.Interval = 1314;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Interval = 3750;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // pbshield
            // 
            this.pbshield.BackColor = System.Drawing.Color.Transparent;
            this.pbshield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbshield.Image = global::RST.Properties.Resources.maybeshield;
            this.pbshield.Location = new System.Drawing.Point(25, 333);
            this.pbshield.Name = "pbshield";
            this.pbshield.Size = new System.Drawing.Size(245, 165);
            this.pbshield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbshield.TabIndex = 6;
            this.pbshield.TabStop = false;
            // 
            // timer9
            // 
            this.timer9.Interval = 500;
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer10
            // 
            this.timer10.Interval = 5000;
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // pblives3
            // 
            this.pblives3.BackColor = System.Drawing.Color.Transparent;
            this.pblives3.Image = global::RST.Properties.Resources.heart;
            this.pblives3.Location = new System.Drawing.Point(974, 9);
            this.pblives3.Name = "pblives3";
            this.pblives3.Size = new System.Drawing.Size(38, 30);
            this.pblives3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblives3.TabIndex = 7;
            this.pblives3.TabStop = false;
            // 
            // pblives2
            // 
            this.pblives2.BackColor = System.Drawing.Color.Transparent;
            this.pblives2.Image = global::RST.Properties.Resources.heart;
            this.pblives2.Location = new System.Drawing.Point(1018, 9);
            this.pblives2.Name = "pblives2";
            this.pblives2.Size = new System.Drawing.Size(38, 30);
            this.pblives2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblives2.TabIndex = 8;
            this.pblives2.TabStop = false;
            // 
            // pblives1
            // 
            this.pblives1.BackColor = System.Drawing.Color.Transparent;
            this.pblives1.Image = global::RST.Properties.Resources.heart;
            this.pblives1.Location = new System.Drawing.Point(1062, 9);
            this.pblives1.Name = "pblives1";
            this.pblives1.Size = new System.Drawing.Size(38, 30);
            this.pblives1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblives1.TabIndex = 9;
            this.pblives1.TabStop = false;
            // 
            // timer11
            // 
            this.timer11.Interval = 500;
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // timer12
            // 
            this.timer12.Enabled = true;
            this.timer12.Interval = 5000;
            this.timer12.Tick += new System.EventHandler(this.timer12_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RST.Properties.Resources.titloeeee;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RST.Properties.Resources.Webp_net_resizeimage__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pblives1);
            this.Controls.Add(this.pblives2);
            this.Controls.Add(this.pblives3);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this._lblscore);
            this.Controls.Add(this.pbplayer);
            this.Controls.Add(this.pbhover);
            this.Controls.Add(this.pbexplosion);
            this.Controls.Add(this.pbshield);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midnight Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbexplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblives3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblives2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblives1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbplayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pbhover;
        private System.Windows.Forms.Label _lblscore;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox pbexplosion;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.PictureBox pbshield;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.PictureBox pblives3;
        private System.Windows.Forms.PictureBox pblives2;
        private System.Windows.Forms.PictureBox pblives1;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

