using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cls_LeHoangLong20CT3
{
    public partial class Form1 : Form
    {
        #region Properties
        public ChessBoardManager ChessBoard;
        public bool isStart = false;
        public Label lblPlayerName1;
        public Label lblPlayerName2;
        public Label lblTimeDown1;
        public Label lblTimeDown2;
        public int timeOut;

        private int gameCount = 0;
        private int winCount1 = 0;
        private int winCount2 = 0;

        private Timer flashTimer = new Timer ();
        private bool isFlash = false;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, lbMark, this);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;

            this.lblPlayerName1 = lbPlayerName1;
            this.lblPlayerName2 = lbPlayerName2;
            this.lblTimeDown1 = lbTimeDown1;
            this.lblTimeDown2 = lbTimeDown2;

            this.timeOut = Cons.COOL_DOWN_TIME;
            lbTimeDown1.Text = "Time: " + timeOut + "s";
            lbTimeDown2.Text = "Time: " + timeOut + "s";

            flashTimer.Tick += FlashTimer_Tick;
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            isFlash = !isFlash;
            ChessBoard.BtnWins.ForEach(btn =>
            {
                if (isFlash)
                {
                    btn.BackColor = Color.Yellow;
                }
                else
                {
                    btn.BackColor = ChessBoard.Player[ChessBoard.CurrentPlayer == 0 ? 1 : 0].BackColor;
                }
            });
        }

        #region Methods

        void EndGame()
        {
            if(ChessBoard.CurrentPlayer == 0)
            {
                winCount2++;
            }else
            {
                winCount1++;
            }

            lbWin1.Text = "Win: " + winCount1 + "/" + gameCount;
            lbWin2.Text = "Win: " + winCount2 + "/" + gameCount;

            tmCoolDown.Stop();
            flashTimer.Start();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("ket thuc!");
        }

        void NewGame()
        {
            this.timeOut = Cons.COOL_DOWN_TIME;
            lbTimeDown1.Text = "Time: " + timeOut + "s";
            lbTimeDown2.Text = "Time: " + timeOut + "s";
            gameCount++;
            tmCoolDown.Start();
            flashTimer.Stop();

            undoToolStripMenuItem.Enabled = true;

            ChessBoard.DrawChessBoard();
        }

        void Exit()
        {
            Application.Exit();
        }

        void Undo()
        {
            ChessBoard.Undo();
        }

        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            timeOut--;
            if(ChessBoard.CurrentPlayer == 0)
            {
                lbTimeDown1.Text = "Time: " + timeOut + "s";
            }else
            {
                lbTimeDown2.Text = "Time: " + timeOut + "s";
            }

            if(timeOut == 0)
            {
                EndGame();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat ?", "Thong Bao!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        #endregion

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                NewGame();
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlayer frmPlayer = new FormPlayer(this);
            frmPlayer.StartPosition = FormStartPosition.CenterScreen;
            frmPlayer.ShowDialog();

            if (isStart)
            {
                NewGame();
            }
        }
    }
}
