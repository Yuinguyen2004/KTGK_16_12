namespace KT_16_12
{
    public partial class frm_sinhvien
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
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoát = new System.Windows.Forms.Button();
            this.btn_kluu = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dtgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.gb_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.dtp_ngaysinh);
            this.gb_thongtin.Controls.Add(this.cb_lop);
            this.gb_thongtin.Controls.Add(this.label4);
            this.gb_thongtin.Controls.Add(this.txt_hoten);
            this.gb_thongtin.Controls.Add(this.label3);
            this.gb_thongtin.Controls.Add(this.label2);
            this.gb_thongtin.Controls.Add(this.txt_mssv);
            this.gb_thongtin.Controls.Add(this.label1);
            this.gb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtin.Location = new System.Drawing.Point(55, 5);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(709, 151);
            this.gb_thongtin.TabIndex = 0;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin chi tiết";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaysinh.Location = new System.Drawing.Point(164, 82);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(163, 22);
            this.dtp_ngaysinh.TabIndex = 11;
            this.dtp_ngaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(456, 82);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(140, 28);
            this.cb_lop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp học:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(456, 37);
            this.txt_hoten.Multiline = true;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(228, 22);
            this.txt_hoten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh:";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(164, 37);
            this.txt_mssv.Multiline = true;
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(163, 22);
            this.txt_mssv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(12, 162);
            this.txt_tim.Multiline = true;
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(140, 36);
            this.txt_tim.TabIndex = 2;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(168, 162);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 36);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(270, 174);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(64, 24);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(355, 174);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(64, 24);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Tag = "";
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(441, 174);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(64, 24);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoát
            // 
            this.btn_thoát.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoát.Location = new System.Drawing.Point(700, 174);
            this.btn_thoát.Name = "btn_thoát";
            this.btn_thoát.Size = new System.Drawing.Size(64, 24);
            this.btn_thoát.TabIndex = 9;
            this.btn_thoát.Text = "thoát";
            this.btn_thoát.UseVisualStyleBackColor = true;
            // 
            // btn_kluu
            // 
            this.btn_kluu.Location = new System.Drawing.Point(614, 174);
            this.btn_kluu.Name = "btn_kluu";
            this.btn_kluu.Size = new System.Drawing.Size(64, 24);
            this.btn_kluu.TabIndex = 8;
            this.btn_kluu.Tag = "";
            this.btn_kluu.Text = "k.lưu";
            this.btn_kluu.UseVisualStyleBackColor = true;
            this.btn_kluu.Click += new System.EventHandler(this.btn_kluu_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(529, 174);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(64, 24);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.Text = "lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // dtgv_sinhvien
            // 
            this.dtgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sinhvien.Location = new System.Drawing.Point(55, 204);
            this.dtgv_sinhvien.Name = "dtgv_sinhvien";
            this.dtgv_sinhvien.RowHeadersWidth = 51;
            this.dtgv_sinhvien.RowTemplate.Height = 24;
            this.dtgv_sinhvien.Size = new System.Drawing.Size(709, 234);
            this.dtgv_sinhvien.TabIndex = 10;
            this.dtgv_sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sinhvien_CellClick);
            // 
            // frm_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoát;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgv_sinhvien);
            this.Controls.Add(this.btn_thoát);
            this.Controls.Add(this.btn_kluu);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.gb_thongtin);
            this.Name = "frm_sinhvien";
            this.Text = "DANH SACH SINH VIEN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_sinhvien_FormClosing);
            this.Load += new System.EventHandler(this.frm_sinhvien_Load);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoát;
        private System.Windows.Forms.Button btn_kluu;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridView dtgv_sinhvien;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
    }
}

