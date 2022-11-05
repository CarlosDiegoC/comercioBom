using Microsoft.EntityFrameworkCore.Migrations;

namespace ComercioBom.Migrations
{
    public partial class ItemProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Itens_ProdutoId",
                table: "Itens",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_ProdutoId",
                table: "Itens");
        }
    }
}
