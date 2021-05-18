using System;
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

namespace QuanLySinhVien5ToT
{
    public partial class DsSV5TOT : UserControl
    {
        public DsSV5TOT()
        {
            InitializeComponent();
        }
        int pagenumber = 1;
        int numberRecord = 8;
        DsSV5TOT_BLL dsSV5TOT_BLL = new DsSV5TOT_BLL();
        private void DsSV5TOT_Load(object sender, EventArgs e)
        {
            dssinhvien(dsSV5TOT_BLL.dssinhvien().Skip((pagenumber - 1) * numberRecord).Take(numberRecord).ToList());
            loadcbFillterDV();
            loadcbFillter_Cap();
        }
        public void dssinhvien(List<Sinh_VienDTO> listsv)
        {
            dtgv_SV.DataSource = listsv;
        }
        void loadcbFillterDV()
        {
            cbFillter_DV.DataSource = dsSV5TOT_BLL.dsdonvi();
            cbFillter_DV.DisplayMember = "MaDonVi";
            cbFillter_DV.ValueMember = "MaDonVi";
        }
        void loadcbFillter_Cap()
        {
            cbFillter_Cap.DataSource = new BindingSource(dsSV5TOT_BLL.ShowDanhGia(), null);
            cbFillter_Cap.DisplayMember = "Value";
            cbFillter_Cap.ValueMember = "Key";
        }
    }
}
