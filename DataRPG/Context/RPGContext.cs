using DataRPG.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRPG.Context
{
    internal class RPGContext
    {
        #region Props
        public DbSet<Character> Character { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5435; Database=postgres; UserId=postgres; Password=123");
        }
    }
}
