using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodolistDbContext : DbContext
    {
        public TodolistDbContext(DbContextOptions<TodolistDbContext> options) : base(options) { }

        public DbSet<TodoItem> Todos { get; set; }
    
    }
}