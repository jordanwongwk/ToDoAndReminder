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

    /*public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Blog
    {
        public int BlogID { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogID { get; set; }
        public Blog blog { get; set;}
    }*/
}
