using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace _20220509.Models
{
    public class TestDB : DbContext
    {
        public TestDB(DbContextOptions<TestDB> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
