using DataRPG.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRPG.Context
{
    public class RPGContext :DbContext
    {
        #region Props
        public DbSet<Character> Character { get; set; }
        public DbSet<WeaponModel> Weapon { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5435; Database=postgres; UserId=postgres; Password=123");
        }
    }
}
