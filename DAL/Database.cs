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
            _database = client.GetDatabase("QL_Thongtinsinhvien"); // Gán đúng cho _database
            Console.WriteLine("Kết nối thành công!");

        }

        public IMongoCollection<Lop> Lops => _database.GetCollection<Lop>("Lop");
        public IMongoCollection<Nganh> Nganhs => _database.GetCollection<Nganh>("Nganh");
        public IMongoCollection<Khoa> Khoas => _database.GetCollection<Khoa>("Khoa");

        // Lấy danh sách Lớp
        public List<string> GetAllClassNames() {
            return Lops.Find(_ => true).ToList().Select(l => l.TenLop).ToList();
        }

        // Lấy danh sách Ngành
        public List<string> GetAllMajors() {
            return Nganhs.Find(_ => true).ToList().Select(n => n.tenNganh).ToList();
        }

        // Lấy danh sách Khoa
        public List<string> GetAllFaculties() {
            return Khoas.Find(_ => true).ToList().Select(k => k.TenKhoa).ToList();
        }
        // Admin authentication
        public bool AuthenticateAdmin(string username, string password)
        {
            var admin = Admins.Find(a => a.tenAd == username && a.matKhau == password).FirstOrDefault();
            return admin != null;
        }

        // CRUD operations for Lop
        public List<Lop> GetAllLops() => Lops.Find(_ => true).ToList();

        public void AddLop(Lop lop) => Lops.InsertOne(lop);

        public void UpdateLop(string maLop, Lop updatedLop)
        {
            Lops.ReplaceOne(l => l.MaLop == maLop, updatedLop);
        }

        public void DeleteLop(string maLop)
        {
            Lops.DeleteOne(l => l.MaLop == maLop);
        }

        public List<Lop> SearchLops(string tenLop, string idNganh)
        {
            var filter = Builders<Lop>.Filter.Empty;
            if (!string.IsNullOrEmpty(tenLop))
                filter &= Builders<Lop>.Filter.Eq(l => l.TenLop, tenLop);
            if (!string.IsNullOrEmpty(idNganh))
                filter &= Builders<Lop>.Filter.Eq(l => l.IdNganh, idNganh);

            return Lops.Find(filter).ToList();
        }

        // Fetch departments for ComboBox
        public List<Nganh> GetAllNganhs() => Nganhs.Find(_ => true).ToList();
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

    }
}
