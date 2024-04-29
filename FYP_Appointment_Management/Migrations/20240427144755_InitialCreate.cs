using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FYP_Appointment_Management.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Dept_Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Patient_Phone = table.Column<int>(type: "int", nullable: false),
                    Patient_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Patient_Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Staff_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Staff_Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Staff_Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Staff_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Staff_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
