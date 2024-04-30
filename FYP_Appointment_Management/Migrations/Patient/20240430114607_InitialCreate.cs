using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FYP_Appointment_Management.Migrations.Patient
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
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
                    table.PrimaryKey("PK_Patients", x => x.Patient_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
