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
                    { 1, "EKYQGUS" },
                    { 24, "HZFEUAB" },
                    { 25, "XXLBVJZ" },
                    { 26, "QDYQUZT" },
                    { 27, "ECXDGOH" },
                    { 28, "ETLFADW" },
                    { 29, "LISKEFZ" },
                    { 30, "BDBGQZY" },
                    { 31, "MVPQNAD" },
                    { 32, "WIANMTS" },
                    { 33, "DZVUGCE" },
                    { 34, "VFFQTUC" },
                    { 35, "YVXQPIS" },
                    { 36, "XVONCTP" },
                    { 37, "ARXRLHY" },
                    { 38, "EFLKWUQ" },
                    { 39, "QKATGAX" },
                    { 40, "MDXXKZF" },
                    { 23, "PPTGKMU" },
                    { 22, "WYPCBZY" },
                    { 21, "ELOXFEG" },
                    { 20, "XUNRQNY" },
                    { 2, "TSEKHIW" },
                    { 3, "LBOHBHL" },
                    { 4, "PILWUWB" },
                    { 5, "GAMFVFV" },
                    { 6, "URJVQMW" },
                    { 7, "AUWURDB" },
                    { 8, "BQXDBYP" },
                    { 9, "BNUMXRM" },
                    { 41, "DGGDJPV" },
                    { 10, "SSEMCBR" },
                    { 12, "OOCCTZE" },
                    { 13, "JPCUHFS" },
                    { 14, "EOJTUJI" },
                    { 15, "BRHPBJR" },
                    { 16, "LKRGJAN" },
                    { 17, "YRKDRII" },
                    { 18, "DBRVVYF" },
                    { 19, "QDSAFGM" },
                    { 11, "JFMLVOO" },
                    { 42, "NIYINEU" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArrivalStation", "Currency", "DepartureDate", "DepartureStation", "Price", "TransportId" },
                values: new object[,]
                {
                    { 1, "MED", "COP", new DateTime(2020, 10, 29, 8, 8, 1, 985, DateTimeKind.Local).AddTicks(9712), "BOG", 173703m, 1 },
                    { 24, "CTG", "COP", new DateTime(2020, 10, 30, 13, 8, 1, 989, DateTimeKind.Local).AddTicks(9), "BOG", 155053m, 24 },
                    { 25, "PEI", "COP", new DateTime(2020, 10, 30, 6, 8, 1, 989, DateTimeKind.Local).AddTicks(14), "BOG", 108246m, 25 },
                    { 26, "PEI", "COP", new DateTime(2020, 10, 30, 12, 8, 1, 989, DateTimeKind.Local).AddTicks(18), "BOG", 157859m, 26 },
                    { 27, "BOG", "COP", new DateTime(2020, 10, 30, 6, 8, 1, 989, DateTimeKind.Local).AddTicks(22), "PEI", 205883m, 27 },
                    { 28, "BOG", "COP", new DateTime(2020, 10, 30, 13, 8, 1, 989, DateTimeKind.Local).AddTicks(26), "PEI", 276634m, 28 },
                    { 29, "MED", "COP", new DateTime(2020, 10, 31, 8, 8, 1, 989, DateTimeKind.Local).AddTicks(30), "BOG", 165642m, 29 },
                    { 30, "MED", "COP", new DateTime(2020, 10, 31, 10, 8, 1, 989, DateTimeKind.Local).AddTicks(34), "BOG", 104520m, 30 },
                    { 31, "MED", "COP", new DateTime(2020, 10, 31, 13, 8, 1, 989, DateTimeKind.Local).AddTicks(38), "BOG", 173565m, 31 },
                    { 32, "BOG", "COP", new DateTime(2020, 10, 31, 8, 8, 1, 989, DateTimeKind.Local).AddTicks(43), "MED", 246902m, 32 },
                    { 33, "BOG", "COP", new DateTime(2020, 10, 31, 11, 8, 1, 989, DateTimeKind.Local).AddTicks(47), "MED", 256023m, 33 },
                    { 34, "BOG", "COP", new DateTime(2020, 10, 31, 13, 8, 1, 989, DateTimeKind.Local).AddTicks(54), "MED", 294531m, 34 },
                    { 35, "BOG", "COP", new DateTime(2020, 10, 31, 6, 8, 1, 989, DateTimeKind.Local).AddTicks(268), "CTG", 221191m, 35 },
                    { 36, "BOG", "COP", new DateTime(2020, 10, 31, 11, 8, 1, 989, DateTimeKind.Local).AddTicks(277), "CTG", 178487m, 36 },
                    { 37, "CTG", "COP", new DateTime(2020, 10, 31, 10, 8, 1, 989, DateTimeKind.Local).AddTicks(282), "BOG", 212495m, 37 },
                    { 38, "CTG", "COP", new DateTime(2020, 10, 31, 13, 8, 1, 989, DateTimeKind.Local).AddTicks(285), "BOG", 254912m, 38 },
                    { 39, "PEI", "COP", new DateTime(2020, 10, 31, 6, 8, 1, 989, DateTimeKind.Local).AddTicks(290), "BOG", 254679m, 39 },
                    { 40, "PEI", "COP", new DateTime(2020, 10, 31, 12, 8, 1, 989, DateTimeKind.Local).AddTicks(294), "BOG", 181934m, 40 },
                    { 23, "CTG", "COP", new DateTime(2020, 10, 30, 10, 8, 1, 989, DateTimeKind.Local).AddTicks(4), "BOG", 286596m, 23 },
                    { 22, "BOG", "COP", new DateTime(2020, 10, 30, 11, 8, 1, 988, DateTimeKind.Local).AddTicks(9998), "CTG", 165319m, 22 },
                    { 21, "BOG", "COP", new DateTime(2020, 10, 30, 6, 8, 1, 988, DateTimeKind.Local).AddTicks(9994), "CTG", 164648m, 21 },
                    { 20, "BOG", "COP", new DateTime(2020, 10, 30, 13, 8, 1, 988, DateTimeKind.Local).AddTicks(9990), "MED", 154703m, 20 },
                    { 2, "MED", "COP", new DateTime(2020, 10, 29, 10, 8, 1, 988, DateTimeKind.Local).AddTicks(9660), "BOG", 190851m, 2 },
                    { 3, "MED", "COP", new DateTime(2020, 10, 29, 13, 8, 1, 988, DateTimeKind.Local).AddTicks(9829), "BOG", 147335m, 3 },
                    { 4, "BOG", "COP", new DateTime(2020, 10, 29, 8, 8, 1, 988, DateTimeKind.Local).AddTicks(9838), "MED", 270685m, 4 },
                    { 5, "BOG", "COP", new DateTime(2020, 10, 29, 11, 8, 1, 988, DateTimeKind.Local).AddTicks(9842), "MED", 229320m, 5 },
                    { 6, "BOG", "COP", new DateTime(2020, 10, 29, 13, 8, 1, 988, DateTimeKind.Local).AddTicks(9860), "MED", 151898m, 6 },
                    { 7, "BOG", "COP", new DateTime(2020, 10, 29, 6, 8, 1, 988, DateTimeKind.Local).AddTicks(9865), "CTG", 222903m, 7 },
                    { 8, "BOG", "COP", new DateTime(2020, 10, 29, 11, 8, 1, 988, DateTimeKind.Local).AddTicks(9869), "CTG", 126846m, 8 },
                    { 9, "CTG", "COP", new DateTime(2020, 10, 29, 10, 8, 1, 988, DateTimeKind.Local).AddTicks(9872), "BOG", 150476m, 9 },
                    { 41, "BOG", "COP", new DateTime(2020, 10, 31, 6, 8, 1, 989, DateTimeKind.Local).AddTicks(298), "PEI", 267624m, 41 },
                    { 10, "CTG", "COP", new DateTime(2020, 10, 29, 13, 8, 1, 988, DateTimeKind.Local).AddTicks(9879), "BOG", 248798m, 10 },
                    { 12, "PEI", "COP", new DateTime(2020, 10, 29, 12, 8, 1, 988, DateTimeKind.Local).AddTicks(9888), "BOG", 223667m, 12 },
                    { 13, "BOG", "COP", new DateTime(2020, 10, 29, 6, 8, 1, 988, DateTimeKind.Local).AddTicks(9892), "PEI", 222275m, 13 },
                    { 14, "BOG", "COP", new DateTime(2020, 10, 29, 13, 8, 1, 988, DateTimeKind.Local).AddTicks(9896), "PEI", 253286m, 14 },
                    { 15, "MED", "COP", new DateTime(2020, 10, 30, 8, 8, 1, 988, DateTimeKind.Local).AddTicks(9900), "BOG", 246755m, 15 },
                    { 16, "MED", "COP", new DateTime(2020, 10, 30, 10, 8, 1, 988, DateTimeKind.Local).AddTicks(9968), "BOG", 218383m, 16 },
                    { 17, "MED", "COP", new DateTime(2020, 10, 30, 13, 8, 1, 988, DateTimeKind.Local).AddTicks(9973), "BOG", 205397m, 17 },
                    { 18, "BOG", "COP", new DateTime(2020, 10, 30, 8, 8, 1, 988, DateTimeKind.Local).AddTicks(9982), "MED", 265874m, 18 },
                    { 19, "BOG", "COP", new DateTime(2020, 10, 30, 11, 8, 1, 988, DateTimeKind.Local).AddTicks(9986), "MED", 105001m, 19 },
                    { 11, "PEI", "COP", new DateTime(2020, 10, 29, 6, 8, 1, 988, DateTimeKind.Local).AddTicks(9883), "BOG", 268263m, 11 },
                    { 42, "BOG", "COP", new DateTime(2020, 10, 31, 13, 8, 1, 989, DateTimeKind.Local).AddTicks(302), "PEI", 206069m, 42 }
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
