using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace ChatClient
{
    public partial class frmClient : Form
    {
        private string name = "CLient1";
        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            KetNoi();
            Nhan();
            
        }
        Socket client;
        IPAddress ia;
        IPEndPoint ie;
        private void KetNoi()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ia = IPAddress.Parse("127.0.0.1");
            ie = new IPEndPoint(ia, 2023);
            client.Connect(ie);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void btnicon_Click(object sender, EventArgs e)
        {
            pnlEmoji.Visible = !pnlEmoji.Visible;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void Gui(string header, string data, string sendat = "")
        {
            client.Send(MaHoa(header + "|" + data + "|" + sendat));
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string sendat = "[" + dateTime.ToString("hh:mm tt") + "]";
            Gui("text", sendat + " " + name + ": " + textBox1.Text);

            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.AppendText(sendat + " Bạn: " + textBox1.Text);
            richTextBox1.AppendText(Environment.NewLine);
            textBox1.Clear();
        }

        private byte[] MaHoa(string s)
        {
            byte[] data = new byte[1024 * 5000]; // 5MB
            data = Encoding.Unicode.GetBytes(s);
            return data;
        }

        private string GiaiMa(byte[] data)
        {
            string s = Encoding.Unicode.GetString(data);
            return s;
        }
        private void Nhan() // nhận dữ liệu
        {
            Thread tNhan = new Thread(new ThreadStart(() => {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000]; // 5MB
                    client.Receive(data);
                    string s = GiaiMa(data);
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate {
                            ProcessData(s);
                        });
                    }
                    else
                    {
                        ProcessData(s);
                    }
                }

            }));
            tNhan.Start();
        }

        private void ProcessData(string data)
        {
            string[] arr = data.Split(new char[] { '|' });
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            if (arr[0] == "text")
            {
               
                richTextBox1.AppendText(arr[1]);
            }
            else if (arr[0] == "image")
            {
                string base64String = JsonConvert.DeserializeObject<string>(arr[1]);
                // Giải mã chuỗi Base64 thành dữ liệu byte
                byte[] imageBytes = Convert.FromBase64String(base64String);

                Image image;
                // Tạo MemoryStream từ dữ liệu byte
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Tạo đối tượng hình ảnh từ MemoryStream
                    image = Image.FromStream(ms);
                }

                richTextBox1.AppendText(arr[2]);
                Clipboard.SetDataObject(new Bitmap(image), true, 100, 200);
                richTextBox1.Paste();
            }

            richTextBox1.AppendText(Environment.NewLine);
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính cho dialog mở file ảnh
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn một ảnh";

            // Hiển thị dialog và kiểm tra nếu người dùng chọn một file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến file đã chọn
                string selectedImagePath = openFileDialog.FileName;
                Image image = Image.FromFile(selectedImagePath);

                DateTime dateTime = DateTime.Now;
                string sendat = "[" + dateTime.ToString("hh:mm tt") + "] ";

                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.AppendText(sendat);

                Clipboard.SetDataObject(new Bitmap(image), true, 100, 200);
                richTextBox1.Paste();
                richTextBox1.AppendText(Environment.NewLine);

                // Xử lý ảnh theo đường dẫn đã chọn, ví dụ:
                // pictureBox.Image = new Bitmap(selectedImagePath);

                // Đọc dữ liệu từ file ảnh
                byte[] imageBytes = File.ReadAllBytes(selectedImagePath);

                // Chuyển đổi dữ liệu thành chuỗi Base64
                string base64String = Convert.ToBase64String(imageBytes);
                string base64Json = JsonConvert.SerializeObject(base64String);
                Gui("image", base64Json, sendat);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteSelfMessages();
        }

        private void DeleteSelfMessages()
        {
            // Giả sử richTextBox1 là RichTextBox bạn đang làm việc
            int lineCount = richTextBox1.Lines.Length;

            if (lineCount > 0)
            {
                // Tạo một danh sách từ mảng dòng hiện tại
                List<string> linesList = new List<string>(richTextBox1.Lines);

                // Loại bỏ dòng cuối cùng
                linesList.RemoveAt(lineCount - 1);

                // Cập nhật RichTextBox với danh sách mới
                richTextBox1.Lines = linesList.ToArray();
            }
        }
    }
}
