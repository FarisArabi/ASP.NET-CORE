using Microsoft.EntityFrameworkCore;
using System;

namespace firstProjectWebApi.Models
{

public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> options)
                : base(options)
        {
        }

        public DbSet<Cat> cats { get; set; }
    }

}
