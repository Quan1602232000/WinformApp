﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien5ToT.DTO;
using QuanLySinhVien5ToT.BLL;
using System.Reflection;
using QuanLySinhVien5ToT.Services;

namespace QuanLySinhVien5ToT
{
    public partial class THAMGIA_CT : UserControl
    {
        public THAMGIA_CT()
        {
            InitializeComponent();
        }
        int pagenumber = 1;
        int numberRecord = 8;
        private int flagLuu = 0;
        private int flagDT = 0;
        DT_QL_SV5TOT_5Entities2 db = Mydb.GetInstance();
        ThamGia_CT_BLL thamGia_CT_BLL = new ThamGia_CT_BLL();
        List<ThongTinPQ_DTO> listPQ_SV = Login.listPQ;
        private void THAMGIA_CT_Load(object sender, EventArgs e)
        {
            loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
            loadcbFillterTG();
            loadcbThoiGian_TS();
            loadcbThoiGian_Xem();
            loadcbFillterDV();
            loadcbGiai_TS();
            loadcbFillterCT();
            loadcbCT_TS();
            TXTSEARCH();
            SuggestTxtMssv();
            maxlength();
            loadPQ();
        }
        void loadPQ()
        {
            if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
            {
                cbFillter_DV.Enabled = false;
                dtgv_TT.ReadOnly = true;
                cbFillter_DV.Text = listPQ_SV.Select(x => x.DonVi).ToArray().First().ToString();

            }
            else
            {
                cbFillter_DV.Enabled = true;
                dtgv_TT.ReadOnly = true;
            }
        }       
        void loadtgct (List<ThanGia_ChuongtrinhDTO> listtgct)
        {
            dtgv_TT.DataSource = listtgct;
            flagDT = 0;
        }
        private void btnThemTT_Click(object sender, EventArgs e)
        {
            editbtnThem();
            flagLuu = 0;           
            txtMssv_TS.Text = "";
            cbTenCT_TS.FillColor = Color.White;
            cbThoiGian_TS.FillColor = Color.White;
            txtMssv_TS.FillColor = Color.White;

            txtMssv_TS.BorderColor = Color.FromArgb(213, 218, 223);
            txtMssv_TS.PlaceholderText = "";
        }
        
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgv_TT.Rows[e.RowIndex];
            string name = dtgv_TT.Columns[e.ColumnIndex].Name;
            if (name == "Sua")
            {
                if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
                {
                    if (row.Cells["DonVi"].Value.ToString() == listPQ_SV.Select(x => x.DonVi).ToArray().First())
                    {
                        editbtnSua();
                        flagLuu = 1; 
                    }
                    else
                    {
                        MessageBox.Show("bạn không được quyền sửa");
                    }
                }
                else
                {
                    editbtnSua();
                }               
            }
            if (name == "Xem")
            {
                editbtnXem();
                txtTenSV_Xem.FillColor= Color.FromArgb(226, 226, 226);
                txtDonVi_Xem.FillColor= Color.FromArgb(226, 226, 226);
                txtTenCT_Xem.FillColor= Color.FromArgb(226, 226, 226);
                cbThoiGian_Xem.FillColor= Color.FromArgb(226, 226, 226);
                txtGiai_Xem.FillColor= Color.FromArgb(226, 226, 226);
            }
           
            txtMssv_TS.Text = row.Cells["Mssv"].Value.ToString();
            cbTenCT_TS.Text= row.Cells["TenChuongTrinh"].Value.ToString();
            cbGiai_TS.Text= row.Cells["Giai"].Value.ToString();
            cbThoiGian_TS.SelectedValue = thamGia_CT_BLL.GetIdFormattedDateTime(row.Cells["ThoiGian"].Value.ToString());

