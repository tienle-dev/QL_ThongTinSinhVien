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
        public IMongoCollection<GiangVien> GiangVienCollection => _database.GetCollection<GiangVien>("GiangVien");

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



      
        // CRUD for SinhVien
        public IMongoCollection<SinhVien> SinhViens => _database.GetCollection<SinhVien>("SinhVien");

        // Thêm sinh viên
        public void AddSinhVien(SinhVien sinhVien) {
            SinhViens.InsertOne(sinhVien);
        }

        // Cập nhật thông tin sinh viên
        public void UpdateSinhVien(string mssv, SinhVien updatedSinhVien) {
            var filter = Builders<SinhVien>.Filter.Eq(sv => sv.MSSV, mssv);

            var update = Builders<SinhVien>.Update
                .Set(sv => sv.FullName, updatedSinhVien.FullName)
                .Set(sv => sv.BirthYear, updatedSinhVien.BirthYear)
                .Set(sv => sv.Sex, updatedSinhVien.Sex)
                .Set(sv => sv.Email, updatedSinhVien.Email)
                .Set(sv => sv.PhoneNum, updatedSinhVien.PhoneNum)
                .Set(sv => sv.Class, updatedSinhVien.Class)
                .Set(sv => sv.Major, updatedSinhVien.Major)
                .Set(sv => sv.Faculty, updatedSinhVien.Faculty)
                .Set(sv => sv.Session, updatedSinhVien.Session)
                .Set(sv => sv.Advisor, updatedSinhVien.Advisor);

            SinhViens.UpdateOne(filter, update);
        }


        // Xóa sinh viên
        public void DeleteSinhVien(string mssv) {
            SinhViens.DeleteOne(sv => sv.MSSV == mssv);
        }

        // Lấy tất cả sinh viên
        public List<SinhVien> GetAllSinhViens() {
            return SinhViens.Find(_ => true).ToList();
        }


        // Môn học
        // Lấy tất cả môn học
        public List<MonHoc> GetMonHocs()
        {
            return MonHocCollection.Find(new BsonDocument()).ToList();
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

        // Khoa

        // Lấy thông tin Khoa theo khoaId
        public Khoa GetKhoaById(string khoaId)
        {
            return KhoaCollection.Find(k => k.maKhoa == khoaId).FirstOrDefault();
        }
        // Lấy danh sách các khoa
        public List<Khoa> GetKhoas()
        {
            return KhoaCollection.Find(new BsonDocument()).ToList();
        }

        // Thêm khoa mới
        public void AddKhoa(Khoa khoa)
        {
            KhoaCollection.InsertOne(khoa);
        }

        // Cập nhật khoa
        public void UpdateKhoa(Khoa khoa)
        {
            var filter = Builders<Khoa>.Filter.Eq(k => k.maKhoa, khoa.maKhoa);
            var update = Builders<Khoa>.Update
                .Set(k => k.tenKhoa, khoa.tenKhoa);
            KhoaCollection.UpdateOne(filter, update);
        }

        // Xóa khoa
        public void DeleteKhoa(string maKhoa)
        {
            var filter = Builders<Khoa>.Filter.Eq(k => k.maKhoa, maKhoa);
            KhoaCollection.DeleteOne(filter);
        }
        public List<Khoa> SearchKhoas(string searchTerm)
        {
            var filter = Builders<Khoa>.Filter.Or(
                Builders<Khoa>.Filter.Regex(k => k.maKhoa, new BsonRegularExpression(searchTerm, "i")),  // Tìm kiếm theo mã khoa (không phân biệt chữ hoa, chữ thường)
                Builders<Khoa>.Filter.Regex(k => k.tenKhoa, new BsonRegularExpression(searchTerm, "i"))   // Tìm kiếm theo tên khoa (không phân biệt chữ hoa, chữ thường)
            );

            return KhoaCollection.Find(filter).ToList();
        }

        // ---------------------------------
        //Ngành
        // Thêm ngành mới
        public void AddNganh(Nganh nganh)
        {
            Nganhs.InsertOne(nganh);
        }

        // Cập nhật ngành
        public void UpdateNganh(Nganh nganh)
        {
            var filter = Builders<Nganh>.Filter.Eq(n => n.maNganh, nganh.maNganh);
            var update = Builders<Nganh>.Update
                .Set(n => n.tenNganh, nganh.tenNganh)
                .Set(n => n.maKhoa, nganh.maKhoa);
            Nganhs.UpdateOne(filter, update);
        }

        // Xóa ngành
        public void DeleteNganh(string maNganh)
        {
            var filter = Builders<Nganh>.Filter.Eq(n => n.maNganh, maNganh);
            Nganhs.DeleteOne(filter);
        }

        // Tìm kiếm ngành
        public List<Nganh> SearchNganhs(string searchTerm)
        {
            var filter = Builders<Nganh>.Filter.Or(
                Builders<Nganh>.Filter.Regex(n => n.maNganh, new BsonRegularExpression(searchTerm, "i")),
                Builders<Nganh>.Filter.Regex(n => n.tenNganh, new BsonRegularExpression(searchTerm, "i"))
            );
            return Nganhs.Find(filter).ToList();
        }
        //----------------------------------
        //Giảng viên

        // Lấy tất cả giảng viên
        public List<GiangVien> GetGiangViens()
        {
            return GiangVienCollection.Find(new BsonDocument()).ToList();
        }

        // Thêm giảng viên
        public void AddGiangVien(GiangVien giangVien)
        {
            GiangVienCollection.InsertOne(giangVien);
        }

        // Cập nhật giảng viên
        public void UpdateGiangVien(GiangVien giangVien)
        {
            var filter = Builders<GiangVien>.Filter.Eq(g => g.maGV, giangVien.maGV);
            var update = Builders<GiangVien>.Update
                .Set(g => g.hoTen, giangVien.hoTen)
                .Set(g => g.gioiTinh, giangVien.gioiTinh)
                .Set(g => g.maLop, giangVien.maLop)
                .Set(g => g.ngaySinh, giangVien.ngaySinh)
                .Set(g => g.email, giangVien.email)
                .Set(g => g.soDT, giangVien.soDT);

            GiangVienCollection.UpdateOne(filter, update);
        }

        // Xóa giảng viên
        public void DeleteGiangVien(string maGV)
        {
            var filter = Builders<GiangVien>.Filter.Eq(g => g.maGV, maGV);
            GiangVienCollection.DeleteOne(filter);
        }

        // Tìm kiếm giảng viên
        public List<GiangVien> SearchGiangViens(string searchTerm)
        {
            var filter = Builders<GiangVien>.Filter.Or(
                Builders<GiangVien>.Filter.Regex(g => g.maGV, new BsonRegularExpression(searchTerm, "i")),
                Builders<GiangVien>.Filter.Regex(g => g.hoTen, new BsonRegularExpression(searchTerm, "i"))
            );

            return GiangVienCollection.Find(filter).ToList();
        }
        //----------------------------------
    }
}
