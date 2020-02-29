namespace GhostHunter
{
    partial class GhostHunterForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                soundPlayer.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GhostHunterForm));
            this.loadBullet = new System.Windows.Forms.Button();
            this.fire = new System.Windows.Forms.Button();
            this.spinChambers = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lose = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalScore = new System.Windows.Forms.Label();
            this.winLose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadBullet
            // 
            this.loadBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBullet.Location = new System.Drawing.Point(46, 16);
            this.loadBullet.Margin = new System.Windows.Forms.Padding(2);
            this.loadBullet.Name = "loadBullet";
            this.loadBullet.Size = new System.Drawing.Size(142, 45);
            this.loadBullet.TabIndex = 0;
            this.loadBullet.Text = "Load Bullet";
            this.loadBullet.UseVisualStyleBackColor = false;
            this.loadBullet.Click += new System.EventHandler(this.LoadBullet_Click);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fire.Location = new System.Drawing.Point(270, 479);
            this.fire.Margin = new System.Windows.Forms.Padding(2);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(233, 46);
            this.fire.TabIndex = 3;
            this.fire.Text = "Fire";
            this.fire.UseVisualStyleBackColor = false;
            this.fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // spinChambers
            // 
            this.spinChambers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.spinChambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinChambers.Location = new System.Drawing.Point(46, 83);
            this.spinChambers.Margin = new System.Windows.Forms.Padding(2);
            this.spinChambers.Name = "spinChambers";
            this.spinChambers.Size = new System.Drawing.Size(142, 45);
            this.spinChambers.TabIndex = 4;
            this.spinChambers.Text = "Spin Chambers";
            this.spinChambers.UseVisualStyleBackColor = false;
            this.spinChambers.Click += new System.EventHandler(this.SpinChambers_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(46, 152);
            this.playAgain.Margin = new System.Windows.Forms.Padding(2);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(142, 39);
            this.playAgain.TabIndex = 5;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 395);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(52, 435);
            this.message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(649, 33);
            this.message.TabIndex = 1;
            this.message.Text = "Welcome to Ghost Hunter!!";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playAgain);
            this.panel2.Controls.Add(this.loadBullet);
            this.panel2.Controls.Add(this.spinChambers);
            this.panel2.Location = new System.Drawing.Point(503, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 212);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lose);
            this.panel3.Controls.Add(this.win);
            this.panel3.Controls.Add(this.score);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.totalScore);
            this.panel3.Controls.Add(this.winLose);
            this.panel3.Location = new System.Drawing.Point(503, 271);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 149);
            this.panel3.TabIndex = 8;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.Location = new System.Drawing.Point(181, 21);
            this.lose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(17, 18);
            this.lose.TabIndex = 6;
            this.lose.Text = "0";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.Location = new System.Drawing.Point(142, 21);
            this.win.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(17, 18);
            this.win.TabIndex = 5;
            this.win.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(161, 101);
            this.score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(17, 18);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.Location = new System.Drawing.Point(10, 101);
            this.totalScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(106, 18);
            this.totalScore.TabIndex = 1;
            this.totalScore.Text = "Total Score :";
            // 
            // winLose
            // 
            this.winLose.AutoSize = true;
            this.winLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLose.Location = new System.Drawing.Point(10, 21);
            this.winLose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLose.Name = "winLose";
            this.winLose.Size = new System.Drawing.Size(122, 18);
            this.winLose.TabIndex = 0;
            this.winLose.Text = "Wins / Loses : ";
            // 
            // GhostHunterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fire);
            this.Name = "GhostHunterForm";
            this.Text = "Ghost Hunter";
            this.Load += new System.EventHandler(this.GhostHunterForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBullet;
        private System.Windows.Forms.Button fire;
        private System.Windows.Forms.Button spinChambers;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label winLose;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Label win;
    }
}

