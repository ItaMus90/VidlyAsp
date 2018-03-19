namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnAddDateTOMovieTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AddDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AddDate");
        }
    }
}