            txtTenSV_Xem.Text= row.Cells["TenSinhVien"].Value.ToString();
            txtTenCT_Xem.Text = row.Cells["TenChuongTrinh"].Value.ToString();
            txtDonVi_Xem.Text = row.Cells["DonVi"].Value.ToString();
            txtGiai_Xem.Text = row.Cells["Giai"].Value.ToString();
            cbThoiGian_Xem.SelectedValue = thamGia_CT_BLL.GetIdFormattedDateTime(row.Cells["ThoiGian"].Value.ToString());            
        }
        void editbtnThem()
        {
            pn_Sort.Visible = false;
            pn_Xem.Visible = false;
            pn_ThemTT.Visible = true;
            btnLuuTT.Visible = true;
            txtMssv_TS.Enabled = true;
            cbTenCT_TS.Enabled = true;
            cbThoiGian_TS.Enabled = true;
        }
        void editbtnSua()
        {
            pn_Sort.Visible = false;
            pn_Xem.Visible = false;
            pn_ThemTT.Visible = true;
            btnLuuTT.Visible = true;
            txtMssv_TS.Enabled = false;
            cbTenCT_TS.Enabled = false;
            cbThoiGian_TS.Enabled = false;

            cbTenCT_TS.FillColor = Color.FromArgb(226, 226, 226);
            cbThoiGian_TS.FillColor = Color.FromArgb(226, 226, 226);
            txtMssv_TS.FillColor = Color.FromArgb(226, 226, 226);

            txtMssv_TS.BorderColor = Color.FromArgb(213, 218, 223);
            txtMssv_TS.PlaceholderText = "";
        }
        void editbtnXem()
        {
            pn_Sort.Visible = false;
            pn_ThemTT.Visible = false;
            pn_Xem.Visible = true;
            btnLuuTT.Visible = false;
            btnX_Xem.Enabled = true;
            txtTenSV_Xem.Enabled = false;
            txtTenCT_Xem.Enabled = false;
            txtDonVi_Xem.Enabled = false;
            cbThoiGian_Xem.Enabled = false;
            txtGiai_Xem.Enabled = false;
        }
        private void btnXTT_Click(object sender, EventArgs e)
        {
            pn_Sort.Visible = true;
            pn_ThemTT.Visible = false;
            btnLuuTT.Visible = false;
            pn_Xem.Visible = false;
        }
        void loadbtnluu()
        {
            pn_Sort.Visible = true;
            pn_ThemTT.Visible = false;
            btnLuuTT.Visible = false;
            pn_Xem.Visible = false;
        }
        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (txtMssv_TS.TextLength<=11)
            {
                //txtMssv_TS.BorderColor = Color.Red;
                //txtMssv_TS.PlaceholderText = "bạn chưa nhập Mssv";
                //txtMssv_TS.PlaceholderForeColor = Color.Red;
                txtMssv_TS_Leave(sender, e);
            }
            else
            {                
                if (flagLuu == 0)
                {
                    THAMGIA_CHUONGTRINH tgct = thamGia_CT_BLL.Get(x => x.Mssv.Trim() == txtMssv_TS.Text.Trim() && x.MaChuongTrinh == Convert.ToInt32(cbTenCT_TS.SelectedValue.ToString()) && x.MaThoiGian == Convert.ToInt32(cbThoiGian_TS.SelectedValue.ToString()));
                    if (tgct == null)
                    {
                        tgct = new THAMGIA_CHUONGTRINH();
                        tgct.Mssv = txtMssv_TS.Text;
                        tgct.MaChuongTrinh = Convert.ToInt32(cbTenCT_TS.SelectedValue.ToString());
                        tgct.Giai = Convert.ToInt32(cbGiai_TS.SelectedValue);
                        tgct.MaThoiGian = Convert.ToInt32(cbThoiGian_TS.SelectedValue.ToString());
                        thamGia_CT_BLL.Add(tgct);
                        MessageBox.Show("Lưu Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                        loadbtnluu();
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đã bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThemTT_Click(sender, e);
                    }                                       
                }
                else
                {
                    try
                    {
                        THAMGIA_CHUONGTRINH tgct = thamGia_CT_BLL.Get(x => x.Mssv.Trim() == txtMssv_TS.Text.Trim() && x.MaChuongTrinh == Convert.ToInt32(cbTenCT_TS.SelectedValue.ToString()) && x.MaThoiGian == Convert.ToInt32(cbThoiGian_TS.SelectedValue.ToString()));
                        tgct.Giai = Convert.ToInt32(cbGiai_TS.SelectedValue);
                        thamGia_CT_BLL.Edit(tgct);
                        MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                        loadbtnluu();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            

        }

        private void btnX_Xem_Click(object sender, EventArgs e)
        {
            pn_Sort.Visible = true;
            pn_ThemTT.Visible = false;
            btnLuuTT.Visible = false;
            pn_Xem.Visible = false;
        }
        void loadcbFillterTG()
        {
            cbFillterThoiGian.DataSource = new BindingSource(thamGia_CT_BLL.showTime(), null);
            cbFillterThoiGian.DisplayMember = "Value";
            cbFillterThoiGian.ValueMember = "Key";
        }
        void loadcbThoiGian_TS()
        {
            cbThoiGian_TS.DataSource = new BindingSource(thamGia_CT_BLL.showTime(), null);
            cbThoiGian_TS.DisplayMember = "Value";
            cbThoiGian_TS.ValueMember = "Key";
        }
        void loadcbThoiGian_Xem()
        {
            cbThoiGian_Xem.DataSource = new BindingSource(thamGia_CT_BLL.showTime(), null);
            cbThoiGian_Xem.DisplayMember = "Value";
            cbThoiGian_Xem.ValueMember = "Key";
        }
        void loadcbFillterDV()
        {
            cbFillter_DV.DataSource = thamGia_CT_BLL.dsdonvi();
            cbFillter_DV.DisplayMember = "MaDonVi";
            cbFillter_DV.ValueMember = "MaDonVi";
        }
        void loadcbGiai_TS()
        {
            cbGiai_TS.DataSource = new BindingSource(thamGia_CT_BLL.ShowGiai(), null);
            cbGiai_TS.DisplayMember = "Value";
            cbGiai_TS.ValueMember = "Key";
        }
        void loadcbFillterCT()
        {
            cbFillterTenCT.DataSource = thamGia_CT_BLL.dschuongtrinh();
            cbFillterTenCT.DisplayMember = "TenChuongTrinh";
            cbFillterTenCT.ValueMember = "MaChuongTrinh";
        }
        void loadcbCT_TS()
        {
            cbTenCT_TS.DataSource = thamGia_CT_BLL.dschuongtrinh();
            cbTenCT_TS.DisplayMember = "TenChuongTrinh";
            cbTenCT_TS.ValueMember = "MaChuongTrinh";
        }

        private void txtMssv_TS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập kí tự số !!!");
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (flagDT == 0)
            {
                if(pagenumber - 1 > 0)
                {
                    pagenumber--;
                    loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            if (flagDT == 1)
            {
                if (pagenumber - 1 > 0)
                {
                    pagenumber--;
                    var listfillter = new List<ThanGia_ChuongtrinhDTO>();
                    listfillter = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.DonVi.Contains(cbFillter_DV.Text) && x.TenChuongTrinh.Contains(cbFillterTenCT.Text) && x.ThoiGian.Contains(cbFillterThoiGian.Text)).ToList();
                    dtgv_TT.DataSource = listfillter.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            if (flagDT == 2)
            {
                if (pagenumber - 1 > 0)
                {
                    pagenumber--;
                    var listsearch = new List<ThanGia_ChuongtrinhDTO>();
                    listsearch = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.TenSinhVien.Contains(txtSearch.Text)).ToList();
                    dtgv_TT.DataSource = listsearch.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (flagDT == 0)
            {
                int totlalrecord = 0;
                totlalrecord = db.THAMGIA_CHUONGTRINH.Count();
                if (pagenumber - 1 < totlalrecord / numberRecord)
                {
                    pagenumber++;
                    loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            if (flagDT == 1)
            {
                int totlalrecord = 0;
                totlalrecord = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.DonVi.Contains(cbFillter_DV.Text) && x.TenChuongTrinh.Contains(cbFillterTenCT.Text) && x.ThoiGian.Contains(cbFillterThoiGian.Text)).Count();
                if (pagenumber - 1 < totlalrecord / numberRecord)
                {
                    pagenumber++;
                    var listfillter = new List<ThanGia_ChuongtrinhDTO>();
                    listfillter = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.DonVi.Contains(cbFillter_DV.Text) && x.TenChuongTrinh.Contains(cbFillterTenCT.Text) && x.ThoiGian.Contains(cbFillterThoiGian.Text)).ToList();
                    dtgv_TT.DataSource = listfillter.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
            if (flagDT == 2)
            {
                int totlalrecord = 0;
                totlalrecord = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.TenSinhVien.Contains(txtSearch.Text)).Count();
                if (pagenumber - 1 < totlalrecord / numberRecord)
                {
                    pagenumber++;
                    var listsearch = new List<ThanGia_ChuongtrinhDTO>();
                    listsearch = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.TenSinhVien.Contains(txtSearch.Text)).ToList();
                    dtgv_TT.DataSource = listsearch.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                    int Number = pagenumber;
                    lbNumber.Text = Number.ToString();
                }
            }
        
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            var listfillter = new List<ThanGia_ChuongtrinhDTO>();
            listfillter = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.DonVi.Contains(cbFillter_DV.Text) && x.TenChuongTrinh.Contains(cbFillterTenCT.Text) && x.ThoiGian.Contains(cbFillterThoiGian.Text)).ToList();
            dtgv_TT.DataSource = listfillter.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
            flagDT = 1;          
            lbNumber.Text = pagenumber.ToString();
            if (dtgv_TT.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                loadtgct(thamGia_CT_BLL.dsthamgiaCT().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
                flagDT = 0;
            }
            else
            {
                var listsearch = new List<ThanGia_ChuongtrinhDTO>();
                listsearch = thamGia_CT_BLL.dsthamgiaCT().Where(x => x.TenSinhVien.Contains(txtSearch.Text.Trim())).ToList();
                dtgv_TT.DataSource = listsearch.Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList();
                flagDT = 2;
                pagenumber = 1;
                lbNumber.Text = pagenumber.ToString();
            }            
        }
        void TXTSEARCH()
        {
            if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
            {
                txtSearch.AutoCompleteCustomSource.AddRange(thamGia_CT_BLL.dssinhvien().Where(x => x.DonVi == cbFillter_DV.Text).Select(x => x.HoTen).ToArray());
            }
            else
            {
                txtSearch.AutoCompleteCustomSource.AddRange(thamGia_CT_BLL.dssinhvien().Select(x => x.HoTen).ToArray());
            }
            
        }
        void SuggestTxtMssv()
        {
            if (listPQ_SV.Select(x => x.Role).ToArray().First() == "admin")
            {
                txtMssv_TS.AutoCompleteCustomSource.AddRange(thamGia_CT_BLL.dssinhvien().Where(x=>x.DonVi==listPQ_SV.Select(y=>y.DonVi).ToArray().First()).Select(x => x.Mssv).ToArray());
            }
            else
            {
                txtMssv_TS.AutoCompleteCustomSource.AddRange(thamGia_CT_BLL.dssinhvien().Select(x => x.Mssv).ToArray());
            }
                
        }

        private void txtMssv_TS_Leave(object sender, EventArgs e)
        {
            thamGia_CT_BLL.check_input_mssv(txtMssv_TS);
        }
        void maxlength()
        {
            txtMssv_TS.MaxLength = 11;
        }
    }
    
}
