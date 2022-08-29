using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataRPG.Model;
using Microsoft.EntityFrameworkCore;

namespace DataRPG.Context
{
    public class RPGContext : DbContext
    {
        #region Props 

        public DbSet<WeaponModel> Weapons { get; set; }


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host= localhost; Port= 5435; Database= postgres; Password= 123; UserId=postgres;");
        }

    }
}
