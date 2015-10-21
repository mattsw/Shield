namespace Shield.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        IdentityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Identities", t => t.IdentityId, cascadeDelete: true)
                .Index(t => t.IdentityId);
            
            CreateTable(
                "dbo.Identities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Attribute = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillSlot = c.Int(nullable: false),
                        Description = c.String(),
                        Identity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Identities", t => t.Identity_Id, cascadeDelete: true)
                .Index(t => t.Identity_Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dungeon = c.Double(nullable: false),
                        GuildOffense = c.Double(nullable: false),
                        GuildDefense = c.Double(nullable: false),
                        ArenaOffense = c.Double(nullable: false),
                        ArenaDefense = c.Double(nullable: false),
                        TowerOfAscension = c.Double(nullable: false),
                        Identity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Identities", t => t.Identity_Id, cascadeDelete: true)
                .Index(t => t.Identity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "IdentityId", "dbo.Identities");
            DropForeignKey("dbo.Ratings", "Identity_Id", "dbo.Identities");
            DropForeignKey("dbo.Abilities", "Identity_Id", "dbo.Identities");
            DropIndex("dbo.Ratings", new[] { "Identity_Id" });
            DropIndex("dbo.Abilities", new[] { "Identity_Id" });
            DropIndex("dbo.Reviews", new[] { "IdentityId" });
            DropTable("dbo.Ratings");
            DropTable("dbo.Abilities");
            DropTable("dbo.Identities");
            DropTable("dbo.Reviews");
        }
    }
}
