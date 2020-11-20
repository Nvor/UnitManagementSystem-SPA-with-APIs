using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitMonitoringSystem.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstanceId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Units_Instances_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "ID", "Created", "Description", "Modified", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An item collection for recording aquatic species and vegetation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Aquarium" });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "ID", "Created", "Description", "Modified", "Name" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Things we should probably take care of at some point", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To-Do List" });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "ID", "Created", "Description", "Modified", "Name" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hey there Hercules! What do you bench? How many reps? Let the gym know!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gymnasium" });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "ID", "Created", "Description", "InstanceId", "Modified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 9, 22, 13, 56, 830, DateTimeKind.Local).AddTicks(4414), "Description 1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 1" },
                    { 2, new DateTime(2020, 11, 10, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7302), "Description 2", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 2" },
                    { 3, new DateTime(2020, 11, 11, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7361), "Description 3", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 3" },
                    { 4, new DateTime(2020, 11, 12, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7367), "Description 4", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 4" },
                    { 5, new DateTime(2020, 11, 13, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7371), "Description 5", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 5" },
                    { 6, new DateTime(2020, 11, 14, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7374), "Description 6", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 6" },
                    { 7, new DateTime(2020, 11, 15, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7377), "Description 7", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 7" },
                    { 8, new DateTime(2020, 11, 16, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7380), "Description 8", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 8" },
                    { 9, new DateTime(2020, 11, 17, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7383), "Description 9", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 9" },
                    { 10, new DateTime(2020, 11, 18, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7386), "Description 10", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 10" },
                    { 11, new DateTime(2020, 11, 9, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7389), "Description 1", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 1" },
                    { 12, new DateTime(2020, 11, 10, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7392), "Description 2", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 2" },
                    { 13, new DateTime(2020, 11, 11, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7396), "Description 3", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 3" },
                    { 14, new DateTime(2020, 11, 9, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7399), "Description 1", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 1" },
                    { 15, new DateTime(2020, 11, 10, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7402), "Description 2", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 2" },
                    { 16, new DateTime(2020, 11, 11, 22, 13, 56, 833, DateTimeKind.Local).AddTicks(7405), "Description 3", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Unit 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Units_InstanceId",
                table: "Units",
                column: "InstanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Instances");
        }
    }
}
