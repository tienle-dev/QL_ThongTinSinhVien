using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class GiangVienBLL
    {
        private readonly Database _db;

        public GiangVienBLL()
        {
            _db = new Database();
        }
        public List<GiangVien> GetGiangViens() => _db.GetGiangViens();

        public void AddGiangVien(GiangVien gv) => _db.AddGiangVien(gv);

        public void UpdateGiangVien(GiangVien gv) => _db.UpdateGiangVien(gv);

        public void DeleteGiangVien(string maGV) => _db.DeleteGiangVien(maGV);

        public List<GiangVien> SearchGiangViens(string searchTerm) => _db.SearchGiangViens(searchTerm);

        public List<Lop> GetLops() => _db.GetAllLops();
    }
}
