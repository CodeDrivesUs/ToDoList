using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class fhvkfbebxfvb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTodoListItem_AppTodoList_TodoListId",
                table: "AppTodoListItem");

            migrationBuilder.DropIndex(
                name: "IX_AppTodoListItem_TodoListId",
                table: "AppTodoListItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AppTodoListItem_TodoListId",
                table: "AppTodoListItem",
                column: "TodoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTodoListItem_AppTodoList_TodoListId",
                table: "AppTodoListItem",
                column: "TodoListId",
                principalTable: "AppTodoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
