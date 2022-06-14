using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo1.Migrations
{
    public partial class PopulandoCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias (Nome, ImagemUrl) Values('Bebidas','Bebidas.jpg')");
            mb.Sql("Insert into Categorias (Nome, ImagemUrl) Values('Lanches','Lanches.jpg')");
            mb.Sql("Insert into Categorias (Nome, ImagemUrl) Values('Sobremesas','Sobremesas.jpg')");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Drop table Categorias");
        }
    }
}
