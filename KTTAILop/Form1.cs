using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTTAILop.Model;

namespace KT_16_12
{
    public partial class frm_sinhvien : Form
    {
        private QuanlySV _dbContest;
        private SinhVien student = null;
        private bool isDataAdded = false;
        public frm_sinhvien()
        {
            InitializeComponent();
            _dbContest = new QuanlySV();
        }
        private void loaddata()
        {
            QuanlySV db = new QuanlySV();
            var students = db.SinhViens.Select(s => new
            {
                s.MaSV,
                s.HoTenSV,
                s.NgaySinh,
                s.MaLop
            }).ToList();
            dtgv_sinhvien.DataSource = students;
        }

        private void LoadMaSV()
        {
            // Lấy danh sách các khoa và gán vào ComboBox
            cb_lop.DataSource = _dbContest.Lops.ToList();
            cb_lop.DisplayMember = "TenLop"; // Hiển thị tên khoa
            cb_lop.ValueMember = "MaLop"; // Giá trị tương ứng với ID khoa
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_tim.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            var results = _dbContest.SinhViens
                                    .Where(s => s.MaSV.Contains(searchKeyword) ||
                                                s.HoTenSV.Contains(searchKeyword) ||
                                                s.MaLop.Contains(searchKeyword))
                                    .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào.");
            }

            dtgv_sinhvien.DataSource = results;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mssv.Text) || string.IsNullOrEmpty(txt_hoten.Text) || string.IsNullOrEmpty(dtp_ngaysinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.");
                return;
            }

            student = new SinhVien
            {
                MaSV = txt_mssv.Text,
                HoTenSV = txt_hoten.Text,
                NgaySinh = dtp_ngaysinh.Value,
                MaLop = cb_lop.SelectedValue?.ToString()
            };

            var tempList = new List<SinhVien> { student };
            dtgv_sinhvien.DataSource = tempList;

            isDataAdded = true;

            btn_luu.Visible = true;
            btn_kluu.Visible = true;

            MessageBox.Show("Thông tin sinh viên đã được thêm vào bộ nhớ tạm.");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtp_ngaysinh.Format = DateTimePickerFormat.Custom;
            dtp_ngaysinh.CustomFormat = "dd/MM/yyyy";

        }

        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadMaSV();
            btn_kluu.Visible = false;
            btn_luu.Visible = false;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maSV = txt_mssv.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
                return;
            }

            var student = _dbContest.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã này.");
                return;
            }

            _dbContest.SinhViens.Remove(student);
            _dbContest.SaveChanges();

            loaddata();

            MessageBox.Show("Xóa sinh viên thành công!");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maSV = txt_mssv.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
                return;
            }

            var student = _dbContest.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã này.");
                return;
            }

            student.HoTenSV = txt_hoten.Text;
            student.NgaySinh = dtp_ngaysinh.Value;
            student.MaLop = cb_lop.SelectedValue?.ToString();

            _dbContest.SaveChanges();
            loaddata();

            MessageBox.Show("Cập nhật sinh viên thành công!");
        }

        private void dtgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                DataGridViewRow row = dtgv_sinhvien.Rows[e.RowIndex];
                txt_mssv.Text = row.Cells["MaSV"].Value.ToString();
                txt_hoten.Text = row.Cells["HoTenSV"].Value.ToString();
                dtp_ngaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cb_lop.SelectedValue = row.Cells["MaLop"].Value?.ToString();
            }
        }

        private bool IsDataChanged()
        {
            if (string.IsNullOrEmpty(txt_mssv.Text) && string.IsNullOrEmpty(txt_hoten.Text) &&
                string.IsNullOrEmpty(dtp_ngaysinh.Text) && cb_lop.SelectedValue != null)
            {
                return false;
            }
            return true;
        }


        private void LuuDuLieu()
        {
            if (string.IsNullOrEmpty(txt_mssv.Text) || string.IsNullOrEmpty(txt_hoten.Text) || string.IsNullOrEmpty(dtp_ngaysinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.");
                return;
            }


            var student = new SinhVien
            {
                MaSV = txt_mssv.Text,
                HoTenSV = txt_hoten.Text,
                NgaySinh = dtp_ngaysinh.Value,
                MaLop = cb_lop.SelectedValue?.ToString()
            };

            _dbContest.SinhViens.Add(student);

            try
            {
                _dbContest.SaveChanges();
                MessageBox.Show("Dữ liệu đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void frm_sinhvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
                return;
            }

            try
            {
                _dbContest.SinhViens.Add(student);

                _dbContest.SaveChanges();

                MessageBox.Show("Dữ liệu đã được lưu thành công!");

                student = null;
                isDataAdded = false;

                btn_luu.Visible = false;
                btn_kluu.Visible = false;

                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btn_kluu_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                MessageBox.Show("Không có dữ liệu để hủy.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn không muốn lưu thay đổi?",
                                          "Xác nhận",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                student = null;

                txt_mssv.Clear();
                txt_hoten.Clear();
                dtp_ngaysinh.Value = DateTime.Now;
                cb_lop.SelectedIndex = -1;

                MessageBox.Show("Dữ liệu đã bị hủy và không được lưu.");
                loaddata();
                btn_luu.Visible = false;
                btn_kluu.Visible = false;
            }
        }

    }
}

               
