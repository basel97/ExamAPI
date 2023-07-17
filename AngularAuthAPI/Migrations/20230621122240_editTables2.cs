using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularAuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class editTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_ExamTopicId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "ExamTopicId",
                table: "Questions",
                newName: "TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_ExamTopicId",
                table: "Questions",
                newName: "IX_Questions_TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "ExamTopicId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Questions",
                newName: "ExamTopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                newName: "IX_Questions_ExamTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_ExamTopicId",
                table: "Questions",
                column: "ExamTopicId",
                principalTable: "Topics",
                principalColumn: "ExamTopicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
