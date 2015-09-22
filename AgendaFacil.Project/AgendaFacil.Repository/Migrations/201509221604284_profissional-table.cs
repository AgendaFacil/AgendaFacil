namespace AgendaFacil.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profissionaltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profissional",
                c => new
                    {
                        ProfissionalID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 8000, unicode: false),
                        Telefone = c.String(maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 8000, unicode: false),
                        Endereco = c.String(maxLength: 8000, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProfissionalID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profissional");
        }
    }
}
