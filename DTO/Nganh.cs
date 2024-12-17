using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nganh
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // Department ID
        public string maNganh { get; set; }
        public string tenNganh { get; set; } // Department Name
        public string maKhoa { get; set; } // Department Name

    }
}
