namespace Gas_Station.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PullRequest1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "GasStation_Id", c => c.Int());
            CreateIndex("dbo.Offers", "GasStation_Id");
            AddForeignKey("dbo.Offers", "GasStation_Id", "dbo.GasStations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offers", "GasStation_Id", "dbo.GasStations");
            DropIndex("dbo.Offers", new[] { "GasStation_Id" });
            DropColumn("dbo.Offers", "GasStation_Id");
        }
    }
}
