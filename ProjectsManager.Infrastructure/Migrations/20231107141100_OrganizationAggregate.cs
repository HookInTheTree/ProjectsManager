using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectsManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OrganizationAggregate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JuridicalAddress_PostalСode_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuridicalAddress_PhysicalAddress_State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuridicalAddress_PhysicalAddress_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuridicalAddress_PhysicalAddress_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuridicalAddress_PhysicalAddress_Building = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_WebSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationEmployeesIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationEmployeesIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationEmployeesIds_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationProjectsIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationProjectsIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationProjectsIds_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationEmployeesIds_OrganizationId",
                table: "OrganizationEmployeesIds",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationProjectsIds_OrganizationId",
                table: "OrganizationProjectsIds",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationEmployeesIds");

            migrationBuilder.DropTable(
                name: "OrganizationProjectsIds");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
