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
    public partial class FormPlayer : Form
    {
        private Form1 frmLong;

        public FormPlayer(Form1 frmLong)
        {
            InitializeComponent();
            this.frmLong = frmLong;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string playerName1 = tbPlayerName1.Text;
            string playerName2 = tbPlayerName2.Text;

            frmLong.isStart = true;

            frmLong.ChessBoard.Player = new List<Player>()
            {
                new Player(playerName1, "X", Color.Blue, Color.White),
                new Player(playerName2, "O", Color.Orange, Color.White)
            };

            this.Close();
        }
    }
}
