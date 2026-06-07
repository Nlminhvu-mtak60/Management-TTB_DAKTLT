using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QUANLY_TTB
{
    public partial class FormDangNhap : Form
    {
        private int soLanSai = 0;
        private string usersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\users.json");

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private string GetMD5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblThongBao.Text = "Vui lòng nhập tên đăng nhập và mật khẩu!";
                return;
            }

            if (!File.Exists(usersFilePath))
            {
                lblThongBao.Text = "Lỗi: Không tìm thấy file users.json!";
                return;
            }

            try
            {
                string json = File.ReadAllText(usersFilePath);
                List<NguoiDung> listUsers = JsonConvert.DeserializeObject<List<NguoiDung>>(json);

                string hashPass = GetMD5Hash(password);
                NguoiDung user = listUsers.Find(u => u.TenDangNhap == username && u.MatKhau == hashPass);

                if (user != null)
                {
                    DataStore.NguoiDungHienTai = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    soLanSai++;
                    if (soLanSai >= 3)
                    {
                        MessageBox.Show("Đăng nhập sai quá 3 lần. Chương trình sẽ thoát!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        lblThongBao.Text = $"Sai tài khoản hoặc mật khẩu! (Còn {3 - soLanSai} lần thử)";
                    }
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = "Lỗi đọc file: " + ex.Message;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
