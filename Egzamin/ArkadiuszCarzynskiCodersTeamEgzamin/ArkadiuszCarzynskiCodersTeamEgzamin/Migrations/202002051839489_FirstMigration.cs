namespace ArkadiuszCarzynskiCodersTeamEgzamin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Programmers",
                c => new
                    {
                        idProgrammer = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProgrammer);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        idProject = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        idProgrammer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProject)
                .ForeignKey("dbo.Programmers", t => t.idProgrammer, cascadeDelete: true)
                .Index(t => t.idProgrammer);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "idProgrammer", "dbo.Programmers");
            DropIndex("dbo.Projects", new[] { "idProgrammer" });
            DropTable("dbo.Projects");
            DropTable("dbo.Programmers");
        }
    }
}
