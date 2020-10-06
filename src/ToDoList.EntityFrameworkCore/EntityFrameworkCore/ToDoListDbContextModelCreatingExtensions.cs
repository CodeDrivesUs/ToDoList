using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ToDoList.EntityFrameworkCore
{
    public static class ToDoListDbContextModelCreatingExtensions
    {
        public static void ConfigureToDoList(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<TodoList.TodoList>(b =>
            {
                b.ToTable(ToDoListConsts.DbTablePrefix + "TodoList", ToDoListConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Tittle).IsRequired().HasMaxLength(100);
              
            });
            builder.Entity<TodoListItem.TodoListItem>(b =>
            {
                b.ToTable(ToDoListConsts.DbTablePrefix + "TodoListItem", ToDoListConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Tittle).IsRequired().HasMaxLength(100);
                b.HasOne<TodoList.TodoList>().WithMany().HasForeignKey(x => x.TodoListId).IsRequired();
            });
        }
    }
}