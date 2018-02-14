namespace MovieBuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipTypeName1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' where ID=1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' where ID=2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' where ID=3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' where ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
