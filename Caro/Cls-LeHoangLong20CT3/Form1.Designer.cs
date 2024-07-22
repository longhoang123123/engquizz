namespace Cls_LeHoangLong20CT3
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
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbWin2 = new System.Windows.Forms.Label();
            this.lbWin1 = new System.Windows.Forms.Label();
            this.lbUndo2 = new System.Windows.Forms.Label();
            this.lbUndo1 = new System.Windows.Forms.Label();
            this.lbTimeDown2 = new System.Windows.Forms.Label();
            this.lbPlayerName2 = new System.Windows.Forms.Label();
            this.lbTimeDown1 = new System.Windows.Forms.Label();
            this.lbPlayerName1 = new System.Windows.Forms.Label();
            this.lbMark = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(5, 46);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(598, 544);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbWin2);
            this.panel3.Controls.Add(this.lbWin1);
            this.panel3.Controls.Add(this.lbUndo2);
            this.panel3.Controls.Add(this.lbUndo1);
            this.panel3.Controls.Add(this.lbTimeDown2);
            this.panel3.Controls.Add(this.lbPlayerName2);
            this.panel3.Controls.Add(this.lbTimeDown1);
            this.panel3.Controls.Add(this.lbPlayerName1);
            this.panel3.Controls.Add(this.lbMark);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(609, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 544);
            this.panel3.TabIndex = 2;
            // 
            // lbWin2
            // 
            this.lbWin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbWin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin2.ForeColor = System.Drawing.Color.Black;
            this.lbWin2.Location = new System.Drawing.Point(66, 353);
            this.lbWin2.Name = "lbWin2";
            this.lbWin2.Size = new System.Drawing.Size(160, 36);
            this.lbWin2.TabIndex = 7;
            this.lbWin2.Text = "Win: 00/00";
            this.lbWin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWin1
            // 
            this.lbWin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbWin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin1.ForeColor = System.Drawing.Color.Black;
            this.lbWin1.Location = new System.Drawing.Point(66, 155);
            this.lbWin1.Name = "lbWin1";
            this.lbWin1.Size = new System.Drawing.Size(160, 36);
            this.lbWin1.TabIndex = 7;
            this.lbWin1.Text = "Win: 00/00";
            this.lbWin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUndo2
            // 
            this.lbUndo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbUndo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUndo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUndo2.ForeColor = System.Drawing.Color.Black;
            this.lbUndo2.Location = new System.Drawing.Point(66, 302);
            this.lbUndo2.Name = "lbUndo2";
            this.lbUndo2.Size = new System.Drawing.Size(160, 36);
            this.lbUndo2.TabIndex = 7;
            this.lbUndo2.Text = "Undo: 00";
            this.lbUndo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUndo1
            // 
            this.lbUndo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbUndo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUndo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUndo1.ForeColor = System.Drawing.Color.Black;
            this.lbUndo1.Location = new System.Drawing.Point(66, 104);
            this.lbUndo1.Name = "lbUndo1";
            this.lbUndo1.Size = new System.Drawing.Size(160, 36);
            this.lbUndo1.TabIndex = 7;
            this.lbUndo1.Text = "Undo: 00";
            this.lbUndo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeDown2
            // 
            this.lbTimeDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTimeDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimeDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeDown2.ForeColor = System.Drawing.Color.Black;
            this.lbTimeDown2.Location = new System.Drawing.Point(66, 256);
            this.lbTimeDown2.Name = "lbTimeDown2";
            this.lbTimeDown2.Size = new System.Drawing.Size(160, 36);
            this.lbTimeDown2.TabIndex = 7;
            this.lbTimeDown2.Text = "Time: 10s";
            this.lbTimeDown2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayerName2
            // 
            this.lbPlayerName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPlayerName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlayerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName2.ForeColor = System.Drawing.Color.Black;
            this.lbPlayerName2.Location = new System.Drawing.Point(66, 208);
            this.lbPlayerName2.Name = "lbPlayerName2";
            this.lbPlayerName2.Size = new System.Drawing.Size(160, 36);
            this.lbPlayerName2.TabIndex = 7;
            this.lbPlayerName2.Text = "Player2";
            this.lbPlayerName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeDown1
            // 
            this.lbTimeDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTimeDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimeDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeDown1.ForeColor = System.Drawing.Color.Black;
            this.lbTimeDown1.Location = new System.Drawing.Point(66, 58);
            this.lbTimeDown1.Name = "lbTimeDown1";
            this.lbTimeDown1.Size = new System.Drawing.Size(160, 36);
            this.lbTimeDown1.TabIndex = 7;
            this.lbTimeDown1.Text = "Time: 10s";
            this.lbTimeDown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayerName1
            // 
            this.lbPlayerName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPlayerName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName1.ForeColor = System.Drawing.Color.Black;
            this.lbPlayerName1.Location = new System.Drawing.Point(66, 10);
            this.lbPlayerName1.Name = "lbPlayerName1";
            this.lbPlayerName1.Size = new System.Drawing.Size(160, 36);
            this.lbPlayerName1.TabIndex = 7;
            this.lbPlayerName1.Text = "Player1";
            this.lbPlayerName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMark
            // 
            this.lbMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMark.Location = new System.Drawing.Point(95, 404);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(100, 100);
            this.lbMark.TabIndex = 6;
            this.lbMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbMark;
        private System.Windows.Forms.Label lbTimeDown1;
        private System.Windows.Forms.Label lbPlayerName1;
        private System.Windows.Forms.Label lbWin2;
        private System.Windows.Forms.Label lbWin1;
        private System.Windows.Forms.Label lbUndo2;
        private System.Windows.Forms.Label lbUndo1;
        private System.Windows.Forms.Label lbTimeDown2;
        private System.Windows.Forms.Label lbPlayerName2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

