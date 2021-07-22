using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Advertisement_WebAPI.Models;

namespace Advertisement_WebAPI.Data
{
    public class Advertisement_WebAPIContext : DbContext
    {
        public Advertisement_WebAPIContext (DbContextOptions<Advertisement_WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Advertisement_WebAPI.Models.Job> job { get; set; }
        public object Job { get; internal set; }
    }
}
