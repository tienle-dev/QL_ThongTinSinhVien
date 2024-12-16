using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MaLop { get; set; } // ID
        public string tenLop { get; set; } // ten lop
        [BsonRepresentation(BsonType.ObjectId)]
        public string nganhId { get; set; } // tham chieu toi ID cua Nganh
    }
}
