namespace SistemaRegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class herdandoControle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Imovels", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Imovels", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Imovels", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Imovels", "DataAlteracao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Imovels", "DataAlteracao");
            DropColumn("dbo.Imovels", "DataCriacao");
            DropColumn("dbo.Imovels", "UsuarioAlteracao");
            DropColumn("dbo.Imovels", "UsuarioCriacao");
            DropColumn("dbo.Imovels", "Ativo");
        }
    }
}
