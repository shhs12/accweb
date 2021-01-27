using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AccWeb.Shared.Models
{
    public class Infotb
    {
        public int id { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string activity { get; set; }
        public string address { get; set; }
        public string mailbox { get; set; }
        public string Pcode { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string mobile { get; set; }
        [EmailAddress (ErrorMessage = "البريد الالكتروني غير صحيح")]
        public string email { get; set; }
        public string comreg { get; set; }
        public string taxnum { get; set; }

        public string picurl { get; set; }

    }
}
