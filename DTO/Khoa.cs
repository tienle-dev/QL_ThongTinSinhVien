<<<<<<< HEAD
﻿using System;
=======
﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
>>>>>>> 279dc76ba739ff42524b835dba9cb4a9b4a4bd39
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace DTO {
    internal class Khoa {
=======
namespace DTO
{
    public class Khoa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string maKhoa { get; set; }
        public string tenKhoa { get; set; }
>>>>>>> 279dc76ba739ff42524b835dba9cb4a9b4a4bd39
    }
}
