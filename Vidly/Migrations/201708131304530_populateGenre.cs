namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (5, 'Sciense Fiction')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (6, 'Social')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (7, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (8, 'Musical')");
        }
        
        public override void Down()
        {
        }
    }
}
