namespace QuanLySinhVien
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuSep1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuQuanLySinhVien = new ToolStripMenuItem();
            mnuQuanLySanPham = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuSep2 = new ToolStripSeparator();
            toolStrip = new ToolStrip();
            tsbSinhVien = new ToolStripButton();
            tsbSanPham = new ToolStripButton();
            tsSep1 = new ToolStripSeparator();
            tsbCascade = new ToolStripButton();
            tsbTileHorizontal = new ToolStripButton();
            tsbTileVertical = new ToolStripButton();
            tsSep2 = new ToolStripSeparator();
            tsbDangXuat = new ToolStripButton();
            tsbThoat = new ToolStripButton();
            statusStrip = new StatusStrip();
            lblNguoiDung = new ToolStripStatusLabel();
            lblThongBao = new ToolStripStatusLabel();
            lblPhanTram = new ToolStripStatusLabel();
            prgTienTrinh = new ToolStripProgressBar();
            lblThoiGian = new ToolStripStatusLabel();
            cmsMain = new ContextMenuStrip(components);
            cmsCascade = new ToolStripMenuItem();
            cmsTileHorizontal = new ToolStripMenuItem();
            cmsTileVertical = new ToolStripMenuItem();
            cmsSep1 = new ToolStripSeparator();
            cmsDongTatCa = new ToolStripMenuItem();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            cmsMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuCuaSo });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = mnuCuaSo;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1371, 30);
            menuStrip.TabIndex = 0;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuSep1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(183, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuSep1
            // 
            mnuSep1.Name = "mnuSep1";
            mnuSep1.Size = new Size(180, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(183, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLySinhVien, mnuQuanLySanPham });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(90, 24);
            mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuQuanLySinhVien
            // 
            mnuQuanLySinhVien.Name = "mnuQuanLySinhVien";
            mnuQuanLySinhVien.ShortcutKeys = Keys.Control | Keys.D1;
            mnuQuanLySinhVien.Size = new Size(262, 26);
            mnuQuanLySinhVien.Text = "Quản lý Sinh viên";
            mnuQuanLySinhVien.Click += mnuQuanLySinhVien_Click;
            // 
            // mnuQuanLySanPham
            // 
            mnuQuanLySanPham.Name = "mnuQuanLySanPham";
            mnuQuanLySanPham.ShortcutKeys = Keys.Control | Keys.D2;
            mnuQuanLySanPham.Size = new Size(262, 26);
            mnuQuanLySanPham.Text = "Quản lý Sản phẩm";
            mnuQuanLySanPham.Click += mnuQuanLySanPham_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, mnuSep2 });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(68, 24);
            mnuCuaSo.Text = "&Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(190, 26);
            mnuCascade.Text = "Cascade";
            mnuCascade.Click += Cascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(190, 26);
            mnuTileHorizontal.Text = "Tile Horizontal";
            mnuTileHorizontal.Click += TileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(190, 26);
            mnuTileVertical.Text = "Tile Vertical";
            mnuTileVertical.Click += TileVertical_Click;
            // 
            // mnuSep2
            // 
            mnuSep2.Name = "mnuSep2";
            mnuSep2.Size = new Size(187, 6);
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbSinhVien, tsbSanPham, tsSep1, tsbCascade, tsbTileHorizontal, tsbTileVertical, tsSep2, tsbDangXuat, tsbThoat });
            toolStrip.Location = new Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1371, 27);
            toolStrip.TabIndex = 1;
            // 
            // tsbSinhVien
            // 
            tsbSinhVien.Name = "tsbSinhVien";
            tsbSinhVien.Size = new Size(72, 24);
            tsbSinhVien.Text = "Sinh viên";
            tsbSinhVien.ToolTipText = "Quản lý Sinh viên (Ctrl+1)";
            tsbSinhVien.Click += mnuQuanLySinhVien_Click;
            // 
            // tsbSanPham
            // 
            tsbSanPham.Name = "tsbSanPham";
            tsbSanPham.Size = new Size(79, 24);
            tsbSanPham.Text = "Sản phẩm";
            tsbSanPham.ToolTipText = "Quản lý Sản phẩm (Ctrl+2)";
            tsbSanPham.Click += mnuQuanLySanPham_Click;
            // 
            // tsSep1
            // 
            tsSep1.Name = "tsSep1";
            tsSep1.Size = new Size(6, 27);
            // 
            // tsbCascade
            // 
            tsbCascade.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCascade.Name = "tsbCascade";
            tsbCascade.Size = new Size(29, 24);
            tsbCascade.Text = "Cascade";
            tsbCascade.ToolTipText = "Xếp chồng (Cascade)";
            tsbCascade.Click += Cascade_Click;
            // 
            // tsbTileHorizontal
            // 
            tsbTileHorizontal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbTileHorizontal.Name = "tsbTileHorizontal";
            tsbTileHorizontal.Size = new Size(29, 24);
            tsbTileHorizontal.Text = "Tile Horizontal";
            tsbTileHorizontal.ToolTipText = "Xếp ngang (Tile Horizontal)";
            tsbTileHorizontal.Click += TileHorizontal_Click;
            // 
            // tsbTileVertical
            // 
            tsbTileVertical.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbTileVertical.Name = "tsbTileVertical";
            tsbTileVertical.Size = new Size(29, 24);
            tsbTileVertical.Text = "Tile Vertical";
            tsbTileVertical.ToolTipText = "Xếp dọc (Tile Vertical)";
            tsbTileVertical.Click += TileVertical_Click;
            // 
            // tsSep2
            // 
            tsSep2.Name = "tsSep2";
            tsSep2.Size = new Size(6, 27);
            // 
            // tsbDangXuat
            // 
            tsbDangXuat.Name = "tsbDangXuat";
            tsbDangXuat.Size = new Size(81, 24);
            tsbDangXuat.Text = "Đăng xuất";
            tsbDangXuat.Click += mnuDangXuat_Click;
            // 
            // tsbThoat
            // 
            tsbThoat.Name = "tsbThoat";
            tsbThoat.Size = new Size(51, 24);
            tsbThoat.Text = "Thoát";
            tsbThoat.Click += mnuThoat_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblNguoiDung, lblThongBao, lblPhanTram, prgTienTrinh, lblThoiGian });
            statusStrip.Location = new Point(0, 970);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1371, 30);
            statusStrip.TabIndex = 2;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNguoiDung.ForeColor = Color.FromArgb(0, 84, 166);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(123, 24);
            lblNguoiDung.Text = "Chưa đăng nhập";
            // 
            // lblThongBao
            // 
            lblThongBao.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(1176, 24);
            lblThongBao.Spring = true;
            lblThongBao.Text = "Sẵn sàng";
            lblThongBao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhanTram
            // 
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(29, 24);
            lblPhanTram.Text = "0%";
            lblPhanTram.Visible = false;
            // 
            // prgTienTrinh
            // 
            prgTienTrinh.Name = "prgTienTrinh";
            prgTienTrinh.Size = new Size(206, 22);
            prgTienTrinh.Visible = false;
            // 
            // lblThoiGian
            // 
            lblThoiGian.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(55, 24);
            lblThoiGian.Text = "--:--:--";
            // 
            // cmsMain
            // 
            cmsMain.ImageScalingSize = new Size(20, 20);
            cmsMain.Items.AddRange(new ToolStripItem[] { cmsCascade, cmsTileHorizontal, cmsTileVertical, cmsSep1, cmsDongTatCa });
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new Size(204, 106);
            // 
            // cmsCascade
            // 
            cmsCascade.Name = "cmsCascade";
            cmsCascade.Size = new Size(203, 24);
            cmsCascade.Text = "Cascade";
            cmsCascade.Click += Cascade_Click;
            // 
            // cmsTileHorizontal
            // 
            cmsTileHorizontal.Name = "cmsTileHorizontal";
            cmsTileHorizontal.Size = new Size(203, 24);
            cmsTileHorizontal.Text = "Tile Horizontal";
            cmsTileHorizontal.Click += TileHorizontal_Click;
            // 
            // cmsTileVertical
            // 
            cmsTileVertical.Name = "cmsTileVertical";
            cmsTileVertical.Size = new Size(203, 24);
            cmsTileVertical.Text = "Tile Vertical";
            cmsTileVertical.Click += TileVertical_Click;
            // 
            // cmsSep1
            // 
            cmsSep1.Name = "cmsSep1";
            cmsSep1.Size = new Size(200, 6);
            // 
            // cmsDongTatCa
            // 
            cmsDongTatCa.Name = "cmsDongTatCa";
            cmsDongTatCa.Size = new Size(203, 24);
            cmsDongTatCa.Text = "Đóng tất cả cửa sổ";
            cmsDongTatCa.Click += cmsDongTatCa_Click;
            // 
            // tmrDongHo
            // 
            tmrDongHo.Enabled = true;
            tmrDongHo.Interval = 1000;
            tmrDongHo.Tick += tmrDongHo_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 1000);
            ContextMenuStrip = cmsMain;
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            cmsMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripSeparator mnuSep1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuQuanLySinhVien;
        private ToolStripMenuItem mnuQuanLySanPham;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripSeparator mnuSep2;
        private ToolStrip toolStrip;
        private ToolStripButton tsbSinhVien;
        private ToolStripButton tsbSanPham;
        private ToolStripSeparator tsSep1;
        private ToolStripButton tsbCascade;
        private ToolStripButton tsbTileHorizontal;
        private ToolStripButton tsbTileVertical;
        private ToolStripSeparator tsSep2;
        private ToolStripButton tsbDangXuat;
        private ToolStripButton tsbThoat;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblNguoiDung;
        private ToolStripStatusLabel lblThongBao;
        private ToolStripStatusLabel lblPhanTram;
        private ToolStripProgressBar prgTienTrinh;
        private ToolStripStatusLabel lblThoiGian;
        private ContextMenuStrip cmsMain;
        private ToolStripMenuItem cmsCascade;
        private ToolStripMenuItem cmsTileHorizontal;
        private ToolStripMenuItem cmsTileVertical;
        private ToolStripSeparator cmsSep1;
        private ToolStripMenuItem cmsDongTatCa;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}
