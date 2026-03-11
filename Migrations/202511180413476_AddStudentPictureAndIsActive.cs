namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentPictureAndIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "PictureData", c => c.Binary());
            AddColumn("dbo.Person", "PictureMimeType", c => c.String(maxLength: 50));
            AddColumn("dbo.Person", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "IsActive");
            DropColumn("dbo.Person", "PictureMimeType");
            DropColumn("dbo.Person", "PictureData");
        }
    }
}
