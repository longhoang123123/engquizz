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
    public partial class frmLong : Form
    {
        private List<String> lichsuList = new List<String>();

        public frmLong()
        {
            InitializeComponent();

            // Chỉnh căn lề của văn bản hiện tại (đang được chọn) sang bên phải
            rtbCongThuc.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnKhong.Text;
        }

        private void btnMot_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnMot.Text;
        }

        private void btnHai_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnHai.Text;
        }

        private void btnBa_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnBa.Text;
        }

        private void btnBon_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnBon.Text;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnNam.Text;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnSau.Text;
        }

        private void btnBay_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnBay.Text;
        }

        private void btnTam_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnTam.Text;
        }

        private void btnChin_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnChin.Text;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += " " + btnCong.Text + " ";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += " " + btnTru.Text + " ";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += " " + btnNhan.Text + " ";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += " " + btnChia.Text + " ";
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnPhanTram.Text;
        }

        private void btnPhay_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text += btnPhay.Text;
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            rtbCongThuc.Text = "";
            tbKetQua.Text = "";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            String expression = rtbCongThuc.Text;

            expression = expression.Replace(",", ".");
            expression = expression.Replace("x", "*");
            expression = expression.Replace("÷", "/");
            expression = expression.Replace("%", "/100");

            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            tbKetQua.Text = (string)row["expression"];

            lichsuList.Add(rtbCongThuc.Text);
            lichsuList.Add("= " + tbKetQua.Text);
        }

        private void btnNgoac_Click(object sender, EventArgs e)
        {
            int openCount = 0;
            int closeCount = 0;
            String congThuc = rtbCongThuc.Text;

            for (int i = 0; i < congThuc.Length; i++)
            {
                if (congThuc[i] == '(')
                {
                    openCount++;
                }else if (congThuc[i] == ')')
                {
                    closeCount++;
                }
            }

            if(openCount > closeCount)
            {
                rtbCongThuc.Text += ")";
            }else
            {
                rtbCongThuc.Text += "(";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String congThuc = rtbCongThuc.Text;
            if(congThuc.EndsWith(" "))
            {
                congThuc = congThuc.Remove(congThuc.Length - 3, 3);
            }else
            {
                congThuc = congThuc.Remove(congThuc.Length - 1, 1);
            }

            rtbCongThuc.Text = congThuc;
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSu frmLichSu = new frmLichSu();
            frmLichSu.lichsuList = lichsuList;
            frmLichSu.ShowDialog();
        }
    }
}
