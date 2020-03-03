using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database2.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emptb",
                columns: table => new
                {
                    EmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    ServiceID = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emptb", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "patienttb",
                columns: table => new
                {
                    PatrientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<float>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patienttb", x => x.PatrientID);
                });

            migrationBuilder.CreateTable(
                name: "roomtb",
                columns: table => new
                {
                    RoomNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BayArea = table.Column<string>(nullable: true),
                    ServiceID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomtb", x => x.RoomNo);
                });

            migrationBuilder.CreateTable(
                name: "servicetb",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(nullable: true),
                    BayArea = table.Column<string>(nullable: true),
                    AvgServiceTimeSec = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicetb", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "servicetokenstandhistorytb",
                columns: table => new
                {
                    ServiceTokenHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTokenID = table.Column<int>(nullable: false),
                    ServiceRoomID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false),
                    TimeSpentSec = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicetokenstandhistorytb", x => x.ServiceTokenHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "servicetokentb",
                columns: table => new
                {
                    ServiceTokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceID = table.Column<int>(nullable: false),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    Patient = table.Column<int>(nullable: false),
                    ServiceTokenDate = table.Column<DateTime>(nullable: false),
                    ServiceTokenQueueNo = table.Column<int>(nullable: false),
                    CurrentStatusID = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicetokentb", x => x.ServiceTokenID);
                });

            migrationBuilder.CreateTable(
                name: "statustb",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusText = table.Column<string>(nullable: true),
                    StatusGroup = table.Column<string>(nullable: true),
                    StatusOrder = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statustb", x => x.StatusID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emptb");

            migrationBuilder.DropTable(
                name: "patienttb");

            migrationBuilder.DropTable(
                name: "roomtb");

            migrationBuilder.DropTable(
                name: "servicetb");

            migrationBuilder.DropTable(
                name: "servicetokenstandhistorytb");

            migrationBuilder.DropTable(
                name: "servicetokentb");

            migrationBuilder.DropTable(
                name: "statustb");
        }
    }
}
