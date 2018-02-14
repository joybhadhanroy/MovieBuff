namespace MovieBuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Anime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romantic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
