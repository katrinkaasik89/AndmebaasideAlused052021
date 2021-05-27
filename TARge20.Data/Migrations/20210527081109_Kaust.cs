using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class Kaust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HaigusleheAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaigusleheLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenutuskord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutatavEse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutuskord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutuskord_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuluba",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoaLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LigipääsuTyyp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuluba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipääsuluba_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Palved",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Saaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saatja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PalveKpv = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palved", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palved_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    puhkuseTyyp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    puhkuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    puhkuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontrollid",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tulemus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontrollid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontrollid_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Töösuhe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TöösuhteAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöösuhteLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Koormus = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töösuhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Töösuhe_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Saaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VihjeKpv = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vihjed_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HaigusleheTyyp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaiguslehedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaigusleheTyyp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HaigusleheTyyp_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HaigusleheTyyp_Haiguslehed_HaiguslehedId",
                        column: x => x.HaiguslehedId,
                        principalTable: "Haiguslehed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaenutatavEse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsemeNimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaenutuskordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaenutatavEse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaenutatavEse_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LaenutatavEse_Laenutuskord_LaenutuskordId",
                        column: x => x.LaenutuskordId,
                        principalTable: "Laenutuskord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LigipääsuloaTyyp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ligipääs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigipääsulubaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigipääsuloaTyyp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LigipääsuloaTyyp_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LigipääsuloaTyyp_Ligipääsuluba_LigipääsulubaId",
                        column: x => x.LigipääsulubaId,
                        principalTable: "Ligipääsuluba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PuhkuseTyyp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    puhkusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuhkuseTyyp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuhkuseTyyp_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PuhkuseTyyp_Puhkus_puhkusId",
                        column: x => x.puhkusId,
                        principalTable: "Puhkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_EmployeeId",
                table: "Children",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_EmployeeId",
                table: "Haiguslehed",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HaigusleheTyyp_EmployeeId",
                table: "HaigusleheTyyp",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HaigusleheTyyp_HaiguslehedId",
                table: "HaigusleheTyyp",
                column: "HaiguslehedId");

            migrationBuilder.CreateIndex(
                name: "IX_LaenutatavEse_EmployeeId",
                table: "LaenutatavEse",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LaenutatavEse_LaenutuskordId",
                table: "LaenutatavEse",
                column: "LaenutuskordId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutuskord_EmployeeId",
                table: "Laenutuskord",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LigipääsuloaTyyp_EmployeeId",
                table: "LigipääsuloaTyyp",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LigipääsuloaTyyp_LigipääsulubaId",
                table: "LigipääsuloaTyyp",
                column: "LigipääsulubaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuluba_EmployeeId",
                table: "Ligipääsuluba",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Palved_EmployeeId",
                table: "Palved",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkus_EmployeeId",
                table: "Puhkus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PuhkuseTyyp_EmployeeId",
                table: "PuhkuseTyyp",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PuhkuseTyyp_puhkusId",
                table: "PuhkuseTyyp",
                column: "puhkusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontrollid_EmployeeId",
                table: "Tervisekontrollid",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Töösuhe_EmployeeId",
                table: "Töösuhe",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vihjed_EmployeeId",
                table: "Vihjed",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "HaigusleheTyyp");

            migrationBuilder.DropTable(
                name: "LaenutatavEse");

            migrationBuilder.DropTable(
                name: "LigipääsuloaTyyp");

            migrationBuilder.DropTable(
                name: "Palved");

            migrationBuilder.DropTable(
                name: "PuhkuseTyyp");

            migrationBuilder.DropTable(
                name: "Tervisekontrollid");

            migrationBuilder.DropTable(
                name: "Töösuhe");

            migrationBuilder.DropTable(
                name: "Vihjed");

            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutuskord");

            migrationBuilder.DropTable(
                name: "Ligipääsuluba");

            migrationBuilder.DropTable(
                name: "Puhkus");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
