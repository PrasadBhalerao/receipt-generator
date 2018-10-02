using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class ReceiptData
    {
        [Key]
        public int KeyId { get; set; }
        public string Name { get; set; }

        //[ForeignKey("DonationTypeID")]
        //public DonationType DonationType { get; set; }
        //public int DonationTypeID { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string MobileNo { get; set; }
        public decimal Amount { get; set; }
    }
}
