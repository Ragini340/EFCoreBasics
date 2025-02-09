using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBasics.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MngLastName",
                table: "Managers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "MngFirstName",
                table: "Managers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "EmpSalary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "EmpLastName",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "EmpFirstName",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Managers_ManagerId",
                table: "Employees",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Managers_ManagerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Managers",
                newName: "MngLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Managers",
                newName: "MngFirstName");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "EmpSalary");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "EmpLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "EmpFirstName");
        }
    }
}
