namespace PokeriaCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.T_Ingredienti",
                c => new
                    {
                        IDIngrediente = c.Int(nullable: false, identity: true),
                        NomeIngrediente = c.String(nullable: false, maxLength: 30),
                        TipoIngrediente = c.String(nullable: false, maxLength: 20),
                        PrezzoAggiuntivo = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.IDIngrediente);
            
            CreateTable(
                "dbo.T_RelazionePokeIngredienti",
                c => new
                    {
                        IDRelazione = c.Int(nullable: false, identity: true),
                        FKIDPoke = c.Int(),
                        FKIDIngrediente = c.Int(),
                    })
                .PrimaryKey(t => t.IDRelazione)
                .ForeignKey("dbo.T_Poke", t => t.FKIDPoke)
                .ForeignKey("dbo.T_Ingredienti", t => t.FKIDIngrediente)
                .Index(t => t.FKIDPoke)
                .Index(t => t.FKIDIngrediente);
            
            CreateTable(
                "dbo.T_Poke",
                c => new
                    {
                        IDPoke = c.Int(nullable: false, identity: true),
                        NomePoke = c.String(nullable: false, maxLength: 20),
                        IsComposta = c.Boolean(),
                        Prezzo = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.IDPoke);
            
            CreateTable(
                "dbo.T_Ordini",
                c => new
                    {
                        IDOrdine = c.Int(nullable: false),
                        FKIDUser = c.Int(nullable: false),
                        FKIDPoke = c.Int(nullable: false),
                        DataOrdine = c.DateTime(),
                    })
                .PrimaryKey(t => t.IDOrdine)
                .ForeignKey("dbo.T_User", t => t.FKIDUser)
                .ForeignKey("dbo.T_Poke", t => t.FKIDPoke)
                .Index(t => t.FKIDUser)
                .Index(t => t.FKIDPoke);
            
            CreateTable(
                "dbo.T_User",
                c => new
                    {
                        IDUser = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 20),
                        Password = c.String(maxLength: 20),
                        Email = c.String(maxLength: 30),
                        Role = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.IDUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_RelazionePokeIngredienti", "FKIDIngrediente", "dbo.T_Ingredienti");
            DropForeignKey("dbo.T_RelazionePokeIngredienti", "FKIDPoke", "dbo.T_Poke");
            DropForeignKey("dbo.T_Ordini", "FKIDPoke", "dbo.T_Poke");
            DropForeignKey("dbo.T_Ordini", "FKIDUser", "dbo.T_User");
            DropIndex("dbo.T_Ordini", new[] { "FKIDPoke" });
            DropIndex("dbo.T_Ordini", new[] { "FKIDUser" });
            DropIndex("dbo.T_RelazionePokeIngredienti", new[] { "FKIDIngrediente" });
            DropIndex("dbo.T_RelazionePokeIngredienti", new[] { "FKIDPoke" });
            DropTable("dbo.T_User");
            DropTable("dbo.T_Ordini");
            DropTable("dbo.T_Poke");
            DropTable("dbo.T_RelazionePokeIngredienti");
            DropTable("dbo.T_Ingredienti");
            DropTable("dbo.sysdiagrams");
        }
    }
}
