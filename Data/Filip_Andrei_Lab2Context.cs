﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Filip_Andrei_Lab2.Models;

namespace Filip_Andrei_Lab2.Data
{
    public class Filip_Andrei_Lab2Context : DbContext
    {
        public Filip_Andrei_Lab2Context (DbContextOptions<Filip_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Filip_Andrei_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Filip_Andrei_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Filip_Andrei_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Filip_Andrei_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Filip_Andrei_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
    }
}
