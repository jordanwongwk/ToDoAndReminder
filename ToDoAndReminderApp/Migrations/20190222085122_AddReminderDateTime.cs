using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoAndReminderApp.Migrations
{
    public partial class AddReminderDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskDate",
                table: "ToDoTasks");

            migrationBuilder.RenameColumn(
                name: "TaskTime",
                table: "ToDoTasks",
                newName: "TaskReminderDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskReminderDateTime",
                table: "ToDoTasks",
                newName: "TaskTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "TaskDate",
                table: "ToDoTasks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
