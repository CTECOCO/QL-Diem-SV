namespace QuanLySinhVien.GUI
{
    partial class MonHoc
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Monhoc = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotiet = new System.Windows.Forms.TextBox();
            this.btnMonKhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Monhoc
            // 
            this.dgv_Monhoc.AllowUserToAddRows = false;
            this.dgv_Monhoc.AllowUserToDeleteRows = false;
            this.dgv_Monhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Monhoc.Location = new System.Drawing.Point(20, 128);
            this.dgv_Monhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Monhoc.Name = "dgv_Monhoc";
            this.dgv_Monhoc.ReadOnly = true;
            this.dgv_Monhoc.RowHeadersWidth = 62;
            this.dgv_Monhoc.RowTemplate.Height = 28;
            this.dgv_Monhoc.Size = new System.Drawing.Size(690, 250);
            this.dgv_Monhoc.TabIndex = 11;
            this.dgv_Monhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Monhoc_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(635, 35);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 47);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(535, 35);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 47);
            this.btnSua.TabIndex = 13;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(436, 35);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 47);
            this.btnThem.TabIndex = 12;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMH.BackColor = System.Drawing.Color.White;
            this.txtTenMH.Location = new System.Drawing.Point(138, 62);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.ReadOnly = true;
            this.txtTenMH.Size = new System.Drawing.Size(270, 23);
            this.txtTenMH.TabIndex = 10;
            this.txtTenMH.TabStop = false;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaMH.BackColor = System.Drawing.Color.White;
            this.txtMaMH.Location = new System.Drawing.Point(138, 35);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(270, 23);
            this.txtMaMH.TabIndex = 9;
            this.txtMaMH.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã môn học";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Location = new System.Drawing.Point(568, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 32);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Về trang chủ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số tín chỉ";
            // 
            // txtSotiet
            // 
            this.txtSotiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSotiet.BackColor = System.Drawing.Color.White;
            this.txtSotiet.Location = new System.Drawing.Point(138, 89);
            this.txtSotiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.ReadOnly = true;
            this.txtSotiet.Size = new System.Drawing.Size(270, 23);
            this.txtSotiet.TabIndex = 10;
            this.txtSotiet.TabStop = false;
            // 
            // btnMonKhoa
            // 
            this.btnMonKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonKhoa.Location = new System.Drawing.Point(436, 86);
            this.btnMonKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonKhoa.Name = "btnMonKhoa";
            this.btnMonKhoa.Size = new System.Drawing.Size(272, 38);
            this.btnMonKhoa.TabIndex = 12;
            this.btnMonKhoa.TabStop = false;
            this.btnMonKhoa.Text = "Thêm môn của khoa";
            this.btnMonKhoa.UseVisualStyleBackColor = true;
            this.btnMonKhoa.Click += new System.EventHandler(this.btnMonKhoa_Click);
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(731, 424);
            this.Controls.Add(this.dgv_Monhoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnMonKhoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSotiet);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonHoc_FormClosing);
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Monhoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSotiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMonKhoa;
    }
}