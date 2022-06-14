using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo1.Migrations
{
    public partial class PopulandoProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Produtos",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.Sql("Insert into Produtos(Nome,Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "Values('Coca-Cola Diet','Refigrerante cola 350 ml', 5.45,'cocacola.jpg', 50, GETDATE(), 1)");
            migrationBuilder.Sql("Insert into Produtos(Nome,Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "Values('Lanche de Atum','Lanche de Atum com maionese', 8.50,'Atum.jpg', 10, GETDATE(), 2)");
            migrationBuilder.Sql("Insert into Produtos(Nome,Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "Values('Pudim 100g','Pudim de leite condensado 100g', 6.75,'pudim.jpg', 20, GETDATE(), 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.Sql("Drop table Produtos");
        }
    }
}
