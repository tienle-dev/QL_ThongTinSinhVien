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
            var client = new MongoClient("mongodb+srv://tienle:pass123@cluster0.y6jck.mongodb.net/"); // Replace with your MongoDB connection string
            _database = client.GetDatabase("QL_Thongtinsinhvien");
        }

        public IMongoCollection<Admin> Admins => _database.GetCollection<Admin>("Admin");
        public IMongoCollection<Lop> Lops => _database.GetCollection<Lop>("Lop");
        public IMongoCollection<Nganh> Nganhs => _database.GetCollection<Nganh>("Nganh");

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
                filter &= Builders<Lop>.Filter.Eq(l => l.tenLop, tenLop);
            if (!string.IsNullOrEmpty(idNganh))
                filter &= Builders<Lop>.Filter.Eq(l => l.nganhId, idNganh);

            return Lops.Find(filter).ToList();
        }

        // Fetch departments for ComboBox
        public List<Nganh> GetAllNganhs() => Nganhs.Find(_ => true).ToList();
    }
}
