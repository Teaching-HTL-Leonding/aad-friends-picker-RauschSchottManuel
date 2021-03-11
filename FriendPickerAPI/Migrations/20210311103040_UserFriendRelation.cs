using Microsoft.EntityFrameworkCore.Migrations;

namespace AadAuthAPI.Migrations
{
    public partial class UserFriendRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "friendAADId",
                table: "Friends",
                newName: "FriendAADId");

            migrationBuilder.AddColumn<string>(
                name: "UId",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UId",
                table: "Friends");

            migrationBuilder.RenameColumn(
                name: "FriendAADId",
                table: "Friends",
                newName: "friendAADId");
        }
    }
}
