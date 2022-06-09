using baitap.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitap.Models
{
    public class Migrations :DbContext
    {
        public DbSet<SanPhams> SanPham { get; set; }
        private string chuoikn = "Server=localhost;Database=test01;Uid=sa;Pwd=123456aA@;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(chuoikn);
        }
       
        public void CreateDataBase()
        {
            using var dbcontext = new Migrations();
            string dbname = dbcontext.Database.GetDbConnection().Database;
            var kq = dbcontext.Database.EnsureCreated();
            
        }
    }
}
