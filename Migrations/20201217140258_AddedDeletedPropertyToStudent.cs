using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Katja.Migrations
{
    public partial class AddedDeletedPropertyToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("2091a967-d859-45bb-bd59-f768ff4adbdd"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("2b9cc46b-8c5e-4ac5-ae44-8bec7bceb139"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("3f6bde30-d3ed-4406-b160-079729d7adb4"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("64ccfdf2-37a9-420b-bea8-154b3e6ec65a"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("e4aa3d04-6cda-47d6-8101-5fc74647d28e"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("e999d154-d9a9-47ea-88cb-2418b79998ba"));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("04a772a4-9801-4e2c-a38a-db00c9156176"), "First test...", 5, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("e2e88444-3536-4c7b-b340-1cc0b2c84cc6"), "Second test...", 4, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("ff578746-bdaa-4de6-a907-f78e5addc453"), "First test...", 3, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("d7ee5482-5200-4845-841b-42873a2237a3"), "Last test...", 2, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("a2e3870c-a0c8-433b-a8e3-2f90aed97af5"), "First test...", 5, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") },
                    { new Guid("7c95e27a-1f0b-4988-8759-24945135d722"), "Last test...", 3, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("04a772a4-9801-4e2c-a38a-db00c9156176"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("7c95e27a-1f0b-4988-8759-24945135d722"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("a2e3870c-a0c8-433b-a8e3-2f90aed97af5"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("d7ee5482-5200-4845-841b-42873a2237a3"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("e2e88444-3536-4c7b-b340-1cc0b2c84cc6"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("ff578746-bdaa-4de6-a907-f78e5addc453"));

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Student");

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("3f6bde30-d3ed-4406-b160-079729d7adb4"), "First test...", 5, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("e999d154-d9a9-47ea-88cb-2418b79998ba"), "Second test...", 4, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("2b9cc46b-8c5e-4ac5-ae44-8bec7bceb139"), "First test...", 3, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("e4aa3d04-6cda-47d6-8101-5fc74647d28e"), "Last test...", 2, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("2091a967-d859-45bb-bd59-f768ff4adbdd"), "First test...", 5, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") },
                    { new Guid("64ccfdf2-37a9-420b-bea8-154b3e6ec65a"), "Last test...", 3, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") }
                });
        }
    }
}
