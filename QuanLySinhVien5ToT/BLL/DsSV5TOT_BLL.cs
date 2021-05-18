using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien5ToT.DAL;
using QuanLySinhVien5ToT.DTO;

namespace QuanLySinhVien5ToT.BLL
{
    public class DsSV5TOT_BLL
    {
        private Sinh_VienDAL sinh_VienDAL = new Sinh_VienDAL();
        private Don_ViDAL don_ViDAL = new Don_ViDAL();
        private Dictionary<int, string> DicDanhGia;

        public List<Sinh_VienDTO> dssinhvien()
        {
            return sinh_VienDAL.Getdssinhvien();
        }
        public List<Don_ViDTO> dsdonvi()
        {
            return don_ViDAL.GetDonVi();
        }
        public Dictionary<int, string> ShowDanhGia()
        {
            DicDanhGia = new Dictionary<int, string>()
            {
                { 0,"Không Đạt"},{ 1,"Cấp Trường"},{ 2,"Cấp Khoa"}
            };
            return DicDanhGia;
        }
    }
}
