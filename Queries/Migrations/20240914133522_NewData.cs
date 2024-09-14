using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Queries.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"),
                column: "Name",
                value: "Spil");

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"),
                column: "Name",
                value: "Phillips");

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"),
                column: "Name",
                value: "Lego");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("42532caa-0a7f-4556-bcb2-43113ddb7386"),
                column: "Name",
                value: "55OLED708");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("5f708c2e-5497-4b8f-a8e2-d393d7ef1540"),
                column: "Name",
                value: "Millennium Falcon");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("91414760-4cef-4da4-8c91-00e2b18078b2"),
                column: "Name",
                value: "AT-AT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("acb956e0-7a1f-48c1-b100-7e9f35d9411b"),
                column: "Name",
                value: "50PUS8079");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c06435a9-1913-4a52-a415-01c93753c388"),
                column: "Name",
                value: "Call of duty");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c2dc45ee-9bb0-42e9-b625-aeddc53da952"),
                column: "Name",
                value: "Counter strike 2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c956850a-e488-420f-8611-dd30849aaa8e"),
                column: "Name",
                value: "R2-D2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e0799875-c7cd-4c34-b119-9ce3d9f5f742"),
                column: "Name",
                value: "48OLED708");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e5c7929a-956d-4e29-9b86-22f472430933"),
                column: "Name",
                value: "Read dead redemption");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"),
                column: "Name",
                value: "Legetøj");

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"),
                column: "Name",
                value: "Tv");

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"),
                column: "Name",
                value: "Tøj");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("42532caa-0a7f-4556-bcb2-43113ddb7386"),
                column: "Name",
                value: "Phillips");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("5f708c2e-5497-4b8f-a8e2-d393d7ef1540"),
                column: "Name",
                value: "Nike");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("91414760-4cef-4da4-8c91-00e2b18078b2"),
                column: "Name",
                value: "Puma");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("acb956e0-7a1f-48c1-b100-7e9f35d9411b"),
                column: "Name",
                value: "LG");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c06435a9-1913-4a52-a415-01c93753c388"),
                column: "Name",
                value: "Lego");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c2dc45ee-9bb0-42e9-b625-aeddc53da952"),
                column: "Name",
                value: "Bamser");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c956850a-e488-420f-8611-dd30849aaa8e"),
                column: "Name",
                value: "Peak");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e0799875-c7cd-4c34-b119-9ce3d9f5f742"),
                column: "Name",
                value: "Prosonic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("e5c7929a-956d-4e29-9b86-22f472430933"),
                column: "Name",
                value: "Brætspil");
        }
    }
}
