using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoAndReminderApp.Migrations
{
    public partial class TurnOnNotify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNotificationTurnedOn",
                table: "ToDoTasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNotificationTurnedOn",
                table: "ToDoTasks");
        }
    }
}
