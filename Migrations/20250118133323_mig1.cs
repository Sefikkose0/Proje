using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webprojesi.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deneyimler",
                columns: table => new
                {
                    DeneyimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListeBasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deneyimler", x => x.DeneyimId);
                });

            migrationBuilder.CreateTable(
                name: "Hakkındakiler",
                columns: table => new
                {
                    HakkindaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detaylar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkındakiler", x => x.HakkindaId);
                });

            migrationBuilder.CreateTable(
                name: "Iletisimler",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisimler", x => x.IletisimId);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlar",
                columns: table => new
                {
                    MesajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GonderimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Okundumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlar", x => x.MesajId);
                });

            migrationBuilder.CreateTable(
                name: "Ozellikler",
                columns: table => new
                {
                    OzellikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ozellikler", x => x.OzellikId);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimBaglanti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioId);
                });

            migrationBuilder.CreateTable(
                name: "Referanslar",
                columns: table => new
                {
                    ReferansId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimBaglanti = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referanslar", x => x.ReferansId);
                });

            migrationBuilder.CreateTable(
                name: "SosyalMedyalar",
                columns: table => new
                {
                    SosyalMedyaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ikon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalMedyalar", x => x.SosyalMedyaId);
                });

            migrationBuilder.CreateTable(
                name: "Yetenekler",
                columns: table => new
                {
                    YetenekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetenekler", x => x.YetenekId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deneyimler");

            migrationBuilder.DropTable(
                name: "Hakkındakiler");

            migrationBuilder.DropTable(
                name: "Iletisimler");

            migrationBuilder.DropTable(
                name: "Mesajlar");

            migrationBuilder.DropTable(
                name: "Ozellikler");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Referanslar");

            migrationBuilder.DropTable(
                name: "SosyalMedyalar");

            migrationBuilder.DropTable(
                name: "Yetenekler");
        }
    }
}
