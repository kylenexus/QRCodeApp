using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRCodeApp.Models
{
    public class Guest
    {
        public int id { get; set; }
        public string EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}