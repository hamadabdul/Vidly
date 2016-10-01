namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,GenreID,DateAdded,ReleaseDate,NumberInStock) values ('Spider Man',1,'01/03/2016','01/04/2016',10)");
            Sql("Insert into Movies (Name,GenreID,DateAdded,ReleaseDate,NumberInStock) values ('Bat Man',1,'01/03/2016','01/04/2016',10)");

        }
        
        public override void Down()
        {
        }
    }
}
