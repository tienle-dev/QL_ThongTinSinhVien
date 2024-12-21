using DAL;
using DTO;
using System;
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
            // Lấy toàn bộ danh sách ngành từ cơ sở dữ liệu
            var results = _db.GetAllNganhs();

            // Nếu mã ngành có giá trị, lọc kết quả theo mã ngành (không phân biệt chữ hoa/thường)
            if (!string.IsNullOrWhiteSpace(manganh))
            {
                results = results.FindAll(n => n.maNganh.IndexOf(manganh, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Nếu tên ngành có giá trị, lọc kết quả theo tên ngành (không phân biệt chữ hoa/thường)
            if (!string.IsNullOrWhiteSpace(tennganh))
            {
                results = results.FindAll(n => n.tenNganh.IndexOf(tennganh, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Nếu khoaId có giá trị, lọc kết quả theo khoaId
            if (!string.IsNullOrWhiteSpace(khoaId))
            {
                results = results.FindAll(n => string.Equals(n.maKhoa, khoaId, StringComparison.OrdinalIgnoreCase));
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
