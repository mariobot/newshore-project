using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewShore.Persistence.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureStation = table.Column<string>(nullable: true),
                    ArrivalStation = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    TransportId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePasanger = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailContact = table.Column<string>(nullable: false),
                    FlightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "FlightNumber" },
                values: new object[,]
                {
                    { 1, "JFZDACJ" },
                    { 24, "NMMLCHE" },
                    { 25, "ATDQXTG" },
                    { 26, "AXLKQMZ" },
                    { 27, "TIFWUII" },
                    { 28, "NWYWFWW" },
                    { 29, "TPOSJKG" },
                    { 30, "XJYTXLN" },
                    { 31, "VIKMDFU" },
                    { 32, "DGOIZVN" },
                    { 33, "WFTRXKH" },
                    { 34, "HXRHCTV" },
                    { 35, "ZHCWXVR" },
                    { 36, "ONJCRCP" },
                    { 37, "JZKKOSB" },
                    { 38, "DEBAAGN" },
                    { 39, "LTFAMYE" },
                    { 40, "ZLLCAWH" },
                    { 23, "OSUVDPF" },
                    { 22, "HQMPRRR" },
                    { 21, "KFBAVRO" },
                    { 20, "XGRTAVB" },
                    { 2, "DDNSALN" },
                    { 3, "WBNUFKR" },
                    { 4, "WPGYRLG" },
                    { 5, "WUPYRZX" },
                    { 6, "PJSJAJR" },
                    { 7, "WGOATRT" },
                    { 8, "JGILIYN" },
                    { 9, "QTEIQDG" },
                    { 41, "RJOGHRY" },
                    { 10, "JYTIMQH" },
                    { 12, "IRXYUMN" },
                    { 13, "NHNJAKZ" },
                    { 14, "QNBJGLN" },
                    { 15, "IURGBMR" },
                    { 16, "LXHHZOH" },
                    { 17, "BGKWRTV" },
                    { 18, "QGZMFIB" },
                    { 19, "GJVVOLA" },
                    { 11, "RULEBZZ" },
                    { 42, "XGXNATV" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArrivalStation", "Currency", "DepartureDate", "DepartureStation", "Price", "TransportId" },
                values: new object[,]
                {
                    { 1, "MED", "COP", new DateTime(2020, 11, 2, 7, 23, 17, 645, DateTimeKind.Local).AddTicks(9438), "BOG", 116858m, 1 },
                    { 24, "CTG", "COP", new DateTime(2020, 11, 3, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5352), "BOG", 182951m, 24 },
                    { 25, "PEI", "COP", new DateTime(2020, 11, 3, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5355), "BOG", 296283m, 25 },
                    { 26, "PEI", "COP", new DateTime(2020, 11, 3, 11, 23, 17, 649, DateTimeKind.Local).AddTicks(5359), "BOG", 130376m, 26 },
                    { 27, "BOG", "COP", new DateTime(2020, 11, 3, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5362), "PEI", 250390m, 27 },
                    { 28, "BOG", "COP", new DateTime(2020, 11, 3, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5366), "PEI", 207788m, 28 },
                    { 29, "MED", "COP", new DateTime(2020, 11, 4, 7, 23, 17, 649, DateTimeKind.Local).AddTicks(5370), "BOG", 125538m, 29 },
                    { 30, "MED", "COP", new DateTime(2020, 11, 4, 9, 23, 17, 649, DateTimeKind.Local).AddTicks(5374), "BOG", 155922m, 30 },
                    { 31, "MED", "COP", new DateTime(2020, 11, 4, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5377), "BOG", 161133m, 31 },
                    { 32, "BOG", "COP", new DateTime(2020, 11, 4, 7, 23, 17, 649, DateTimeKind.Local).AddTicks(5381), "MED", 252037m, 32 },
                    { 33, "BOG", "COP", new DateTime(2020, 11, 4, 10, 23, 17, 649, DateTimeKind.Local).AddTicks(5483), "MED", 202058m, 33 },
                    { 34, "BOG", "COP", new DateTime(2020, 11, 4, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5492), "MED", 281553m, 34 },
                    { 35, "BOG", "COP", new DateTime(2020, 11, 4, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5495), "CTG", 265449m, 35 },
                    { 36, "BOG", "COP", new DateTime(2020, 11, 4, 10, 23, 17, 649, DateTimeKind.Local).AddTicks(5499), "CTG", 181726m, 36 },
                    { 37, "CTG", "COP", new DateTime(2020, 11, 4, 9, 23, 17, 649, DateTimeKind.Local).AddTicks(5502), "BOG", 108422m, 37 },
                    { 38, "CTG", "COP", new DateTime(2020, 11, 4, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5506), "BOG", 181426m, 38 },
                    { 39, "PEI", "COP", new DateTime(2020, 11, 4, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5510), "BOG", 285744m, 39 },
                    { 40, "PEI", "COP", new DateTime(2020, 11, 4, 11, 23, 17, 649, DateTimeKind.Local).AddTicks(5513), "BOG", 294465m, 40 },
                    { 23, "CTG", "COP", new DateTime(2020, 11, 3, 9, 23, 17, 649, DateTimeKind.Local).AddTicks(5348), "BOG", 120082m, 23 },
                    { 22, "BOG", "COP", new DateTime(2020, 11, 3, 10, 23, 17, 649, DateTimeKind.Local).AddTicks(5344), "CTG", 140812m, 22 },
                    { 21, "BOG", "COP", new DateTime(2020, 11, 3, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5341), "CTG", 179157m, 21 },
                    { 20, "BOG", "COP", new DateTime(2020, 11, 3, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5338), "MED", 140624m, 20 },
                    { 2, "MED", "COP", new DateTime(2020, 11, 2, 9, 23, 17, 649, DateTimeKind.Local).AddTicks(5079), "BOG", 149648m, 2 },
                    { 3, "MED", "COP", new DateTime(2020, 11, 2, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5216), "BOG", 108912m, 3 },
                    { 4, "BOG", "COP", new DateTime(2020, 11, 2, 7, 23, 17, 649, DateTimeKind.Local).AddTicks(5224), "MED", 122790m, 4 },
                    { 5, "BOG", "COP", new DateTime(2020, 11, 2, 10, 23, 17, 649, DateTimeKind.Local).AddTicks(5227), "MED", 200726m, 5 },
                    { 6, "BOG", "COP", new DateTime(2020, 11, 2, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5242), "MED", 293318m, 6 },
                    { 7, "BOG", "COP", new DateTime(2020, 11, 2, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5246), "CTG", 200156m, 7 },
                    { 8, "BOG", "COP", new DateTime(2020, 11, 2, 10, 23, 17, 649, DateTimeKind.Local).AddTicks(5250), "CTG", 168094m, 8 },
                    { 9, "CTG", "COP", new DateTime(2020, 11, 2, 9, 23, 17, 649, DateTimeKind.Local).AddTicks(5254), "BOG", 256355m, 9 },
                    { 41, "BOG", "COP", new DateTime(2020, 11, 4, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5517), "PEI", 234406m, 41 },
                    { 10, "CTG", "COP", new DateTime(2020, 11, 2, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5259), "BOG", 106760m, 10 },
                    { 12, "PEI", "COP", new DateTime(2020, 11, 2, 11, 23, 17, 649, DateTimeKind.Local).AddTicks(5266), "BOG", 108373m, 12 },
                    { 13, "BOG", "COP", new DateTime(2020, 11, 2, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5269), "PEI", 232990m, 13 },
                    { 14, "BOG", "COP", new DateTime(2020, 11, 2, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5272), "PEI", 236346m, 14 },
                    { 15, "MED", "COP", new DateTime(2020, 11, 3, 7, 23, 17, 649, DateTimeKind.Local).AddTicks(5275), "BOG", 220240m, 15 },
                    { 16, "MED", "COP", new DateTime(2020, 11, 3, 9, 23, 17, 649, DateTimeKind.Local).AddTicks(5319), "BOG", 254986m, 16 },
                    { 17, "MED", "COP", new DateTime(2020, 11, 3, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5323), "BOG", 183217m, 17 },
                    { 18, "BOG", "COP", new DateTime(2020, 11, 3, 7, 23, 17, 649, DateTimeKind.Local).AddTicks(5330), "MED", 108963m, 18 },
                    { 19, "BOG", "COP", new DateTime(2020, 11, 3, 10, 23, 17, 649, DateTimeKind.Local).AddTicks(5333), "MED", 114957m, 19 },
                    { 11, "PEI", "COP", new DateTime(2020, 11, 2, 5, 23, 17, 649, DateTimeKind.Local).AddTicks(5262), "BOG", 268410m, 11 },
                    { 42, "BOG", "COP", new DateTime(2020, 11, 4, 12, 23, 17, 649, DateTimeKind.Local).AddTicks(5520), "PEI", 113006m, 42 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "EmailContact", "FlightId", "NamePasanger", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "mariobot@hotmail.com", 10, "Mario Botero", "5764821565" },
                    { 2, "cmejia@hotmail.com", 20, "Carolina gomez", "5732456215" },
                    { 3, "mmejia@gmail.com", 30, "Maria Mejia", "5755662245" },
                    { 4, "fernando23@gmail.com", 40, "Fernanda Ferrero", "57545562" },
                    { 5, "cmejia@hotmail.com", 42, "Camilo Mejia", "574455665" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_TransportId",
                table: "Flights",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FlightId",
                table: "Tickets",
                column: "FlightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Transports");
        }
    }
}
