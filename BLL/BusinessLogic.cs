using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogic
    {
        private readonly Database _db;

        public BusinessLogic()
        {
            _db = new Database();
        }

        public bool Login(string username, string password)
        {
            return _db.AuthenticateAdmin(username, password);
        }


        public List<Lop> GetLops() => _db.GetAllLops();
        public List<Nganh> GetNganhs() => _db.GetAllNganhs();
        public void AddLop(Lop lop) => _db.AddLop(lop);
        public void UpdateLop(string maLop, Lop updatedLop) => _db.UpdateLop(maLop, updatedLop);
        public void DeleteLop(string maLop) => _db.DeleteLop(maLop);
        public List<Lop> SearchLops(string tenLop, string idNganh) => _db.SearchLops(tenLop, idNganh);
    }
}
