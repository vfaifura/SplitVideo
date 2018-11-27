using Microsoft.EntityFrameworkCore.Migrations;

namespace EmotionMarketing.Domain.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actual_result",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    emotion_id = table.Column<int>(nullable: false),
                    project_id = table.Column<int>(nullable: false),
                    time_index = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actual_result", x => x.id);
                    table.ForeignKey(
                        name: "FK_actual_result_emotion_emotion_id",
                        column: x => x.emotion_id,
                        principalTable: "emotion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actual_result_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actual_result_emotion_id",
                table: "actual_result",
                column: "emotion_id");

            migrationBuilder.CreateIndex(
                name: "IX_actual_result_project_id",
                table: "actual_result",
                column: "project_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actual_result");
        }
    }
}
