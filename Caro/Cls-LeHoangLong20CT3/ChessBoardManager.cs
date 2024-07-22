using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cls_LeHoangLong20CT3
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;

        public List<Player> Player
        {
            get { return player; }
            set { player = value;  }
        }

        private int currentPlayer;

        public int CurrentPlayer
        {
            set { currentPlayer = value; }
            get { return currentPlayer; }
        }

        private Label playerMark;

        public Label PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }
        }

        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;
        public Stack<PlayInfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }

        public Form1 FrmLong { get => frmLong; set => frmLong = value; }
        public List<Button> BtnWins { get => btnWins; set => btnWins = value; }

        private Form1 frmLong;

        private List<Button> btnWins = new List<Button>();

        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard, Label mark, Form1 frmLong)
        {
            this.chessBoard = chessBoard;
            this.playerMark = mark;
            this.frmLong = frmLong;

            this.player = new List<Player>()
            { 
                new Player("HowKteam", "X", Color.Blue, Color.White),
                new Player("long", "O", Color.Orange, Color.White)
            };
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            frmLong.lblPlayerName1.Text = Player[0].Name;
            frmLong.lblPlayerName2.Text = Player[1].Name;

            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            playTimeLine = new Stack<PlayInfo>();

            currentPlayer = 0;

            ChangePlayer();

            Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    chessBoard.Controls.Add(btn);

                    matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != "")
                return;

            Mark(btn);
            frmLong.timeOut = Cons.COOL_DOWN_TIME;
            frmLong.lblTimeDown1.Text = "Time: " + frmLong.timeOut + "s";
            frmLong.lblTimeDown2.Text = "Time: " + frmLong.timeOut + "s";

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));


            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new EventArgs());
            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;

            PlayInfo oldPoint = playTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

            btn.Text = "";

            if (PlayTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = playTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }
            
            ChangePlayer();

            return true;
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            

            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);
            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            BtnWins.Clear();
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for(int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[point.Y][i]);
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[point.Y][i]);
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            BtnWins.Clear();
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[i][point.X]);
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[i][point.X]);
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        private bool isEndPrimary(Button btn)
        {
            BtnWins.Clear();
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[point.Y - i][point.X - i]);
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH)
                    break;

                if (Matrix[point.Y + i][point.X + i].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[point.Y + i][point.X + i]);
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        private bool isEndSub(Button btn)
        {
            BtnWins.Clear();
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[point.Y - i][point.X + i]);
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].Text == btn.Text)
                {
                    BtnWins.Add(Matrix[point.Y + i][point.X - i]);
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.Text = Player[CurrentPlayer].Mark;
            btn.BackColor = Player[CurrentPlayer].BackColor;
            btn.ForeColor = Player[CurrentPlayer].ForeColor;
        }

        private void ChangePlayer()
        {
            playerMark.Text = Player[CurrentPlayer].Mark;
            playerMark.BackColor = Player[CurrentPlayer].BackColor;
            playerMark.ForeColor = Player[CurrentPlayer].ForeColor;
        }
        #endregion
    }
}
