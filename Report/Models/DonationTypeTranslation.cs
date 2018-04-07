using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class DonationTypeTranslation
    {
        [Key]
        public int KeyID { get; set; }
        public int TranslationOfID { get; set; }
        public string Name { get; set; }
        public int CultureID { get; set; }
    }
}