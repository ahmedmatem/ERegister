namespace AMA.ERegister.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablesrel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TeacherId = c.String(maxLength: 128),
                        GroupId = c.String(maxLength: 128),
                        DisciplineId = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplines", t => t.DisciplineId)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TeacherId)
                .Index(t => t.GroupId)
                .Index(t => t.DisciplineId)
                .Index(t => t.IsDeleted);
            
            AddColumn("dbo.Disciplines", "GroupId", c => c.String(maxLength: 128));
            AddColumn("dbo.Groups", "TeacherId", c => c.String());
            AddColumn("dbo.Groups", "Teacher_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Teachers", "SchoolId", c => c.String(maxLength: 128));
            AddColumn("dbo.Teachers", "GroupId", c => c.String());
            CreateIndex("dbo.Disciplines", "GroupId");
            CreateIndex("dbo.Groups", "Teacher_Id");
            CreateIndex("dbo.Teachers", "SchoolId");
            AddForeignKey("dbo.Disciplines", "GroupId", "dbo.Groups", "Id");
            AddForeignKey("dbo.Teachers", "SchoolId", "dbo.Schools", "Id");
            AddForeignKey("dbo.Groups", "Teacher_Id", "dbo.Teachers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Schedules", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Schedules", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Schedules", "DisciplineId", "dbo.Disciplines");
            DropForeignKey("dbo.Disciplines", "GroupId", "dbo.Groups");
            DropIndex("dbo.Schedules", new[] { "IsDeleted" });
            DropIndex("dbo.Schedules", new[] { "DisciplineId" });
            DropIndex("dbo.Schedules", new[] { "GroupId" });
            DropIndex("dbo.Schedules", new[] { "TeacherId" });
            DropIndex("dbo.Teachers", new[] { "SchoolId" });
            DropIndex("dbo.Groups", new[] { "Teacher_Id" });
            DropIndex("dbo.Disciplines", new[] { "GroupId" });
            DropColumn("dbo.Teachers", "GroupId");
            DropColumn("dbo.Teachers", "SchoolId");
            DropColumn("dbo.Groups", "Teacher_Id");
            DropColumn("dbo.Groups", "TeacherId");
            DropColumn("dbo.Disciplines", "GroupId");
            DropTable("dbo.Schedules");
        }
    }
}
