﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class SinhVienFilter {
        public string MSSV { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public int? BirthYear { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }
        public string Major { get; set; }
        public string Faculty { get; set; }
        public string Session { get; set; }
        public string Advisor { get; set; }
    }
}
