using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoAndReminderApp.Models
{
    public class ToDoTasksContext : DbContext
    {
        public ToDoTasksContext(DbContextOptions<ToDoTasksContext> options) : base(options)
        {
        }
        
        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}
