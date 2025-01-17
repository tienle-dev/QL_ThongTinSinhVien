﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LopBLL
    {
        private readonly Database _db;

        public LopBLL()
        {
            _db = new Database();
        }

        public List<Lop> GetLops() => _db.GetAllLops();
        public List<Nganh> GetNganhs() => _db.GetAllNganhs();
        public void AddLop(Lop lop) => _db.AddLop(lop);
        public void UpdateLop(Lop updatedLop) => _db.UpdateLop(updatedLop);
        public void DeleteLop(string maLop) => _db.DeleteLop(maLop);
        public List<Lop> SearchLops(string maLop, string tenLop, string idNganh) => _db.SearchLops(maLop, tenLop, idNganh);
    }
}
