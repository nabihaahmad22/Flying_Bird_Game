
namespace Flying_Bird_Game_Windows_Form
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
            this.topblock = new System.Windows.Forms.PictureBox();
            this.flyingbird = new System.Windows.Forms.PictureBox();
            this.bottomblock = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreboard = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.game_menu = new System.Windows.Forms.GroupBox();
            this.restartlabel = new System.Windows.Forms.Label();
            this.quitlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.topblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyingbird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.game_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topblock
            // 
            this.topblock.Image = global::Flying_Bird_Game_Windows_Form.Properties.Resources.pipedown;
            this.topblock.Location = new System.Drawing.Point(385, -16);
            this.topblock.Name = "topblock";
            this.topblock.Size = new System.Drawing.Size(74, 197);
            this.topblock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topblock.TabIndex = 0;
            this.topblock.TabStop = false;
            // 
            // flyingbird
            // 
            this.flyingbird.Image = global::Flying_Bird_Game_Windows_Form.Properties.Resources.bird;
            this.flyingbird.Location = new System.Drawing.Point(56, 207);
            this.flyingbird.Name = "flyingbird";
            this.flyingbird.Size = new System.Drawing.Size(50, 40);
            this.flyingbird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flyingbird.TabIndex = 1;
            this.flyingbird.TabStop = false;
            // 
            // bottomblock
            // 
            this.bottomblock.Image = global::Flying_Bird_Game_Windows_Form.Properties.Resources.pipe;
            this.bottomblock.Location = new System.Drawing.Point(277, 313);
            this.bottomblock.Name = "bottomblock";
            this.bottomblock.Size = new System.Drawing.Size(74, 166);
            this.bottomblock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomblock.TabIndex = 2;
            this.bottomblock.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flying_Bird_Game_Windows_Form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 468);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(543, 76);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.BackColor = System.Drawing.Color.NavajoWhite;
            this.scoreboard.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboard.Location = new System.Drawing.Point(108, 486);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(75, 20);
            this.scoreboard.TabIndex = 4;
            this.scoreboard.Text = "Score= 0";
            // 
            // gametime
            // 
            this.gametime.Enabled = true;
            this.gametime.Interval = 20;
            this.gametime.Tick += new System.EventHandler(this.gametimeevents);
            // 
            // game_menu
            // 
            this.game_menu.BackColor = System.Drawing.Color.Gold;
            this.game_menu.Controls.Add(this.label1);
            this.game_menu.Controls.Add(this.quitlabel);
            this.game_menu.Controls.Add(this.restartlabel);
            this.game_menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_menu.Location = new System.Drawing.Point(112, 107);
            this.game_menu.Name = "game_menu";
            this.game_menu.Size = new System.Drawing.Size(308, 240);
            this.game_menu.TabIndex = 5;
            this.game_menu.TabStop = false;
            this.game_menu.Text = "Menu";
            // 
            // restartlabel
            // 
            this.restartlabel.AutoSize = true;
            this.restartlabel.BackColor = System.Drawing.Color.Transparent;
            this.restartlabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartlabel.Location = new System.Drawing.Point(108, 100);
            this.restartlabel.Name = "restartlabel";
            this.restartlabel.Size = new System.Drawing.Size(88, 26);
            this.restartlabel.TabIndex = 5;
            this.restartlabel.Text = "Restart";
            this.restartlabel.Click += new System.EventHandler(this.restartlabel_Click);
            // 
            // quitlabel
            // 
            this.quitlabel.AutoSize = true;
            this.quitlabel.BackColor = System.Drawing.Color.Transparent;
            this.quitlabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitlabel.Location = new System.Drawing.Point(118, 167);
            this.quitlabel.Name = "quitlabel";
            this.quitlabel.Size = new System.Drawing.Size(59, 26);
            this.quitlabel.TabIndex = 6;
            this.quitlabel.Text = "Quit";
            this.quitlabel.Click += new System.EventHandler(this.quitlabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Over!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(535, 515);
            this.Controls.Add(this.game_menu);
            this.Controls.Add(this.flyingbird);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottomblock);
            this.Controls.Add(this.topblock);
            this.Name = "Form1";
            this.Text = "Flying Bird ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.topblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyingbird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.game_menu.ResumeLayout(false);
            this.game_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topblock;
        private System.Windows.Forms.PictureBox flyingbird;
        private System.Windows.Forms.PictureBox bottomblock;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreboard;
        private System.Windows.Forms.Timer gametime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox game_menu;
        private System.Windows.Forms.Label quitlabel;
        private System.Windows.Forms.Label restartlabel;
        private System.Windows.Forms.Label label1;
    }
}

