namespace PokeriaCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_Ingredienti", "FotoIngrediente", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.T_Poke", "FotoPoke", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.T_Poke", "FotoPoke");
            DropColumn("dbo.T_Ingredienti", "FotoIngrediente");
        }
    }
}
