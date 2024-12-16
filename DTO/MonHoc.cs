using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string MaMon { get; set; }
        public string tenMon { get; set; }
        public int soTinChi { get; set; }
        public int tietLT { get; set; }
        public int tietTH { get; set; }
        public string khoaId { get; set; }
    }
}
