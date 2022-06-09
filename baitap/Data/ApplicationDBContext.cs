﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using baitap.Models;

namespace baitap.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
