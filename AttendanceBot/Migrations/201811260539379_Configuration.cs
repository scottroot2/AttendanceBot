namespace AttendanceBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Configuration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceSessions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AttendanceSessionDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AttendanceSession_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AttendanceSessions", t => t.AttendanceSession_ID)
                .Index(t => t.AttendanceSession_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "AttendanceSession_ID", "dbo.AttendanceSessions");
            DropIndex("dbo.Students", new[] { "AttendanceSession_ID" });
            DropTable("dbo.Students");
            DropTable("dbo.AttendanceSessions");
        }
    }
}
