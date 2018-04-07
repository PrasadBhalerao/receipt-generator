using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class ReportDBContext : DbContext
    {
        public ReportDBContext() : base("name=DatabaseConnString")
        {
        }
        public DbSet<ReceiptData> ReceiptData { get; set; }
        public DbSet<DonationType> DonationTypes { get; set; }
        public DbSet<DonationTypeTranslation> DonationTypeTranslations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}