namespace MovieBuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET  BirthDate='1980-01-02' where ID=1");
        }
        
        public override void Down()
        {
        }
    }
}
