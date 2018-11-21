using Microsoft.EntityFrameworkCore.Migrations;

namespace EmotionMarketing.Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "emotion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emotion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "genre",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genre", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    attention_rate = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    gender_type = table.Column<int>(nullable: false),
                    genre_id = table.Column<int>(nullable: false),
                    producer_name = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.id);
                    table.ForeignKey(
                        name: "FK_projects_genre_genre_id",
                        column: x => x.genre_id,
                        principalTable: "genre",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "expected_result",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    emotion_id = table.Column<int>(nullable: false),
                    from = table.Column<int>(nullable: false),
                    project_id = table.Column<int>(nullable: false),
                    to = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expected_result", x => x.id);
                    table.ForeignKey(
                        name: "FK_expected_result_emotion_emotion_id",
                        column: x => x.emotion_id,
                        principalTable: "emotion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_expected_result_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_expected_result_emotion_id",
                table: "expected_result",
                column: "emotion_id");

            migrationBuilder.CreateIndex(
                name: "IX_expected_result_project_id",
                table: "expected_result",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_projects_genre_id",
                table: "projects",
                column: "genre_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "expected_result");

            migrationBuilder.DropTable(
                name: "emotion");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "genre");
        }
    }
}
