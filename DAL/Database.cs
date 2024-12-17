using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DAL
{
    public class Database
    {
        private readonly IMongoDatabase _database;

        public Database()
        {
            var client = new MongoClient("mongodb+srv://tienle:pass123@cluster0.y6jck.mongodb.net/");
            _database = client.GetDatabase("QL_Thongtinsinhvien");
        }

        public IMongoCollection<Admin> Admins => _database.GetCollection<Admin>("Admin");
        public IMongoCollection<Lop> Lops => _database.GetCollection<Lop>("Lop");
        public IMongoCollection<Nganh> Nganhs => _database.GetCollection<Nganh>("Nganh");
        public IMongoCollection<MonHoc> MonHocCollection => _database.GetCollection<MonHoc>("MonHoc");
        public IMongoCollection<Khoa> KhoaCollection => _database.GetCollection<Khoa>("Khoa");

        // Admin authentication
        public bool AuthenticateAdmin(string username, string password)
        {
            var admin = Admins.Find(a => a.tenAd == username && a.matKhau == password).FirstOrDefault();
            return admin != null;
        }

        // ---------------------------------
        // Lớp
        // CRUD operations for Lop
        public List<Lop> GetAllLops() => Lops.Find(_ => true).ToList();

        public void AddLop(Lop lop) => Lops.InsertOne(lop);

        public void UpdateLop(Lop lop)
        {
            var update = Builders<Lop>.Update
                .Set(l => l.tenLop, lop.tenLop)
                .Set(l => l.nganhId, lop.nganhId);

            var filter = Builders<Lop>.Filter.Eq(m => m.MaLop, lop.MaLop);
            Lops.UpdateOne(filter, update);
        }

        public void DeleteLop(string maLop)
        {
            Lops.DeleteOne(l => l.MaLop == maLop);
        }

        public List<Lop> SearchLops(string tenLop, string idNganh)
        {
            var filter = Builders<Lop>.Filter.Empty;
            if (!string.IsNullOrEmpty(tenLop))
                filter &= Builders<Lop>.Filter.Eq(l => l.tenLop, tenLop);
            if (!string.IsNullOrEmpty(idNganh))
                filter &= Builders<Lop>.Filter.Eq(l => l.nganhId, idNganh);

            return Lops.Find(filter).ToList();
        }

        // Fetch departments for ComboBox
        public List<Nganh> GetAllNganhs() => Nganhs.Find(_ => true).ToList();
        // ---------------------------------



        // ---------------------------------
        // Môn học
        // Lấy tất cả môn học
        public List<MonHoc> GetMonHocs()
        {
            return MonHocCollection.Find(new BsonDocument()).ToList();
        }

        // Lấy tất cả khoa
        public List<Khoa> GetKhoas()
        {
            return KhoaCollection.Find(new BsonDocument()).ToList();
        }

        // Thêm môn học
        public void AddMonHoc(MonHoc monHoc)
        {
            MonHocCollection.InsertOne(monHoc);
        }

        // Cập nhật môn học
        public void UpdateMonHoc(MonHoc monHoc)
        {
            var update = Builders<MonHoc>.Update
                .Set(m => m.tenMon, monHoc.tenMon)
                .Set(m => m.soTinChi, monHoc.soTinChi)
                .Set(m => m.tietLT, monHoc.tietLT)
                .Set(m => m.tietTH, monHoc.tietTH)
                .Set(m => m.khoaId, monHoc.khoaId);

            var filter = Builders<MonHoc>.Filter.Eq(m => m.MaMon, monHoc.MaMon);
            MonHocCollection.UpdateOne(filter, update);
        }

        // Xóa môn học
        public void DeleteMonHoc(string maMon)
        {
            var filter = Builders<MonHoc>.Filter.Eq(m => m.MaMon, maMon);
            MonHocCollection.DeleteOne(filter);
        }

        // Tìm kiếm môn học
        public List<MonHoc> SearchMonHocs(string tenMon, int? soTinChi, int? tietLyThuyet, int? tietThucHanh, string maKhoa)
        {
            var filter = Builders<MonHoc>.Filter.Empty;

            if (!string.IsNullOrEmpty(tenMon))
                filter &= Builders<MonHoc>.Filter.Regex(m => m.tenMon, new BsonRegularExpression(tenMon, "i"));
            if (soTinChi.HasValue)
                filter &= Builders<MonHoc>.Filter.Eq(m => m.soTinChi, soTinChi.Value);
            if (tietLyThuyet.HasValue)
                filter &= Builders<MonHoc>.Filter.Eq(m => m.tietLT, tietLyThuyet.Value);
            if (tietThucHanh.HasValue)
                filter &= Builders<MonHoc>.Filter.Eq(m => m.tietTH, tietThucHanh.Value);
            if (!string.IsNullOrEmpty(maKhoa))
                filter &= Builders<MonHoc>.Filter.Eq(m => m.khoaId, maKhoa);

            return MonHocCollection.Find(filter).ToList();
        }

        // ---------------------------------
    }
}
