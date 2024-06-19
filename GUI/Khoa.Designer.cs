namespace QuanLySinhVien.GUI
{
    partial class Khoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.dgv_Khoa = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKhoa.BackColor = System.Drawing.Color.White;
            this.txtMaKhoa.Location = new System.Drawing.Point(101, 18);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(261, 23);
            this.txtMaKhoa.TabIndex = 1;
            this.txtMaKhoa.TabStop = false;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKhoa.BackColor = System.Drawing.Color.White;
            this.txtTenKhoa.Location = new System.Drawing.Point(101, 45);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.ReadOnly = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(261, 23);
            this.txtTenKhoa.TabIndex = 2;
            this.txtTenKhoa.TabStop = false;
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhoa.Location = new System.Drawing.Point(390, 18);
            this.btnThemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(75, 47);
            this.btnThemKhoa.TabIndex = 3;
            this.btnThemKhoa.TabStop = false;
            this.btnThemKhoa.Text = "&Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaKhoa.Location = new System.Drawing.Point(489, 18);
            this.btnSuaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(75, 47);
            this.btnSuaKhoa.TabIndex = 4;
            this.btnSuaKhoa.TabStop = false;
            this.btnSuaKhoa.Text = "&Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKhoa.Location = new System.Drawing.Point(589, 18);
            this.btnXoaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(75, 47);
            this.btnXoaKhoa.TabIndex = 5;
            this.btnXoaKhoa.TabStop = false;
            this.btnXoaKhoa.Text = "&Xoá";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // dgv_Khoa
            // 
            this.dgv_Khoa.AllowUserToAddRows = false;
            this.dgv_Khoa.AllowUserToDeleteRows = false;
            this.dgv_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Khoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa.Location = new System.Drawing.Point(11, 86);
            this.dgv_Khoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Khoa.Name = "dgv_Khoa";
            this.dgv_Khoa.ReadOnly = true;
            this.dgv_Khoa.RowHeadersWidth = 62;
            this.dgv_Khoa.RowTemplate.Height = 28;
            this.dgv_Khoa.Size = new System.Drawing.Size(653, 295);
            this.dgv_Khoa.TabIndex = 3;
            this.dgv_Khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Khoa_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Location = new System.Drawing.Point(522, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Về trang chủ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 430);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgv_Khoa);
            this.Controls.Add(this.btnXoaKhoa);
            this.Controls.Add(this.btnSuaKhoa);
            this.Controls.Add(this.btnThemKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Khoa_FormClosing);
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.DataGridView dgv_Khoa;
        private System.Windows.Forms.Button btnThoat;
    }
}