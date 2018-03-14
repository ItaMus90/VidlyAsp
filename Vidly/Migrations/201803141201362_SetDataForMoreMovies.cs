namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataForMoreMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,NumberInStock) VALUES('The Matrix',1,CAST('1999-07-27' AS DATETIME),10)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,NumberInStock) VALUES('Se7en',2,CAST('1995-09-15' AS DATETIME),20)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,NumberInStock) VALUES('The Hangover',5,CAST('2009-10-06' AS DATETIME),5)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,NumberInStock) VALUES('Titanic',4,CAST('1998-10-09' AS DATETIME),10)");
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,NumberInStock) VALUES('The Karate Kid',3,CAST('1984-06-22' AS DATETIME),14)");
        }
        
        public override void Down()
        {
        }
    }
}
