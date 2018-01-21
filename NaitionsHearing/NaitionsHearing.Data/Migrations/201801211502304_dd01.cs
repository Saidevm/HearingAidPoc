namespace NaitionsHearing.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dd01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InsurancePlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
                       
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Dob = c.DateTime(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
               "dbo.MemberShips",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   InsurancePlanId = c.Int(),
                   MemberId = c.Int(),
               })
               .PrimaryKey(t => t.Id)
               .ForeignKey("dbo.InsurancePlans", t => t.InsurancePlanId)
               .ForeignKey("dbo.Members", t => t.MemberId)
               .Index(t => t.InsurancePlanId)
               .Index(t => t.MemberId);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberShips", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberShips", "InsurancePlanId", "dbo.InsurancePlans");
            DropIndex("dbo.MemberShips", new[] { "MemberId" });
            DropIndex("dbo.MemberShips", new[] { "InsurancePlanId" });
            DropTable("dbo.Members");
            DropTable("dbo.MemberShips");
            DropTable("dbo.InsurancePlans");
        }
    }
}
