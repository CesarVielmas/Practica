using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CursosData.Migrations
{
    /// <inheritdoc />
    public partial class incluyendoDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Categoria 1 activada" },
                    { 2, "Categoria 2 activada" },
                    { 3, "Categoria 3 activada" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Direccion", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Mision Real", "Cesar Alejandro", "10668239" },
                    { 2, "Juan Carlos", "Flor Abigail", "10673239" },
                    { 3, "San Javier", "Pedrito Solano", "12039489" }
                });

            migrationBuilder.InsertData(
                table: "Proveedors",
                columns: new[] { "Id", "Direccion", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Villa de juan luis", "Proveedor Carlos", "1381274" },
                    { 2, "San luis potosi", "Proveedor Juan", "7150293" },
                    { 3, "Coahuila", "Proveedor Cesar", "8149712" }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "Cantidad", "FacturaId", "ProductoId" },
                values: new object[,]
                {
                    { 1, 20, 2, 3 },
                    { 2, 40, 3, 1 },
                    { 3, 60, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "Id", "ClienteId", "Fecha", "VentaId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 7, 19, 15, 20, 31, 123, DateTimeKind.Local).AddTicks(5953), null },
                    { 2, 1, new DateTime(2023, 7, 19, 15, 20, 31, 123, DateTimeKind.Local).AddTicks(6050), null },
                    { 3, 3, new DateTime(2023, 7, 19, 15, 20, 31, 123, DateTimeKind.Local).AddTicks(6061), null }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "Precio", "ProveedorId", "VentaId" },
                values: new object[,]
                {
                    { 1, 2, "Producto numero 1 dispuesto a luchar contra el crimen", 50.43f, 1, null },
                    { 2, 1, "Producto numero 2 dispuesto a luchar contra el crimen", 110.673f, 3, null },
                    { 3, 3, "Producto numero 3 dispuesto a luchar contra el crimen", 80.142f, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Proveedors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proveedors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Proveedors",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
