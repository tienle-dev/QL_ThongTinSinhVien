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
        public string tenNganh { get; set; } // Department Name

        [BsonRepresentation(BsonType.ObjectId)]
        public string khoaId { get; set; } // Department Name

    }
}
