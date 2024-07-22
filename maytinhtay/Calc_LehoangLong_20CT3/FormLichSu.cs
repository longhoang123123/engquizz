using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_LehoangLong_20CT3
{
    public partial class frmLichSu : Form
    {
        public List<String> lichsuList = new List<String>();
        public frmLichSu()
        {
            InitializeComponent();

            // Chỉnh căn lề của văn bản hiện tại (đang được chọn) sang bên phải
            rtbLichSu.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rtbLichSu.Clear();
            lichsuList.Clear();
        }

        private void frmLichSu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < lichsuList.Count; i += 2)
            {
                rtbLichSu.AppendText(lichsuList[i] + "\n");
                rtbLichSu.AppendText(lichsuList[i + 1] + "\n");
            }
        }
    }
}
