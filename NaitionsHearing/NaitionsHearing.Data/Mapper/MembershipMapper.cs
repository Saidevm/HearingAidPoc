using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data.Mapper
{
    public class MembershipMapper : EntityTypeConfiguration<Membership>
    {
        public MembershipMapper()
        {
            this.ToTable("MemberShips");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();
            

            //this.HasRequired(c => c.InsurancePlans).WithMany().Map(s => s.MapKey("InsurancePlanId"));
            this.HasOptional(c => c.InsurancePlan).WithMany(m=>m.Memberships).Map(s => s.MapKey("InsurancePlanId"));
            this.HasOptional(c => c.Member).WithMany(m=>m.InsurancePlanMemberShips).Map(s => s.MapKey("MemberId"));
        }
    }
}
