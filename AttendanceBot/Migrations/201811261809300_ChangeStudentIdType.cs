namespace AttendanceBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStudentIdType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "StudentId", c => c.Int(nullable: false));
        }
    }
}
