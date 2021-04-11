using Microsoft.EntityFrameworkCore.Migrations;

namespace SCMVCWebApp.Migrations
{
    public partial class AddedCompanyConsultant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyConsultant",
                columns: table => new
                {
                    CompanyConsultantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyConsultant", x => x.CompanyConsultantID);
                    table.ForeignKey(
                        name: "FK_CompanyConsultant_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyConsultant_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyConsultant_CompanyID",
                table: "CompanyConsultant",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyConsultant_ConsultantId",
                table: "CompanyConsultant",
                column: "ConsultantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyConsultant");
        }
    }
}
