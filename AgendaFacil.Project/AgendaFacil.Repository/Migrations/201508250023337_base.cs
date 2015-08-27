namespace AgendaFacil.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        AgendaID = c.Int(nullable: false, identity: true),
                        DataAgendamento = c.DateTime(nullable: false),
                        FK_ClienteID_ClienteID = c.Int(),
                        FK_TratamentoID_TratamentoID = c.Int(),
                    })
                .PrimaryKey(t => t.AgendaID)
                .ForeignKey("dbo.Cliente", t => t.FK_ClienteID_ClienteID)
                .ForeignKey("dbo.Tratamento", t => t.FK_TratamentoID_TratamentoID)
                .Index(t => t.FK_ClienteID_ClienteID)
                .Index(t => t.FK_TratamentoID_TratamentoID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 8000, unicode: false),
                        Telefone = c.String(maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 8000, unicode: false),
                        Endereco = c.String(maxLength: 8000, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Tratamento",
                c => new
                    {
                        TratamentoID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 8000, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        FK_FuncionarioID_FuncionarioID = c.Int(),
                    })
                .PrimaryKey(t => t.TratamentoID)
                .ForeignKey("dbo.Funcionario", t => t.FK_FuncionarioID_FuncionarioID)
                .Index(t => t.FK_FuncionarioID_FuncionarioID);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioID = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 8000, unicode: false),
                        Senha = c.String(maxLength: 8000, unicode: false),
                        Nome = c.String(maxLength: 8000, unicode: false),
                        Telefone = c.String(maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 8000, unicode: false),
                        Endereco = c.String(maxLength: 8000, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agenda", "FK_TratamentoID_TratamentoID", "dbo.Tratamento");
            DropForeignKey("dbo.Tratamento", "FK_FuncionarioID_FuncionarioID", "dbo.Funcionario");
            DropForeignKey("dbo.Agenda", "FK_ClienteID_ClienteID", "dbo.Cliente");
            DropIndex("dbo.Tratamento", new[] { "FK_FuncionarioID_FuncionarioID" });
            DropIndex("dbo.Agenda", new[] { "FK_TratamentoID_TratamentoID" });
            DropIndex("dbo.Agenda", new[] { "FK_ClienteID_ClienteID" });
            DropTable("dbo.Funcionario");
            DropTable("dbo.Tratamento");
            DropTable("dbo.Cliente");
            DropTable("dbo.Agenda");
        }
    }
}
