namespace Shield.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        AbilityId = c.Int(nullable: false, identity: true),
                        IdentityId = c.Int(nullable: false),
                        SkillSlot = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AbilityId)
                .ForeignKey("dbo.Identities", t => t.IdentityId, cascadeDelete: true)
                .Index(t => t.IdentityId);
            
            CreateTable(
                "dbo.Identities",
                c => new
                    {
                        IdentityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Attribute = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdentityId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingId = c.Int(nullable: false, identity: true),
                        IdentityId = c.Int(nullable: false),
                        Dungeon = c.Double(nullable: false),
                        GuildOffense = c.Double(nullable: false),
                        GuildDefense = c.Double(nullable: false),
                        ArenaOffense = c.Double(nullable: false),
                        ArenaDefense = c.Double(nullable: false),
                        TowerOfAscension = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RatingId)
                .ForeignKey("dbo.Identities", t => t.IdentityId, cascadeDelete: true)
                .Index(t => t.IdentityId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "IdentityId", "dbo.Identities");
            DropForeignKey("dbo.Abilities", "IdentityId", "dbo.Identities");
            DropForeignKey("dbo.Ratings", "IdentityId", "dbo.Identities");
            DropIndex("dbo.Reviews", new[] { "IdentityId" });
            DropIndex("dbo.Ratings", new[] { "IdentityId" });
            DropIndex("dbo.Abilities", new[] { "IdentityId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Ratings");
            DropTable("dbo.Identities");
            DropTable("dbo.Abilities");
        }
    }
}
