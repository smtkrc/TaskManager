using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.DepartmanId);
                });

            migrationBuilder.CreateTable(
                name: "TaskDurums",
                columns: table => new
                {
                    DurumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurumAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDurums", x => x.DurumId);
                });

            migrationBuilder.CreateTable(
                name: "TaskOnceliks",
                columns: table => new
                {
                    OncelikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OncelikAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskOnceliks", x => x.OncelikId);
                });

            migrationBuilder.CreateTable(
                name: "Yetkis",
                columns: table => new
                {
                    YetkiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkis", x => x.YetkiId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: false),
                    YetkiId = table.Column<int>(type: "int", nullable: false),
                    PersonelEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelSifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personels_Departmans_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmans",
                        principalColumn: "DepartmanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personels_Yetkis_YetkiId",
                        column: x => x.YetkiId,
                        principalTable: "Yetkis",
                        principalColumn: "YetkiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskDetays",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskOlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurumId = table.Column<int>(type: "int", nullable: false),
                    TaskDurumDurumId = table.Column<int>(type: "int", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    OncelikId = table.Column<int>(type: "int", nullable: false),
                    TaskOncelikOncelikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDetays", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_TaskDetays_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDetays_TaskDurums_TaskDurumDurumId",
                        column: x => x.TaskDurumDurumId,
                        principalTable: "TaskDurums",
                        principalColumn: "DurumId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskDetays_TaskOnceliks_TaskOncelikOncelikId",
                        column: x => x.TaskOncelikOncelikId,
                        principalTable: "TaskOnceliks",
                        principalColumn: "OncelikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAksiyons",
                columns: table => new
                {
                    AksiyonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AksiyonAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    AksiyonKayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AksiyonBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AksiyonBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskDetayTaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAksiyons", x => x.AksiyonId);
                    table.ForeignKey(
                        name: "FK_TaskAksiyons_TaskDetays_TaskDetayTaskId",
                        column: x => x.TaskDetayTaskId,
                        principalTable: "TaskDetays",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskDokumans",
                columns: table => new
                {
                    DokumanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DokumanBaslık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DokumanAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DokumanUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TaskDetayTaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDokumans", x => x.DokumanId);
                    table.ForeignKey(
                        name: "FK_TaskDokumans_TaskDetays_TaskDetayTaskId",
                        column: x => x.TaskDetayTaskId,
                        principalTable: "TaskDetays",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanId",
                table: "Personels",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_YetkiId",
                table: "Personels",
                column: "YetkiId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAksiyons_TaskDetayTaskId",
                table: "TaskAksiyons",
                column: "TaskDetayTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetays_PersonelId",
                table: "TaskDetays",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetays_TaskDurumDurumId",
                table: "TaskDetays",
                column: "TaskDurumDurumId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetays_TaskOncelikOncelikId",
                table: "TaskDetays",
                column: "TaskOncelikOncelikId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDokumans_TaskDetayTaskId",
                table: "TaskDokumans",
                column: "TaskDetayTaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskAksiyons");

            migrationBuilder.DropTable(
                name: "TaskDokumans");

            migrationBuilder.DropTable(
                name: "TaskDetays");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "TaskDurums");

            migrationBuilder.DropTable(
                name: "TaskOnceliks");

            migrationBuilder.DropTable(
                name: "Departmans");

            migrationBuilder.DropTable(
                name: "Yetkis");
        }
    }
}
