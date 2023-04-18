using blazor_blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_blog.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {


    }

    public DbSet<BlogEntry> Entries { get; set; } = default!;
}