namespace DataAccessObject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_CONTATO",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        CodigoSexo = c.Int(nullable: false),
                        CodigoEstadoCivil = c.Int(nullable: false),
                        Nome = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                    })

                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.TB_ESTADO_CIVIL", t => t.CodigoEstadoCivil, cascadeDelete: true)
                .ForeignKey("dbo.TB_SEXO", t => t.CodigoSexo, cascadeDelete: true)
                .Index(t => t.CodigoSexo)
                .Index(t => t.CodigoEstadoCivil);
            
            CreateTable(
                "dbo.TB_ESTADO_CIVIL",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.TB_SEXO",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_CONTATO", "CodigoSexo", "dbo.TB_SEXO");
            DropForeignKey("dbo.TB_CONTATO", "CodigoEstadoCivil", "dbo.TB_ESTADO_CIVIL");
            DropIndex("dbo.TB_CONTATO", new[] { "CodigoEstadoCivil" });
            DropIndex("dbo.TB_CONTATO", new[] { "CodigoSexo" });
            DropTable("dbo.TB_SEXO");
            DropTable("dbo.TB_ESTADO_CIVIL");
            DropTable("dbo.TB_CONTATO");
        }
    }
}
