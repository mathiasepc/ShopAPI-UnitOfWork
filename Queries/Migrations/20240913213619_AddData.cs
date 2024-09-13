using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Queries.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"), "Legetøj" },
                    { new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"), "Tv" },
                    { new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"), "Tøj" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "MakeId", "Name" },
                values: new object[,]
                {
                    { new Guid("42532caa-0a7f-4556-bcb2-43113ddb7386"), new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"), "Phillips" },
                    { new Guid("5f708c2e-5497-4b8f-a8e2-d393d7ef1540"), new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"), "Nike" },
                    { new Guid("91414760-4cef-4da4-8c91-00e2b18078b2"), new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"), "Puma" },
                    { new Guid("acb956e0-7a1f-48c1-b100-7e9f35d9411b"), new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"), "LG" },
                    { new Guid("c06435a9-1913-4a52-a415-01c93753c388"), new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"), "Lego" },
                    { new Guid("c2dc45ee-9bb0-42e9-b625-aeddc53da952"), new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"), "Bamser" },
                    { new Guid("c956850a-e488-420f-8611-dd30849aaa8e"), new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"), "Peak" },
                    { new Guid("e0799875-c7cd-4c34-b119-9ce3d9f5f742"), new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"), "Prosonic" },
                    { new Guid("e5c7929a-956d-4e29-9b86-22f472430933"), new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"), "Brætspil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("42532caa-0a7f-4556-bcb2-43113ddb7386"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("5f708c2e-5497-4b8f-a8e2-d393d7ef1540"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("91414760-4cef-4da4-8c91-00e2b18078b2"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("acb956e0-7a1f-48c1-b100-7e9f35d9411b"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c06435a9-1913-4a52-a415-01c93753c388"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c2dc45ee-9bb0-42e9-b625-aeddc53da952"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c956850a-e488-420f-8611-dd30849aaa8e"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e0799875-c7cd-4c34-b119-9ce3d9f5f742"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e5c7929a-956d-4e29-9b86-22f472430933"));

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"));

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"));

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"));
        }
    }
}
