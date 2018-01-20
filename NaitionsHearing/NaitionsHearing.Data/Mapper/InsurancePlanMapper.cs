using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data.Mapper
{
    public class InsurancePlanMapper: EntityTypeConfiguration<InsurancePlan>
    {
        public InsurancePlanMapper()
        {
            this.ToTable("InsurancePlans");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).IsRequired();
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Name).IsRequired();
            this.Property(c => c.Name).HasMaxLength(255);
        }
    }
}
