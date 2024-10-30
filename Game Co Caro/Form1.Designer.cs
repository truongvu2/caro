namespace Game_Co_Caro
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
            this.pnShow = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRule = new System.Windows.Forms.Label();
            this.ptbPayer = new System.Windows.Forms.PictureBox();
            this.psbCooldownTime = new System.Windows.Forms.ProgressBar();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.Avata = new System.Windows.Forms.PictureBox();
            this.pnTableChess = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1VsPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.howPlayGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDevelopmentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCooldown = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).BeginInit();
            this.pnTableChess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnShow.Controls.Add(this.label7);
            this.pnShow.Controls.Add(this.label6);
            this.pnShow.Controls.Add(this.label5);
            this.pnShow.Controls.Add(this.label4);
            this.pnShow.Controls.Add(this.pictureBox1);
            this.pnShow.Controls.Add(this.label3);
            this.pnShow.Controls.Add(this.label2);
            this.pnShow.Controls.Add(this.label1);
            this.pnShow.Controls.Add(this.lbRule);
            this.pnShow.Controls.Add(this.ptbPayer);
            this.pnShow.Controls.Add(this.psbCooldownTime);
            this.pnShow.Controls.Add(this.txtNamePlayer);
            this.pnShow.Controls.Add(this.Avata);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnShow.Location = new System.Drawing.Point(820, 0);
            this.pnShow.Margin = new System.Windows.Forms.Padding(4);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(312, 644);
            this.pnShow.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Co_Caro.Properties.Resources.matcuoi;
            this.pictureBox1.Location = new System.Drawing.Point(251, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Game dành cho mọi lứa tuổi\r\nChới quá 180 phút ảnh hưởng đến sức khỏe\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên người chơi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thời gian mỗi nước đi";
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRule.Font = new System.Drawing.Font("Cooper Black", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(2, 578);
            this.lbRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(233, 36);
            this.lbRule.TabIndex = 4;
            this.lbRule.Text = "Game cờ Caro";
            // 
            // ptbPayer
            // 
            this.ptbPayer.BackColor = System.Drawing.Color.Gray;
            this.ptbPayer.Location = new System.Drawing.Point(175, 352);
            this.ptbPayer.Margin = new System.Windows.Forms.Padding(4);
            this.ptbPayer.Name = "ptbPayer";
            this.ptbPayer.Size = new System.Drawing.Size(133, 106);
            this.ptbPayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPayer.TabIndex = 3;
            this.ptbPayer.TabStop = false;
            // 
            // psbCooldownTime
            // 
            this.psbCooldownTime.Location = new System.Drawing.Point(10, 423);
            this.psbCooldownTime.Margin = new System.Windows.Forms.Padding(4);
            this.psbCooldownTime.Maximum = 20000;
            this.psbCooldownTime.Name = "psbCooldownTime";
            this.psbCooldownTime.Size = new System.Drawing.Size(160, 46);
            this.psbCooldownTime.Step = 100;
            this.psbCooldownTime.TabIndex = 1;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer.Location = new System.Drawing.Point(8, 352);
            this.txtNamePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamePlayer.Multiline = true;
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.ReadOnly = true;
            this.txtNamePlayer.Size = new System.Drawing.Size(159, 45);
            this.txtNamePlayer.TabIndex = 10;
            // 
            // Avata
            // 
            this.Avata.Image = global::Game_Co_Caro.Properties.Resources.caro;
            this.Avata.Location = new System.Drawing.Point(4, 4);
            this.Avata.Margin = new System.Windows.Forms.Padding(4);
            this.Avata.Name = "Avata";
            this.Avata.Size = new System.Drawing.Size(305, 272);
            this.Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avata.TabIndex = 0;
            this.Avata.TabStop = false;
            // 
            // pnTableChess
            // 
            this.pnTableChess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnTableChess.Controls.Add(this.menuStrip1);
            this.pnTableChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableChess.Location = new System.Drawing.Point(0, 0);
            this.pnTableChess.Margin = new System.Windows.Forms.Padding(4);
            this.pnTableChess.Name = "pnTableChess";
            this.pnTableChess.Size = new System.Drawing.Size(820, 644);
            this.pnTableChess.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuUndo,
            this.menuQuit,
            this.howPlayGameToolStripMenuItem,
            this.gameDevelopmentHistoryToolStripMenuItem,
            this.otherGamesToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(60, 24);
            this.menuGame.Text = "Menu";
            // 
            // menuNewGame
            // 
            this.menuNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.player1VsPlayer2ToolStripMenuItem});
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(224, 26);
            this.menuNewGame.Text = "New game";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.playToolStripMenuItem.Text = "Play vs Computer";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayVsComputer);
            // 
            // player1VsPlayer2ToolStripMenuItem
            // 
            this.player1VsPlayer2ToolStripMenuItem.Name = "player1VsPlayer2ToolStripMenuItem";
            this.player1VsPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.player1VsPlayer2ToolStripMenuItem.Text = "Player1 vs Player2";
            this.player1VsPlayer2ToolStripMenuItem.Click += new System.EventHandler(this.player1VsPlayer2);
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(224, 26);
            this.menuUndo.Text = "Undo";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuQuit.Size = new System.Drawing.Size(224, 26);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click_1);
            // 
            // howPlayGameToolStripMenuItem
            // 
            this.howPlayGameToolStripMenuItem.Name = "howPlayGameToolStripMenuItem";
            this.howPlayGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.howPlayGameToolStripMenuItem.Text = "How play game";
            this.howPlayGameToolStripMenuItem.Click += new System.EventHandler(this.howPlayGameToolStripMenuItem_Click);
            // 
            // gameDevelopmentHistoryToolStripMenuItem
            // 
            this.gameDevelopmentHistoryToolStripMenuItem.Name = "gameDevelopmentHistoryToolStripMenuItem";
            this.gameDevelopmentHistoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gameDevelopmentHistoryToolStripMenuItem.Text = "History of the game";
            this.gameDevelopmentHistoryToolStripMenuItem.Click += new System.EventHandler(this.gameDevelopmentHistoryToolStripMenuItem_Click);
            // 
            // otherGamesToolStripMenuItem
            // 
            this.otherGamesToolStripMenuItem.Name = "otherGamesToolStripMenuItem";
            this.otherGamesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.otherGamesToolStripMenuItem.Text = "Other games";
            this.otherGamesToolStripMenuItem.Click += new System.EventHandler(this.otherGamesToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // tmCooldown
            // 
            this.tmCooldown.Tick += new System.EventHandler(this.tmCooldown_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 644);
            this.Controls.Add(this.pnTableChess);
            this.Controls.Add(this.pnShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game caro";
            this.pnShow.ResumeLayout(false);
            this.pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).EndInit();
            this.pnTableChess.ResumeLayout(false);
            this.pnTableChess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.PictureBox ptbPayer;
        private System.Windows.Forms.ProgressBar psbCooldownTime;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.PictureBox Avata;
        private System.Windows.Forms.Panel pnTableChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1VsPlayer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.Timer tmCooldown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem howPlayGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDevelopmentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherGamesToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

