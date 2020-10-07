﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebVendas.Models
{
    public class WebVendasContext : DbContext
    {
        public WebVendasContext(DbContextOptions<WebVendasContext> options)
      : base(options) { }
        public DbSet<WebVendas.Models.Department> Department { get; set; }
    }
}
