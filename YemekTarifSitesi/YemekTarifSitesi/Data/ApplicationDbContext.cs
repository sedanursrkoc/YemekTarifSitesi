using YemekTarifSitesi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace YemekTarifSitesi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Malzeme> Malzeme { get; set; }
        public DbSet<Tur> Tur { get; set; }
        public DbSet<Yemek> Yemek { get; set; }
        public DbSet<Yorumlar> Yorumlar { get; set; }
    }
}
