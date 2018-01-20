using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data.Mapper
{
    public class MemberMapper : EntityTypeConfiguration<Member>
    {
        public MemberMapper()
        {
            this.ToTable("Members");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();

            this.Property(c => c.Dob).IsRequired();
            this.Property(c => c.Gender).IsRequired();
            this.Property(c => c.Name).IsRequired();

            //this.HasRequired(c => c.InsurancePlans).WithMany().Map(s => s.MapKey("InsurancePlanId"));
            this.HasOptional(c => c.InsurancePlans).WithMany().Map(s => s.MapKey("InsurancePlanId"));
        }
    }
}
