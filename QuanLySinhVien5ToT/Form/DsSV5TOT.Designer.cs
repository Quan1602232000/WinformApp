namespace QuanLySinhVien5ToT
{
    partial class DsSV5TOT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtgv_SV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFillter_Cap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFillter_DV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnprevious = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SV)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dtgv_SV;
            // 
            // dtgv_SV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_SV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_SV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_SV.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_SV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_SV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_SV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_SV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_SV.ColumnHeadersHeight = 40;
            this.dtgv_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mssv,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.NoiSinh,
            this.SDT,
            this.Lop,
            this.DonVi,
            this.Khoa,
            this.Email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_SV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_SV.EnableHeadersVisualStyles = false;
            this.dtgv_SV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_SV.Location = new System.Drawing.Point(14, 138);
            this.dtgv_SV.Name = "dtgv_SV";
            this.dtgv_SV.ReadOnly = true;
            this.dtgv_SV.RowHeadersVisible = false;
            this.dtgv_SV.RowTemplate.Height = 35;
            this.dtgv_SV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_SV.Size = new System.Drawing.Size(1017, 472);
            this.dtgv_SV.TabIndex = 41;
            this.dtgv_SV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_SV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_SV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_SV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_SV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_SV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_SV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_SV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_SV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgv_SV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_SV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_SV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_SV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_SV.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgv_SV.ThemeStyle.ReadOnly = true;
            this.dtgv_SV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_SV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_SV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_SV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_SV.ThemeStyle.RowsStyle.Height = 35;
            this.dtgv_SV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_SV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.cbFillter_Cap);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.cbFillter_DV);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(14, 61);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(873, 71);
            this.guna2Panel1.TabIndex = 28;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Image = global::QuanLySinhVien5ToT.Properties.Resources.icons8_search_96;
            this.btnTimKiem.Location = new System.Drawing.Point(666, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(180, 36);
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(329, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Đạt Cấp :";
            // 
            // cbFillter_Cap
            // 
            this.cbFillter_Cap.BackColor = System.Drawing.Color.Transparent;
            this.cbFillter_Cap.BorderRadius = 10;
            this.cbFillter_Cap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillter_Cap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillter_Cap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillter_Cap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillter_Cap.FocusedState.Parent = this.cbFillter_Cap;
            this.cbFillter_Cap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillter_Cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillter_Cap.HoverState.Parent = this.cbFillter_Cap;
            this.cbFillter_Cap.ItemHeight = 30;
            this.cbFillter_Cap.ItemsAppearance.Parent = this.cbFillter_Cap;
            this.cbFillter_Cap.Location = new System.Drawing.Point(388, 18);
            this.cbFillter_Cap.Name = "cbFillter_Cap";
            this.cbFillter_Cap.ShadowDecoration.Parent = this.cbFillter_Cap;
            this.cbFillter_Cap.Size = new System.Drawing.Size(237, 36);
            this.cbFillter_Cap.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đơn Vị :";
            // 
            // cbFillter_DV
            // 
            this.cbFillter_DV.BackColor = System.Drawing.Color.Transparent;
            this.cbFillter_DV.BorderRadius = 10;
            this.cbFillter_DV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillter_DV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillter_DV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillter_DV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillter_DV.FocusedState.Parent = this.cbFillter_DV;
            this.cbFillter_DV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillter_DV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillter_DV.HoverState.Parent = this.cbFillter_DV;
            this.cbFillter_DV.ItemHeight = 30;
            this.cbFillter_DV.ItemsAppearance.Parent = this.cbFillter_DV;
            this.cbFillter_DV.Location = new System.Drawing.Point(70, 18);
            this.cbFillter_DV.Name = "cbFillter_DV";
            this.cbFillter_DV.ShadowDecoration.Parent = this.cbFillter_DV;
            this.cbFillter_DV.Size = new System.Drawing.Size(237, 36);
            this.cbFillter_DV.TabIndex = 29;
            // 
            // Mssv
            // 
            this.Mssv.DataPropertyName = "Mssv";
            this.Mssv.HeaderText = "Mssv";
            this.Mssv.Name = "Mssv";
            this.Mssv.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi Sinh";
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khóa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.lbNumber);
            this.guna2Panel2.Controls.Add(this.btnprevious);
            this.guna2Panel2.Controls.Add(this.btnNext);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(437, 616);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(164, 42);
            this.guna2Panel2.TabIndex = 50;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.Gray;
            this.lbNumber.Location = new System.Drawing.Point(73, 9);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(18, 20);
            this.lbNumber.TabIndex = 50;
            this.lbNumber.Text = "1";
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.Transparent;
            this.btnprevious.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnprevious.CheckedState.Parent = this.btnprevious;
            this.btnprevious.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnprevious.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnprevious.HoverState.Parent = this.btnprevious;
            this.btnprevious.Image = global::QuanLySinhVien5ToT.Properties.Resources.icons8_double_right_80;
            this.btnprevious.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnprevious.ImageRotate = 0F;
            this.btnprevious.ImageSize = new System.Drawing.Size(20, 20);
            this.btnprevious.Location = new System.Drawing.Point(22, 4);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnprevious.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnprevious.PressedState.Parent = this.btnprevious;
            this.btnprevious.Size = new System.Drawing.Size(45, 35);
            this.btnprevious.TabIndex = 47;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = global::QuanLySinhVien5ToT.Properties.Resources.icons8_double_right_801;
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNext.Location = new System.Drawing.Point(97, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNext.PressedState.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(45, 35);
            this.btnNext.TabIndex = 48;
            // 
            // DsSV5TOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.dtgv_SV);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DsSV5TOT";
            this.Size = new System.Drawing.Size(1044, 661);
            this.Load += new System.EventHandler(this.DsSV5TOT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SV)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillter_Cap;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillter_DV;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbNumber;
        private Guna.UI2.WinForms.Guna2ImageButton btnprevious;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
    }
}
