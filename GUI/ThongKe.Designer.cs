namespace QuanLySinhVien.GUI
{
    partial class ThongKe
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
            this.tabPageThongke = new System.Windows.Forms.TabControl();
            this.tpMonHoc = new System.Windows.Forms.TabPage();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnTim_MonHoc = new System.Windows.Forms.Button();
            this.cbKhoa_MonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpGiangVien = new System.Windows.Forms.TabPage();
            this.btnTimKiem_GiangVien = new System.Windows.Forms.Button();
            this.cbKhoa_GiangVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.tpSinhVien = new System.Windows.Forms.TabPage();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbXS = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.rbK = new System.Windows.Forms.RadioButton();
            this.rbTB = new System.Windows.Forms.RadioButton();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.cbLop_SinhVien = new System.Windows.Forms.ComboBox();
            this.cbKhoa_SinhVien = new System.Windows.Forms.ComboBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabPageThongke.SuspendLayout();
            this.tpMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.tpGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.tpSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageThongke
            // 
            this.tabPageThongke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPageThongke.Controls.Add(this.tpMonHoc);
            this.tabPageThongke.Controls.Add(this.tpGiangVien);
            this.tabPageThongke.Controls.Add(this.tpSinhVien);
            this.tabPageThongke.Location = new System.Drawing.Point(0, 0);
            this.tabPageThongke.Name = "tabPageThongke";
            this.tabPageThongke.SelectedIndex = 0;
            this.tabPageThongke.Size = new System.Drawing.Size(909, 556);
            this.tabPageThongke.TabIndex = 0;
            // 
            // tpMonHoc
            // 
            this.tpMonHoc.Controls.Add(this.dgvMonHoc);
            this.tpMonHoc.Controls.Add(this.btnTim_MonHoc);
            this.tpMonHoc.Controls.Add(this.cbKhoa_MonHoc);
            this.tpMonHoc.Controls.Add(this.label2);
            this.tpMonHoc.Controls.Add(this.label1);
            this.tpMonHoc.Location = new System.Drawing.Point(4, 25);
            this.tpMonHoc.Name = "tpMonHoc";
            this.tpMonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMonHoc.Size = new System.Drawing.Size(901, 527);
            this.tpMonHoc.TabIndex = 0;
            this.tpMonHoc.Text = "Môn học";
            this.tpMonHoc.UseVisualStyleBackColor = true;
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 107);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(901, 420);
            this.dgvMonHoc.TabIndex = 4;
            // 
            // btnTim_MonHoc
            // 
            this.btnTim_MonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim_MonHoc.Location = new System.Drawing.Point(750, 54);
            this.btnTim_MonHoc.Name = "btnTim_MonHoc";
            this.btnTim_MonHoc.Size = new System.Drawing.Size(110, 24);
            this.btnTim_MonHoc.TabIndex = 3;
            this.btnTim_MonHoc.Text = "Tìm kiếm";
            this.btnTim_MonHoc.UseVisualStyleBackColor = true;
            this.btnTim_MonHoc.Click += new System.EventHandler(this.btnTim_MonHoc_Click);
            // 
            // cbKhoa_MonHoc
            // 
            this.cbKhoa_MonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhoa_MonHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKhoa_MonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhoa_MonHoc.FormattingEnabled = true;
            this.cbKhoa_MonHoc.Location = new System.Drawing.Point(141, 54);
            this.cbKhoa_MonHoc.MaxDropDownItems = 3;
            this.cbKhoa_MonHoc.Name = "cbKhoa_MonHoc";
            this.cbKhoa_MonHoc.Size = new System.Drawing.Size(573, 24);
            this.cbKhoa_MonHoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn khoa";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách môn học theo khoa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpGiangVien
            // 
            this.tpGiangVien.Controls.Add(this.btnTimKiem_GiangVien);
            this.tpGiangVien.Controls.Add(this.cbKhoa_GiangVien);
            this.tpGiangVien.Controls.Add(this.label3);
            this.tpGiangVien.Controls.Add(this.label4);
            this.tpGiangVien.Controls.Add(this.dgvGiangVien);
            this.tpGiangVien.Location = new System.Drawing.Point(4, 25);
            this.tpGiangVien.Name = "tpGiangVien";
            this.tpGiangVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpGiangVien.Size = new System.Drawing.Size(901, 527);
            this.tpGiangVien.TabIndex = 1;
            this.tpGiangVien.Text = "Giảng viên";
            this.tpGiangVien.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem_GiangVien
            // 
            this.btnTimKiem_GiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem_GiangVien.Location = new System.Drawing.Point(750, 55);
            this.btnTimKiem_GiangVien.Name = "btnTimKiem_GiangVien";
            this.btnTimKiem_GiangVien.Size = new System.Drawing.Size(110, 24);
            this.btnTimKiem_GiangVien.TabIndex = 9;
            this.btnTimKiem_GiangVien.Text = "Tìm kiếm";
            this.btnTimKiem_GiangVien.UseVisualStyleBackColor = true;
            this.btnTimKiem_GiangVien.Click += new System.EventHandler(this.btnTimKiem_GiangVien_Click);
            // 
            // cbKhoa_GiangVien
            // 
            this.cbKhoa_GiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhoa_GiangVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKhoa_GiangVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhoa_GiangVien.FormattingEnabled = true;
            this.cbKhoa_GiangVien.Location = new System.Drawing.Point(142, 55);
            this.cbKhoa_GiangVien.Name = "cbKhoa_GiangVien";
            this.cbKhoa_GiangVien.Size = new System.Drawing.Size(569, 24);
            this.cbKhoa_GiangVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn khoa";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(901, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh sách giảng viên theo khoa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AllowUserToAddRows = false;
            this.dgvGiangVien.AllowUserToDeleteRows = false;
            this.dgvGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 107);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(901, 420);
            this.dgvGiangVien.TabIndex = 5;
            // 
            // tpSinhVien
            // 
            this.tpSinhVien.Controls.Add(this.btnChiTiet);
            this.tpSinhVien.Controls.Add(this.btnClear);
            this.tpSinhVien.Controls.Add(this.btnTimKiem);
            this.tpSinhVien.Controls.Add(this.dgvSinhVien);
            this.tpSinhVien.Controls.Add(this.label5);
            this.tpSinhVien.Controls.Add(this.tableLayoutPanel1);
            this.tpSinhVien.Location = new System.Drawing.Point(4, 25);
            this.tpSinhVien.Name = "tpSinhVien";
            this.tpSinhVien.Size = new System.Drawing.Size(901, 527);
            this.tpSinhVien.TabIndex = 2;
            this.tpSinhVien.Text = "Sinh viên";
            this.tpSinhVien.UseVisualStyleBackColor = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(11, 201);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(164, 34);
            this.btnChiTiet.TabIndex = 9;
            this.btnChiTiet.Text = "Chi tiết sinh viên";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(636, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(756, 201);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 34);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 241);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(901, 286);
            this.dgvSinhVien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(901, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thống kê sinh viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.rbNu);
            this.panel1.Controls.Add(this.rbNam);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 138);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(80, 99);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(315, 23);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(156, 70);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 2;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(83, 69);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(55, 20);
            this.rbNam.TabIndex = 2;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Location = new System.Drawing.Point(83, 37);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(312, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSV.Location = new System.Drawing.Point(83, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(312, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã SV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày sinh";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbLop_SinhVien);
            this.panel2.Controls.Add(this.cbKhoa_SinhVien);
            this.panel2.Controls.Add(this.txtNoiSinh);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(453, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 138);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(3, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 37);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.27189F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.82028F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35945F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.34562F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.59036F));
            this.tableLayoutPanel2.Controls.Add(this.rbXS, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbG, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbK, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbTB, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbY, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 37);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // rbXS
            // 
            this.rbXS.AutoSize = true;
            this.rbXS.Location = new System.Drawing.Point(3, 3);
            this.rbXS.Name = "rbXS";
            this.rbXS.Size = new System.Drawing.Size(85, 20);
            this.rbXS.TabIndex = 0;
            this.rbXS.TabStop = true;
            this.rbXS.Text = "Xuất sắc";
            this.rbXS.UseVisualStyleBackColor = true;
            // 
            // rbG
            // 
            this.rbG.AutoSize = true;
            this.rbG.Location = new System.Drawing.Point(106, 3);
            this.rbG.Name = "rbG";
            this.rbG.Size = new System.Drawing.Size(50, 20);
            this.rbG.TabIndex = 0;
            this.rbG.TabStop = true;
            this.rbG.Text = "Giỏi";
            this.rbG.UseVisualStyleBackColor = true;
            // 
            // rbK
            // 
            this.rbK.AutoSize = true;
            this.rbK.Location = new System.Drawing.Point(180, 3);
            this.rbK.Name = "rbK";
            this.rbK.Size = new System.Drawing.Size(52, 20);
            this.rbK.TabIndex = 0;
            this.rbK.TabStop = true;
            this.rbK.Text = "Khá";
            this.rbK.UseVisualStyleBackColor = true;
            // 
            // rbTB
            // 
            this.rbTB.AutoSize = true;
            this.rbTB.Location = new System.Drawing.Point(252, 3);
            this.rbTB.Name = "rbTB";
            this.rbTB.Size = new System.Drawing.Size(96, 20);
            this.rbTB.TabIndex = 0;
            this.rbTB.TabStop = true;
            this.rbTB.Text = "Trung bình";
            this.rbTB.UseVisualStyleBackColor = true;
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.Location = new System.Drawing.Point(364, 3);
            this.rbY.Name = "rbY";
            this.rbY.Size = new System.Drawing.Size(53, 20);
            this.rbY.TabIndex = 0;
            this.rbY.TabStop = true;
            this.rbY.Text = "Yếu";
            this.rbY.UseVisualStyleBackColor = true;
            // 
            // cbLop_SinhVien
            // 
            this.cbLop_SinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLop_SinhVien.FormattingEnabled = true;
            this.cbLop_SinhVien.Location = new System.Drawing.Point(78, 68);
            this.cbLop_SinhVien.Name = "cbLop_SinhVien";
            this.cbLop_SinhVien.Size = new System.Drawing.Size(312, 24);
            this.cbLop_SinhVien.TabIndex = 2;
            // 
            // cbKhoa_SinhVien
            // 
            this.cbKhoa_SinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhoa_SinhVien.FormattingEnabled = true;
            this.cbKhoa_SinhVien.Location = new System.Drawing.Point(78, 37);
            this.cbKhoa_SinhVien.Name = "cbKhoa_SinhVien";
            this.cbKhoa_SinhVien.Size = new System.Drawing.Size(312, 24);
            this.cbKhoa_SinhVien.TabIndex = 2;
            this.cbKhoa_SinhVien.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SinhVien_SelectedIndexChanged);
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiSinh.Location = new System.Drawing.Point(78, 4);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(312, 23);
            this.txtNoiSinh.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Khoa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nơi sinh";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Location = new System.Drawing.Point(754, 557);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Về trang chủ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 593);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabPageThongke);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongKe_FormClosing);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tabPageThongke.ResumeLayout(false);
            this.tpMonHoc.ResumeLayout(false);
            this.tpMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.tpGiangVien.ResumeLayout(false);
            this.tpGiangVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.tpSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageThongke;
        private System.Windows.Forms.TabPage tpMonHoc;
        private System.Windows.Forms.TabPage tpGiangVien;
        private System.Windows.Forms.TabPage tpSinhVien;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Button btnTim_MonHoc;
        private System.Windows.Forms.ComboBox cbKhoa_MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem_GiangVien;
        private System.Windows.Forms.ComboBox cbKhoa_GiangVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbLop_SinhVien;
        private System.Windows.Forms.ComboBox cbKhoa_SinhVien;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbXS;
        private System.Windows.Forms.RadioButton rbG;
        private System.Windows.Forms.RadioButton rbK;
        private System.Windows.Forms.RadioButton rbTB;
        private System.Windows.Forms.RadioButton rbY;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnChiTiet;
    }
}