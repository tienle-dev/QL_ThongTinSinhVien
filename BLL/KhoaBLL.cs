using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class KhoaBLL
    {
        private readonly Database _db;

        public KhoaBLL()
        {
            _db = new Database();
        }

        // Lấy danh sách các khoa
        public List<Khoa> GetKhoas() => _db.GetKhoas();

        // Thêm khoa mới
        public void AddKhoa(Khoa khoa) => _db.AddKhoa(khoa);

        // Cập nhật khoa
        public void UpdateKhoa(Khoa khoa) => _db.UpdateKhoa(khoa);

        // Xóa khoa
        public void DeleteKhoa(string maKhoa) => _db.DeleteKhoa(maKhoa);
        // Tìm kiếm khoa theo mã khoa hoặc tên khoa
        public List<Khoa> SearchKhoas(string searchTerm)
        {
            return _db.SearchKhoas(searchTerm);  // Gọi phương thức tìm kiếm từ lớp Database
        }
    }
}
