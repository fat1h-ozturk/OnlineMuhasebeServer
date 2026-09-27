using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class company_bilgileri_guncellendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userAndCompanyRelationships_AspNetUsers_AppUserId",
                table: "userAndCompanyRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_userAndCompanyRelationships_Companies_CompanyId",
                table: "userAndCompanyRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userAndCompanyRelationships",
                table: "userAndCompanyRelationships");

            migrationBuilder.RenameTable(
                name: "userAndCompanyRelationships",
                newName: "UserAndCompanyRelationships");

            migrationBuilder.RenameIndex(
                name: "IX_userAndCompanyRelationships_CompanyId",
                table: "UserAndCompanyRelationships",
                newName: "IX_UserAndCompanyRelationships_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_userAndCompanyRelationships_AppUserId",
                table: "UserAndCompanyRelationships",
                newName: "IX_UserAndCompanyRelationships_AppUserId");

            migrationBuilder.AddColumn<string>(
                name: "DataBaseName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAndCompanyRelationships",
                table: "UserAndCompanyRelationships",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAndCompanyRelationships_AspNetUsers_AppUserId",
                table: "UserAndCompanyRelationships",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAndCompanyRelationships_Companies_CompanyId",
                table: "UserAndCompanyRelationships",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAndCompanyRelationships_AspNetUsers_AppUserId",
                table: "UserAndCompanyRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAndCompanyRelationships_Companies_CompanyId",
                table: "UserAndCompanyRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAndCompanyRelationships",
                table: "UserAndCompanyRelationships");

            migrationBuilder.DropColumn(
                name: "DataBaseName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ServerName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "UserAndCompanyRelationships",
                newName: "userAndCompanyRelationships");

            migrationBuilder.RenameIndex(
                name: "IX_UserAndCompanyRelationships_CompanyId",
                table: "userAndCompanyRelationships",
                newName: "IX_userAndCompanyRelationships_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAndCompanyRelationships_AppUserId",
                table: "userAndCompanyRelationships",
                newName: "IX_userAndCompanyRelationships_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userAndCompanyRelationships",
                table: "userAndCompanyRelationships",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userAndCompanyRelationships_AspNetUsers_AppUserId",
                table: "userAndCompanyRelationships",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userAndCompanyRelationships_Companies_CompanyId",
                table: "userAndCompanyRelationships",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
