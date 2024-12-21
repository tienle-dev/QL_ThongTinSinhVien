using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL {
    public class SinhVienBLL {
        private readonly Database _database;

        public SinhVienBLL() {
            _database = new Database();
        }

        public void AddSinhVien(SinhVien sinhVien) {
            _database.AddSinhVien(sinhVien);
        }

        public void UpdateSinhVien(string mssv, SinhVien sinhVien) {
            _database.UpdateSinhVien(mssv, sinhVien);
        }

        public void DeleteSinhVien(string mssv) {
            _database.DeleteSinhVien(mssv);
        }

        public List<SinhVien> GetAllSinhViens() {
            return _database.GetAllSinhViens();
        }
        public List<SinhVien> SearchSinhViens(SinhVienFilter filter) {
            var sinhViens = _database.GetAllSinhViens(); // Lấy tất cả sinh viên từ database

            // Áp dụng bộ lọc cho danh sách sinh viên
            if (!string.IsNullOrEmpty(filter.MSSV))
            {
                sinhViens = sinhViens.Where(sv => sv.MSSV.Contains(filter.MSSV)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.FullName))
            {
                sinhViens = sinhViens.Where(sv => sv.FullName.Contains(filter.FullName)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Email))
            {
                sinhViens = sinhViens.Where(sv => sv.Email.Contains(filter.Email)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.PhoneNum))
            {
                sinhViens = sinhViens.Where(sv => sv.PhoneNum.Contains(filter.PhoneNum)).ToList();
            }
            if (filter.BirthYear.HasValue)
            {
                sinhViens = sinhViens.Where(sv => sv.BirthYear == filter.BirthYear.Value).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Sex))
            {
                sinhViens = sinhViens.Where(sv => sv.Sex == filter.Sex).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Class))
            {
                sinhViens = sinhViens.Where(sv => sv.Class.Contains(filter.Class)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Major))
            {
                sinhViens = sinhViens.Where(sv => sv.Major.Contains(filter.Major)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Faculty))
            {
                sinhViens = sinhViens.Where(sv => sv.Faculty.Contains(filter.Faculty)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Session))
            {
                sinhViens = sinhViens.Where(sv => sv.Session.Contains(filter.Session)).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Advisor))
            {
                sinhViens = sinhViens.Where(sv => sv.Advisor.Contains(filter.Advisor)).ToList();
            }

            return sinhViens;
        }

    }
}
