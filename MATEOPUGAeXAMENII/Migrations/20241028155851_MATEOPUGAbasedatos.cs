using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATEOPUGAeXAMENII.Migrations
{
    /// <inheritdoc />
    public partial class MATEOPUGAbasedatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPLIBRO",
                columns: table => new
                {
                    MP_LibroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MP_NombreLibro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MP_Autor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MP_HoraAgregacion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MP_FechaPublicacion = table.Column<int>(type: "int", nullable: false),
                    MP_Nuevo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPLIBRO", x => x.MP_LibroID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPLIBRO");
        }
    }
}
