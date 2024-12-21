using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonHocBLL
    {
        private readonly Database _db;

        public MonHocBLL()
        {
            _db = new Database();
        }

        // Môn học
        public List<MonHoc> GetMonHocs()
        {
            return _db.GetMonHocs();
        }

        public List<Khoa> GetKhoas()
        {
            return _db.GetKhoas();
        }

        public void AddMonHoc(MonHoc monHoc)
        {
            _db.AddMonHoc(monHoc);
        }

        public void UpdateMonHoc(MonHoc monHoc)
        {
            _db.UpdateMonHoc(monHoc);
        }

        public void DeleteMonHoc(string maMon)
        {
            _db.DeleteMonHoc(maMon);
        }

        public List<MonHoc> SearchMonHocs(string maMon,string tenMon, int? soTinChi, int? tietLyThuyet, int? tietThucHanh, string maKhoa, string hocKy)
        {
            return _db.SearchMonHocs(maMon,tenMon, soTinChi, tietLyThuyet, tietThucHanh, maKhoa, hocKy);
        }
    }
}
