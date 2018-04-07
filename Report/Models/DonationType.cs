using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class DonationType
    {
        [Key]
        public int KeyID { get; set; }
        public string ShortName { get; set; }
    }
}