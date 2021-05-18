﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien5ToT.BLL;
using System.Data.Entity.Core.Metadata.Edm;
using QuanLySinhVien5ToT.DTO;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLySinhVien5ToT
{
    public partial class THONGTIN_SINHVIEN : UserControl
    {
        public THONGTIN_SINHVIEN()
        {
            InitializeComponent();
        }
        int pagenumber = 1;
        int numberRecord = 8;
        private int flagLuu = 0;
        private int flagDT = 0;
        DT_QL_SV5TOT_5Entities2 db = Mydb.GetInstance();
        SinhVienBLL sinhVienBLL = new SinhVienBLL();
        //User_RoleBLL user_RoleBLL = new User_RoleBLL();
        List<ThongTinPQ_DTO> listPQ_SV = Login.listPQ;
        private void THONGTIN_SINHVIEN_Load(object sender, EventArgs e)
        {
            
            ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
            loadcbFillterDonVi();
            loadcbFillterKhoa();
            loadtxtFillter();
            loadcbGioiTinh();
            loadcbKhoa();
            loadcbDonVi();
            TXTSEARCH();
            loadcbRole();
            maxlength();
            loadPQ();
            //var listadmin = listPQ_SV.Select(x => x.Role).ToArray().First();           
        }
        void loadPQ()
        {
            if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
            {
                cbFillter_DonVi.Enabled = false;                
                dtgv_SV.ReadOnly = true;
                cbFillter_DonVi.Text = listPQ_SV.Select(x => x.DonVi).ToArray().First().ToString();
                
            }
            else
            {
                cbFillter_DonVi.Enabled = true;                
                dtgv_SV.ReadOnly = true;
            }
        }
        void loadbtnPQ()
        {
            if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
            {
                cbDonVi.Enabled = false;
                cbDonVi.Text = listPQ_SV.Select(x => x.DonVi).ToArray().First().ToString();
            }
            else
            {
                cbDonVi.Enabled = true;
            }
        }
        void ShowSinhVien(List<Sinh_VienDTO> listsv)
        {
            dtgv_SV.DataSource = listsv;
            flagDT = 0;
        }

        private void btnThemKQ_Click(object sender, EventArgs e)
        {
            clearThemUser();
            editbtnThem();
            dtgv_SV.Height = 442;
            dtgv_SV.Location = new Point(14, 166);
            btnThemKQ.Location = new Point(867, 116);
                        

            txtUserName.BorderColor = Color.FromArgb(213, 218, 223);
            txtUserName.PlaceholderText = "";

            txtPassword.BorderColor = Color.FromArgb(213, 218, 223);
            txtPassword.PlaceholderText = "";

            txtXacNhanMK.BorderColor = Color.FromArgb(213, 218, 223);
            txtXacNhanMK.PlaceholderText = "";

            //MessageBox.Show("Bạn phải tạo tài khoản trước");
        }
        void editbtnThem()
        {
            pn_Sort.Visible = false;
            pn_ThemSua.Visible = false;
            pn_ThemTaiKhoan.Visible = true;
            btnLuuSV.Visible = false;
            cbRole.Enabled = false; 
        }
        void editbtnTiepTheo()
        {
            pn_Sort.Visible = false;
            pn_ThemSua.Visible = true;
            pn_ThemTaiKhoan.Visible = false;
            btnLuuSV.Visible = true;
            txtMssv.Enabled = true;
            txtHoTen.Enabled = true;
            dtpkNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            cbGioiTinh.Enabled = true;
            cbKhoa.Enabled = true;
            cbDonVi.Enabled = true;
            txtLop.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
        }
        void editbtnxem()
        {
            pn_Sort.Visible = false;
            pn_ThemSua.Visible = true;
            btnLuuSV.Visible = false;
            btnThemKQ.Enabled = false;
            txtMssv.Enabled = false;
            txtHoTen.Enabled = false;
            dtpkNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            cbGioiTinh.Enabled = false;
            cbKhoa.Enabled = false;
            cbDonVi.Enabled = false;
            txtLop.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
        }
        void editbtnsua()
        {
            pn_Sort.Visible = false;
            pn_ThemSua.Visible = true;
            pn_ThemTaiKhoan.Visible = false;
            btnLuuSV.Visible = true;
            pn_ThemSua.Enabled = true;
            txtMssv.Enabled = false;
            txtHoTen.Enabled = true;
            dtpkNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            cbGioiTinh.Enabled = true;
            cbKhoa.Enabled = true;
            cbDonVi.Enabled = true;
            txtLop.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
        }
        void clearThemUser()
        {
            txtXacNhanMK.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        void clearThemSV()
        {
            txtMssv.Text = "";
            txtHoTen.Text = "";
            txtNoiSinh.Text = "";
            txtLop.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }
        void designbtnSua()
        {
            txtMssv.BorderColor = Color.FromArgb(213, 218, 223);
            txtMssv.PlaceholderText = "";
            txtHoTen.BorderColor = Color.FromArgb(213, 218, 223);
            txtHoTen.PlaceholderText = "";
            txtNoiSinh.BorderColor = Color.FromArgb(213, 218, 223);
            txtNoiSinh.PlaceholderText = "";
            txtEmail.BorderColor = Color.FromArgb(213, 218, 223);
            txtEmail.PlaceholderText = "";
            txtSDT.BorderColor = Color.FromArgb(213, 218, 223);
            txtSDT.PlaceholderText = "";
            txtLop.BorderColor = Color.FromArgb(213, 218, 223);
            txtLop.PlaceholderText = "";
        }
        
        void loadbtnSua()
        {
            flagLuu = 1;
            dtgv_SV.Height = 385;
            dtgv_SV.Location = new Point(14, 223);
            btnThemKQ.Location = new Point(867, 172);
            editbtnsua();
            maxlength();
            designbtnSua();
            bindingSV();
        }
        private void dtgv_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dtgv_SV.Columns[e.ColumnIndex].Name;
            if (name == "Xem")
            {
                editbtnxem();
                bindingSV();               
            }
            if (name == "Sua")
            {
                DataGridViewRow row = this.dtgv_SV.Rows[e.RowIndex];
                if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
                {
                    if (row.Cells["DonVi"].Value.ToString() == listPQ_SV.Select(x => x.DonVi).ToArray().First())
                    {
                        loadbtnSua();
                        cbDonVi.Enabled = false;
                        cbDonVi.Text = listPQ_SV.Select(x => x.DonVi).ToArray().First().ToString();
                    }
                    else
                    {
                        pn_ThemSua.Visible = false;
                        pn_Sort.Visible = true;
                        MessageBox.Show("bạn không được quyền sửa");
                    }
                }
                else
                {
                    loadbtnSua();
                }
                
            }
            if (name == "Xoa")
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //try
                    //{

                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    var getmssv = dtgv_SV["Mssv", e.RowIndex].Value.ToString();
                    SINH_VIEN sv = Mydb.GetInstance().SINH_VIEN.Where(p => p.Mssv == getmssv).SingleOrDefault();
                    USER user = Mydb.GetInstance().USERs.Where(p => p.IDuser == sv.IDuser).SingleOrDefault();
                    //DIEM diem = Mydb.GetInstance().DIEMs.Where(p => p.Mssv == sv.Mssv).SingleOrDefault();
                    //THAMGIA_CHUONGTRINH TGCT = Mydb.GetInstance().THAMGIA_CHUONGTRINH.Where(p => p.Mssv == sv.Mssv).SingleOrDefault();
                    //THUCHIEN_TIEUCHUAN THTC = Mydb.GetInstance().THUCHIEN_TIEUCHUAN.Where(p => p.Mssv == sv.Mssv).SingleOrDefault();
                    //THOIDIEM_SV_THAMGIA TDSV = Mydb.GetInstance().THOIDIEM_SV_THAMGIA.Where(p => p.Mssv == sv.Mssv).SingleOrDefault();
                    //KQ_THEO_TIEUCHI KQ = Mydb.GetInstance().KQ_THEO_TIEUCHI.Where(p => p.Mssv == sv.Mssv).SingleOrDefault();


                    Mydb.GetInstance().USERs.Remove(user);
                    Mydb.GetInstance().DIEMs.Remove(Mydb.GetInstance().DIEMs.Single(p=>p.Mssv==getmssv));
                    Mydb.GetInstance().THAMGIA_CHUONGTRINH.Remove(Mydb.GetInstance().THAMGIA_CHUONGTRINH.Single(p => p.Mssv == getmssv));
                    Mydb.GetInstance().THUCHIEN_TIEUCHUAN.Remove(Mydb.GetInstance().THUCHIEN_TIEUCHUAN.Single(p => p.Mssv == getmssv));
                    Mydb.GetInstance().THOIDIEM_SV_THAMGIA.Remove(Mydb.GetInstance().THOIDIEM_SV_THAMGIA.Single(p => p.Mssv == getmssv));
                    Mydb.GetInstance().KQ_THEO_TIEUCHI.Remove(Mydb.GetInstance().KQ_THEO_TIEUCHI.Single(p => p.Mssv == getmssv));
                    sinhVienBLL.Delete(sv);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("sinh viên vẫn được giữ nguyên");
                }
                ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
            }
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            if (txtMssv.Text == "" || txtHoTen.Text == "" || txtNoiSinh.Text == "" || txtLop.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
            {
                if (string.IsNullOrEmpty(txtMssv.Text.Trim()))
                {
                    txtMssv.BorderColor = Color.Red;
                    txtMssv.PlaceholderText = "bạn chưa nhập mssv";
                    txtMssv.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
                {
                    txtHoTen.BorderColor = Color.Red;
                    txtHoTen.PlaceholderText = "bạn chưa nhập họ tên";
                    txtHoTen.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtNoiSinh.Text.Trim()))
                {
                    txtNoiSinh.BorderColor = Color.Red;
                    txtNoiSinh.PlaceholderText = "bạn chưa nhập nơi sinh";
                    txtNoiSinh.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtLop.Text.Trim()))
                {
                    txtLop.BorderColor = Color.Red;
                    txtLop.PlaceholderText = "bạn chưa nhập lớp";
                    txtLop.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
                {
                    txtSDT.BorderColor = Color.Red;
                    txtSDT.PlaceholderText = "bạn chưa nhập SDT";
                    txtSDT.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    txtEmail.BorderColor = Color.Red;
                    txtEmail.PlaceholderText = "bạn chưa nhập Email";
                    txtEmail.PlaceholderForeColor = Color.Red;
                }                
            }
            else
            {               
                if (flagLuu == 0)
                {
                    SINH_VIEN sinhvien = sinhVienBLL.Get(x => x.Mssv.Trim() == txtMssv.Text.Trim());
                    if (sinhvien == null)
                    {
                        sinhvien = new SINH_VIEN();
                        sinhvien.Mssv = txtMssv.Text;
                        sinhvien.HoTen = txtHoTen.Text;
                        sinhvien.NgaySinh = dtpkNgaySinh.Value;
                        sinhvien.GioiTinh = cbGioiTinh.Text;
                        sinhvien.NoiSinh = txtNoiSinh.Text;
                        sinhvien.SDT = txtSDT.Text;
                        sinhvien.Lop = txtLop.Text;
                        sinhvien.DonVi = cbDonVi.Text;
                        sinhvien.Khoa = cbKhoa.Text;
                        sinhvien.Email = txtEmail.Text;
                        List<USER> us = db.USERs.ToList();
                        int iduser = us.Last().IDuser;
                        sinhvien.IDuser = iduser;

                        sinhVienBLL.Add(sinhvien);
                        MessageBox.Show("Thêm Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                        pn_Sort.Visible = true;
                        pn_ThemSua.Visible = false;
                        btnLuuSV.Visible = false;
                        btnThemKQ.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Mssv không được trùng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadntnTT();
                    }                   
                }
                else
                {
                    try
                    {
                        SINH_VIEN sv = sinhVienBLL.Get(x => x.Mssv.Trim() == txtMssv.Text.Trim());
                        sv.HoTen = txtHoTen.Text;
                        sv.NgaySinh = dtpkNgaySinh.Value;
                        sv.GioiTinh = cbGioiTinh.Text;
                        sv.NoiSinh = txtNoiSinh.Text;
                        sv.SDT = txtSDT.Text;
                        sv.Lop = txtLop.Text;
                        sv.DonVi = cbDonVi.Text;
                        sv.Khoa = cbKhoa.Text;
                        sv.Email = txtEmail.Text;

                        sinhVienBLL.Edit(sv);
                        MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                        pn_Sort.Visible = true;
                        pn_ThemSua.Visible = false;
                        btnLuuSV.Visible = false;
                        btnThemKQ.Enabled = true;

                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadntnTT();
                    }                
                }
            }
        }

        private void btnXThemSV_Click(object sender, EventArgs e)
        {
            pn_Sort.Visible = true;
            pn_ThemSua.Visible = false;
            btnLuuSV.Visible = false;
            btnThemKQ.Enabled = true;
            ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
        }


        void loadcbGioiTinh()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Text = "Nam";
        }
        void loadcbKhoa()
        {
            cbKhoa.Items.Clear();
            cbKhoa.Items.Add("K40");
            cbKhoa.Items.Add("K41");
            cbKhoa.Items.Add("K42");
            cbKhoa.Items.Add("K43");
            cbKhoa.Items.Add("K44");
            cbKhoa.Items.Add("K45");
            cbKhoa.Items.Add("K46");
            cbKhoa.Text = "K44";
        }
        void loadcbDonVi()
        {
            cbDonVi.DataSource = sinhVienBLL.dsDonVi();
            cbDonVi.DisplayMember = "MaDonVi";
            cbDonVi.ValueMember = "MaDonVi";
        }
        void loadcbFillterDonVi()
        {
            cbFillter_DonVi.DataSource = sinhVienBLL.GetAlDonVi();
            cbFillter_DonVi.DisplayMember = "MaDonVi";
            cbFillter_DonVi.ValueMember = "MaDonVi";
            //cbFillter_DonVi.SelectedItem = null;
            
        }
        void loadcbFillterKhoa()
        {
            //cbFillter_Khoa.Items.Clear();
            cbFillter_Khoa.Items.Add("K40");
            cbFillter_Khoa.Items.Add("K41");
            cbFillter_Khoa.Items.Add("K42");
            cbFillter_Khoa.Items.Add("K43");
            cbFillter_Khoa.Items.Add("K44");
            cbFillter_Khoa.Items.Add("K45");
            cbFillter_Khoa.Items.Add("K46");
            cbFillter_Khoa.SelectedItem = null;
            cbFillter_Khoa.Text = "K44";
        }
        void loadcbRole()
        {
            cbRole.DataSource = sinhVienBLL.dsrole();
            cbRole.DisplayMember = "Role";
            cbRole.ValueMember = "IDrole";
            cbRole.Text = "user";
        }
        void loadtxtFillter()
        {
            txtFillterLop.Text = "EC001";
        }
        void bindingSV()
        {
            txtMssv.DataBindings.Clear();
            txtMssv.DataBindings.Add("Text", dtgv_SV.DataSource, "Mssv");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dtgv_SV.DataSource, "HoTen");
            dtpkNgaySinh.DataBindings.Clear();
            dtpkNgaySinh.DataBindings.Add("Text", dtgv_SV.DataSource, "NgaySinh");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dtgv_SV.DataSource, "GioiTinh");
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", dtgv_SV.DataSource, "NoiSinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dtgv_SV.DataSource, "SDT");
            txtLop.DataBindings.Clear();
            txtLop.DataBindings.Add("Text", dtgv_SV.DataSource, "Lop");
            cbDonVi.DataBindings.Clear();
            cbDonVi.DataBindings.Add("Text", dtgv_SV.DataSource, "DonVi");
            cbKhoa.DataBindings.Clear();
            cbKhoa.DataBindings.Add("Text", dtgv_SV.DataSource, "Khoa");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgv_SV.DataSource, "Email");
        }

        private void txtSaerch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSaerch.Text.Trim()))
            {
                ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                flagDT = 0;
            }
            else
            {
                var listsearch = new List<Sinh_VienDTO>();
                listsearch = sinhVienBLL.DsSinhVien().Where(x => x.HoTen.Contains(txtSaerch.Text.Trim())).ToList();
                dtgv_SV.DataSource = listsearch.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                pagenumber = 1;
                lbNumber.Text = pagenumber.ToString();

            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            var listFIllter = new List<Sinh_VienDTO>();
            listFIllter= sinhVienBLL.DsSinhVien().Where(x => x.DonVi.Contains(cbFillter_DonVi.Text) && x.Lop.Contains(txtFillterLop.Text) && x.Khoa.Contains(cbFillter_Khoa.Text)).ToList();
            dtgv_SV.DataSource = listFIllter.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
            flagDT = 1;          
            lbNumber.Text = pagenumber.ToString();
            if (dtgv_SV.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (flagDT == 0)
            {
                int totlalrecord = 0;
                totlalrecord = db.SINH_VIEN.Count();
                if (pagenumber - 1 < totlalrecord / numberRecord)
                {
                    pagenumber++;
                    ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            if (flagDT == 1)
            {
                int totlalrecord = 0;
                totlalrecord = sinhVienBLL.DsSinhVien().Where(x => x.DonVi.Contains(cbFillter_DonVi.Text) && x.Lop.Contains(txtFillterLop.Text) && x.Khoa.Contains(cbFillter_Khoa.Text)).Count();
                if (pagenumber - 1 < totlalrecord / numberRecord)
                {
                    pagenumber++;
                    var listFIllter = new List<Sinh_VienDTO>();
                    listFIllter = sinhVienBLL.DsSinhVien().Where(x => x.DonVi.Contains(cbFillter_DonVi.Text) && x.Lop.Contains(txtFillterLop.Text) && x.Khoa.Contains(cbFillter_Khoa.Text)).ToList();
                    dtgv_SV.DataSource = listFIllter.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (flagDT == 0)
            {
                if (pagenumber - 1 > 0)
                {
                    pagenumber--;
                    ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            if (flagDT == 1)
            {
                if (pagenumber - 1 > 0)
                {
                    pagenumber--;
                    var listFIllter = new List<Sinh_VienDTO>();
                    listFIllter = sinhVienBLL.DsSinhVien().Where(x => x.DonVi.Contains(cbFillter_DonVi.Text) && x.Lop.Contains(txtFillterLop.Text) && x.Khoa.Contains(cbFillter_Khoa.Text)).ToList();
                    dtgv_SV.DataSource = listFIllter.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }            
        }
        void maxlength()
        {
            txtMssv.MaxLength = 11;
            txtSDT.MaxLength = 10;
            txtHoTen.MaxLength = 50;
            txtNoiSinh.MaxLength = 100;
            txtLop.MaxLength = 100;
            txtEmail.MaxLength = 50;
            txtUserName.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }
        private void txtMssv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập kí tự số !!!");
            }

        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập kí tự số !!!");
            }
        }
        void TXTSEARCH()
        {
            if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
            {
                txtSaerch.AutoCompleteCustomSource.AddRange(sinhVienBLL.DsSinhVien().Where(x=>x.DonVi==cbFillter_DonVi.Text).Select(x => x.HoTen).ToArray());
            }
            else
            {
                txtSaerch.AutoCompleteCustomSource.AddRange(sinhVienBLL.DsSinhVien().Select(x => x.HoTen).ToArray());
            }               
        }

        void loadntnTT()
        {
            dtgv_SV.Height = 385;
            dtgv_SV.Location = new Point(14, 223);
            btnThemKQ.Location = new Point(867, 172);
            editbtnTiepTheo();
            clearThemSV();
            designbtnSua();
            loadbtnPQ(); 
        }
        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="" || txtPassword.Text == "" || txtXacNhanMK.Text=="")
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    txtUserName.BorderColor = Color.Red;
                    txtUserName.PlaceholderText = "bạn chưa nhập username";
                    txtUserName.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    txtPassword.BorderColor = Color.Red;
                    txtPassword.PlaceholderText = "bạn chưa nhập password";
                    txtPassword.PlaceholderForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtXacNhanMK.Text.Trim()))
                {
                    txtXacNhanMK.BorderColor = Color.Red;
                    txtXacNhanMK.PlaceholderText = "bạn chưa xác nhận password";
                    txtXacNhanMK.PlaceholderForeColor = Color.Red;
                }
            }
            else
            {                
                string UserName =sinhVienBLL.Mahoa(txtUserName.Text);
                string password =sinhVienBLL.Mahoa(txtPassword.Text);
                USER us = sinhVienBLL.GetUser(x => x.Username.Trim()== UserName.Trim()||x.Password.Trim()== password.Trim());
                if (us == null)
                {                  
                    if (txtPassword.Text == txtXacNhanMK.Text)
                    {
                        us = new USER();
                        us.Username = txtUserName.Text;
                        us.Password = sinhVienBLL.Mahoa(txtPassword.Text);
                        us.IDrole = Convert.ToInt32(cbRole.SelectedValue.ToString());
                        sinhVienBLL.AddUser(us);
                        MessageBox.Show("Thêm User Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadntnTT();
                    }
                    else
                    {
                        //pn_Sort.Visible = false;
                        //pn_ThemSua.Visible = false;
                        //pn_ThemTaiKhoan.Visible = true;
                        //btnLuuSV.Visible = false;                       
                        //dtgv_SV.Height = 442;
                        //dtgv_SV.Location = new Point(14, 166);
                        //btnThemKQ.Location = new Point(867, 116);
                        //cbRole.Enabled = false;
                        btnThemKQ_Click(sender, e);
                        MessageBox.Show("Xác nhận mật khẩu không đúng!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtXacNhanMK.Text = "";
                    }                   
                }
                else
                {
                    MessageBox.Show("Username hoặc password của bạn đã bị trùng!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThemKQ_Click(sender, e);
                }
                 
            }
            
        }
        

        private void btnXUser_Click(object sender, EventArgs e)
        {
            pn_Sort.Visible = true;
            pn_ThemSua.Visible = false;
            pn_ThemTaiKhoan.Visible = false;
            dtgv_SV.Height = 385;
            dtgv_SV.Location = new Point(14,223);
            btnThemKQ.Location = new Point(867, 172);
            btnLuuSV.Visible = false;
            btnThemKQ.Enabled = true;
            ShowSinhVien(sinhVienBLL.DsSinhVien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMssv_Leave(object sender, EventArgs e)
        {
            if (txtMssv.TextLength < 11)
            {
                txtMssv.Text = "";
                txtMssv.BorderColor = Color.Red;
                txtMssv.PlaceholderText = "chưa nhập đủ 11 kí tự";
                txtMssv.PlaceholderForeColor = Color.Red;
            }
            else
            {
                txtMssv.BorderColor = Color.FromArgb(226, 226, 226);
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.TextLength < 10 || txtSDT.TextLength > 10)
            {               
                txtSDT.Text = "";
                txtSDT.BorderColor = Color.Red;
                txtSDT.PlaceholderText = "SDT phải đủ 10 số";
                txtSDT.PlaceholderForeColor = Color.Red;
            }
            else
            {
                txtSDT.BorderColor = Color.FromArgb(226, 226, 226);
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                txtUserName.BorderColor = Color.Red;
            else
                txtUserName.BorderColor = Color.FromArgb(226, 226, 226);

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                txtPassword.BorderColor = Color.Red;
            else
                txtPassword.BorderColor = Color.FromArgb(226, 226, 226);
        }

        private void txtXacNhanMK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXacNhanMK.Text.Trim()))
                txtXacNhanMK.BorderColor = Color.Red;
            else
                txtXacNhanMK.BorderColor = Color.FromArgb(226, 226, 226);
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
                txtHoTen.BorderColor = Color.Red;
            else
                txtHoTen.BorderColor = Color.FromArgb(226, 226, 226);
        }

        private void txtNoiSinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiSinh.Text.Trim()))
                txtNoiSinh.BorderColor = Color.Red;
            else
                txtNoiSinh.BorderColor = Color.FromArgb(226, 226, 226);
        }

        private void txtLop_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLop.Text.Trim()))
                txtLop.BorderColor = Color.Red;
            else
                txtLop.BorderColor = Color.FromArgb(226, 226, 226);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                txtEmail.BorderColor = Color.Red;
            else
                txtEmail.BorderColor = Color.FromArgb(226, 226, 226);
        }
    }
}

