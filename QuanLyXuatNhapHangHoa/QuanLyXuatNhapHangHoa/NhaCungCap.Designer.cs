namespace GUI
{
    partial class NhaCungCap
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
            this.dtgvThongTinNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtDienThoaiNCC = new System.Windows.Forms.TextBox();
            this.labelsde = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.labelsd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label232 = new System.Windows.Forms.Label();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinNhaCungCap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(348, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // dtgvThongTinNhaCungCap
            // 
            this.dtgvThongTinNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTinNhaCungCap.Location = new System.Drawing.Point(12, 413);
            this.dtgvThongTinNhaCungCap.Name = "dtgvThongTinNhaCungCap";
            this.dtgvThongTinNhaCungCap.RowHeadersWidth = 51;
            this.dtgvThongTinNhaCungCap.RowTemplate.Height = 24;
            this.dtgvThongTinNhaCungCap.Size = new System.Drawing.Size(1020, 353);
            this.dtgvThongTinNhaCungCap.TabIndex = 1;
            this.dtgvThongTinNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongTinNhaCungCap_CellClick);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNCC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSuaNCC.Location = new System.Drawing.Point(735, 330);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(104, 37);
            this.btnSuaNCC.TabIndex = 39;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoaNCC.Location = new System.Drawing.Point(503, 330);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(104, 37);
            this.btnXoaNCC.TabIndex = 38;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThemNCC.Location = new System.Drawing.Point(266, 330);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(104, 37);
            this.btnThemNCC.TabIndex = 37;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtDienThoaiNCC
            // 
            this.txtDienThoaiNCC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDienThoaiNCC.Location = new System.Drawing.Point(772, 202);
            this.txtDienThoaiNCC.Name = "txtDienThoaiNCC";
            this.txtDienThoaiNCC.Size = new System.Drawing.Size(214, 29);
            this.txtDienThoaiNCC.TabIndex = 36;
            // 
            // labelsde
            // 
            this.labelsde.AutoSize = true;
            this.labelsde.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelsde.Location = new System.Drawing.Point(627, 207);
            this.labelsde.Name = "labelsde";
            this.labelsde.Size = new System.Drawing.Size(112, 21);
            this.labelsde.TabIndex = 35;
            this.labelsde.Text = "Số điện thoại:";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(220, 204);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(214, 29);
            this.txtDiaChiNCC.TabIndex = 34;
            // 
            // labelsd
            // 
            this.labelsd.AutoSize = true;
            this.labelsd.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelsd.Location = new System.Drawing.Point(76, 209);
            this.labelsd.Name = "labelsd";
            this.labelsd.Size = new System.Drawing.Size(69, 21);
            this.labelsd.TabIndex = 33;
            this.labelsd.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(627, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMaNCC.Location = new System.Drawing.Point(220, 137);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(214, 29);
            this.txtMaNCC.TabIndex = 31;
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label232.Location = new System.Drawing.Point(76, 142);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(142, 21);
            this.label232.TabIndex = 30;
            this.label232.Text = "Mã nhà cung cấp:";
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(772, 134);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(214, 29);
            this.txtTenNhaCungCap.TabIndex = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 29);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHàngHóaToolStripMenuItem,
            this.xuấtHàngHóaToolStripMenuItem});
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(158, 25);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // nhậpHàngHóaToolStripMenuItem
            // 
            this.nhậpHàngHóaToolStripMenuItem.Name = "nhậpHàngHóaToolStripMenuItem";
            this.nhậpHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhậpHàngHóaToolStripMenuItem.Text = "Nhập sản phẩm";
            this.nhậpHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngHóaToolStripMenuItem_Click);
            // 
            // xuấtHàngHóaToolStripMenuItem
            // 
            this.xuấtHàngHóaToolStripMenuItem.Name = "xuấtHàngHóaToolStripMenuItem";
            this.xuấtHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xuấtHàngHóaToolStripMenuItem.Text = "Xuất sản phẩm";
            this.xuấtHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.xuấtHàngHóaToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpSảnPhẩmToolStripMenuItem,
            this.xuấtSảnPhẩmToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // nhậpSảnPhẩmToolStripMenuItem
            // 
            this.nhậpSảnPhẩmToolStripMenuItem.Name = "nhậpSảnPhẩmToolStripMenuItem";
            this.nhậpSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.nhậpSảnPhẩmToolStripMenuItem.Text = "Nhập sản phẩm";
            // 
            // xuấtSảnPhẩmToolStripMenuItem
            // 
            this.xuấtSảnPhẩmToolStripMenuItem.Name = "xuấtSảnPhẩmToolStripMenuItem";
            this.xuấtSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.xuấtSảnPhẩmToolStripMenuItem.Text = "Xuất sản phẩm";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhàCungCấpToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            this.quảnLýNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàCungCấpToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 778);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.btnSuaNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.txtDienThoaiNCC);
            this.Controls.Add(this.labelsde);
            this.Controls.Add(this.txtDiaChiNCC);
            this.Controls.Add(this.labelsd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label232);
            this.Controls.Add(this.dtgvThongTinNhaCungCap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCungCap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhaCungCap_FormClosing);
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinNhaCungCap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvThongTinNhaCungCap;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.TextBox txtDienThoaiNCC;
        private System.Windows.Forms.Label labelsde;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Label labelsd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}