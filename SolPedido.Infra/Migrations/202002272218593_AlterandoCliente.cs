namespace SolPedido.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "Nome", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Nome", c => c.String(maxLength: 100, unicode: false));
        }
    }
}
