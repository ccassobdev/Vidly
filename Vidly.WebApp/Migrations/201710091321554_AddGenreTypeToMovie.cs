namespace Vidly.WebApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddGenreTypeToMovie : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
        }
    }
}