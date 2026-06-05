using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataStore.LoadData();
            OpenChildForm(new FormThemMoi());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            childForm.Show();
            
            lblStatusLeft.Text = "Đang xem: " + childForm.Text;
        }

        private void btnNav_ThemMoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemMoi() { Text = "Thêm mới" });
        }

        private void btnNav_DanhSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSach() { Text = "Danh sách" });
        }

        private void btnNav_TimKiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTimKiem() { Text = "Tìm kiếm" });
        }

        private void btnNav_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe() { Text = "Thống kê" });
        }

        private void btnNav_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNav_Backup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                sfd.Title = "Sao lưu dữ liệu trang thiết bị";
                sfd.FileName = "backup_TTB_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".json";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileHelper.SaveData(sfd.FileName, DataStore.DsTTB);
                        MessageBox.Show("Sao lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi sao lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNav_Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                ofd.Title = "Chọn file dữ liệu trang thiết bị để nhập";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileText = System.IO.File.ReadAllText(ofd.FileName, System.Text.Encoding.UTF8);
                        List<TrangThietBi> importedList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TrangThietBi>>(fileText);

                        if (importedList == null || importedList.Count == 0)
                        {
                            MessageBox.Show("File không chứa dữ liệu trang thiết bị hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DialogResult mergeOrOverwrite = MessageBox.Show(
                            "Bạn muốn xử lý dữ liệu nhập vào như thế nào?\n\n" +
                            "- Chọn YES: Ghi đè (Thay thế toàn bộ dữ liệu hiện tại bằng dữ liệu mới).\n" +
                            "- Chọn NO: Gộp thêm (Bổ sung dữ liệu mới vào dữ liệu hiện tại).\n" +
                            "- Chọn CANCEL: Hủy bỏ thao tác.",
                            "Xác nhận nhập dữ liệu",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question
                        );

                        if (mergeOrOverwrite == DialogResult.Cancel)
                        {
                            return;
                        }

                        if (mergeOrOverwrite == DialogResult.Yes)
                        {
                            // Overwrite
                            DataStore.DsTTB = importedList;
                            DataStore.SaveData();
                            RefreshActiveFormIfNecessary();
                            MessageBox.Show("Đã ghi đè toàn bộ dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (mergeOrOverwrite == DialogResult.No)
                        {
                            // Merge
                            List<TrangThietBi> duplicates = new List<TrangThietBi>();
                            List<TrangThietBi> uniques = new List<TrangThietBi>();
                            HashSet<string> existingIDs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                            foreach (var item in DataStore.DsTTB)
                            {
                                if (!string.IsNullOrEmpty(item.MaTTB))
                                {
                                    existingIDs.Add(item.MaTTB.Trim());
                                }
                            }

                            foreach (var item in importedList)
                            {
                                if (string.IsNullOrEmpty(item.MaTTB)) continue;
                                if (existingIDs.Contains(item.MaTTB.Trim()))
                                {
                                    duplicates.Add(item);
                                }
                                else
                                {
                                    uniques.Add(item);
                                }
                            }

                            if (duplicates.Count > 0)
                            {
                                DialogResult duplicateOption = MessageBox.Show(
                                    $"Phát hiện {duplicates.Count} thiết bị có mã trùng lặp với dữ liệu hiện tại.\n\n" +
                                    "- Chọn YES: Ghi đè thông tin thiết bị cũ bằng thông tin mới.\n" +
                                    "- Chọn NO: Bỏ qua các thiết bị trùng mã (giữ nguyên thông tin cũ).\n" +
                                    "- Chọn CANCEL: Hủy bỏ thao tác nhập dữ liệu.",
                                    "Phát hiện trùng lặp mã thiết bị",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                if (duplicateOption == DialogResult.Cancel)
                                {
                                    return;
                                }

                                if (duplicateOption == DialogResult.Yes)
                                {
                                    // Overwrite duplicates
                                    var duplicateMap = new Dictionary<string, TrangThietBi>(StringComparer.OrdinalIgnoreCase);
                                    foreach (var item in duplicates)
                                    {
                                        duplicateMap[item.MaTTB.Trim()] = item;
                                    }

                                    for (int i = 0; i < DataStore.DsTTB.Count; i++)
                                    {
                                        string code = DataStore.DsTTB[i].MaTTB?.Trim();
                                        if (code != null && duplicateMap.ContainsKey(code))
                                        {
                                            DataStore.DsTTB[i] = duplicateMap[code];
                                        }
                                    }
                                    DataStore.DsTTB.AddRange(uniques);
                                }
                                else
                                {
                                    // Skip duplicates
                                    DataStore.DsTTB.AddRange(uniques);
                                }
                            }
                            else
                            {
                                // No duplicates
                                DataStore.DsTTB.AddRange(uniques);
                            }

                            DataStore.SaveData();
                            RefreshActiveFormIfNecessary();
                            MessageBox.Show($"Nhập gộp dữ liệu thành công! Đã thêm mới {uniques.Count} thiết bị, cập nhật {importedList.Count - uniques.Count} thiết bị trùng mã.", 
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Định dạng file không hợp lệ hoặc dữ liệu bị lỗi!\nChi tiết: " + ex.Message, "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RefreshActiveFormIfNecessary()
        {
            if (activeForm == null) return;

            Form newForm = null;
            string text = activeForm.Text;

            if (activeForm is FormThemMoi)
            {
                newForm = new FormThemMoi() { Text = text };
            }
            else if (activeForm is FormDanhSach)
            {
                newForm = new FormDanhSach() { Text = text };
            }
            else if (activeForm is FormTimKiem)
            {
                newForm = new FormTimKiem() { Text = text };
            }
            else if (activeForm is FormThongKe)
            {
                newForm = new FormThongKe() { Text = text };
            }

            if (newForm != null)
            {
                OpenChildForm(newForm);
            }
        }
    }
}
