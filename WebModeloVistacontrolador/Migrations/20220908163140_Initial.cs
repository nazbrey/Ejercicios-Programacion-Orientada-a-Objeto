using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebModeloVistacontrolador.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enterprises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coordinator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnterpriseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinator_Enterprises_EnterpriseId1",
                        column: x => x.EnterpriseId1,
                        principalTable: "Enterprises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    CoordinatorId = table.Column<int>(type: "int", nullable: true),
                    EnterpriseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Coordinator_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinator",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Works_Enterprises_EnterpriseId1",
                        column: x => x.EnterpriseId1,
                        principalTable: "Enterprises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_EnterpriseId1",
                table: "Coordinator",
                column: "EnterpriseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Works_CoordinatorId",
                table: "Works",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_EnterpriseId1",
                table: "Works",
                column: "EnterpriseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Coordinator");

            migrationBuilder.DropTable(
                name: "Enterprises");
        }
    }
}
