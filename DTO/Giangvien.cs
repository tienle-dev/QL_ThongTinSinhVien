using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    public class GiangVien
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string maGV { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string maLop { get; set; }

        public string ngaySinh { get; set; }
        public string email { get; set; }
        public string soDT { get; set; }
    }
}
