namespace SistemaRegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddControleProprietario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proprietarios", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Proprietarios", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Proprietarios", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Proprietarios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Proprietarios", "DataAlteracao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proprietarios", "DataAlteracao");
            DropColumn("dbo.Proprietarios", "DataCriacao");
            DropColumn("dbo.Proprietarios", "UsuarioAlteracao");
            DropColumn("dbo.Proprietarios", "UsuarioCriacao");
            DropColumn("dbo.Proprietarios", "Ativo");
        }
    }
}
