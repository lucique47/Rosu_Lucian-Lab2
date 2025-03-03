﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rosu_Lucian_Lab2.Models;

namespace Rosu_Lucian_Lab2.Data
{
    public class Rosu_Lucian_Lab2Context : DbContext
    {
        public Rosu_Lucian_Lab2Context (DbContextOptions<Rosu_Lucian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rosu_Lucian_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
