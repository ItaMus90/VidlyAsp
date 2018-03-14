namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDataForMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId,ReleaseDate,NumberInStock) VALUES('The Terminator',1,CAST('1984-11-26' AS DATETIME),5)");
        }
        
        public override void Down()
        {
        }
    }
}
