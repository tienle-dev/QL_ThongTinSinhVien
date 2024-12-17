using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class NganhBLL
    {
        private readonly Database _db;

        public NganhBLL()
        {
            _db = new Database();
        }

        // Lấy danh sách ngành
        public List<Nganh> GetNganhs()
        {
            return _db.GetAllNganhs();
        }

        // Thêm ngành mới
        public void AddNganh(Nganh nganh)
        {
            _db.AddNganh(nganh);
        }

        // Cập nhật ngành
        public void UpdateNganh(Nganh nganh)
        {
            _db.UpdateNganh(nganh);
        }

        // Xóa ngành
        public void DeleteNganh(string maNganh)
        {
            _db.DeleteNganh(maNganh);
        }

        // Tìm kiếm ngành theo mã ngành, tên ngành hoặc khoaId
        public List<Nganh> SearchNganhs(string manganh, string tennganh, string khoaId)
        {
            // Tạo danh sách để chứa các kết quả tìm kiếm
            var results = _db.GetAllNganhs();

            // Nếu mã ngành có giá trị, lọc kết quả theo mã ngành
            if (!string.IsNullOrEmpty(manganh))
            {
                results = results.FindAll(n => n.maNganh.Contains(manganh));
            }

            // Nếu tên ngành có giá trị, lọc kết quả theo tên ngành
            if (!string.IsNullOrEmpty(tennganh))
            {
                results = results.FindAll(n => n.tenNganh.Contains(tennganh));
            }

            // Nếu khoaId có giá trị, lọc kết quả theo khoaId
            if (!string.IsNullOrEmpty(khoaId))
            {
                results = results.FindAll(n => n.maKhoa == khoaId);
            }

            return results;
        }

        // Lấy thông tin Khoa bằng khoaId
        public Khoa GetKhoaById(string khoaId)
        {
            return _db.GetKhoaById(khoaId);
        }

        // Lấy danh sách khoa (dùng trong ComboBox)
        public List<Khoa> GetKhoas() => _db.GetKhoas();
    }
}
