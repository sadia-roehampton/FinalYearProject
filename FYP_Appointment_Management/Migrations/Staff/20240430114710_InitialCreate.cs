using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FYP_Appointment_Management.Migrations.Staff
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
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
                    table.PrimaryKey("PK_Staffs", x => x.Staff_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
