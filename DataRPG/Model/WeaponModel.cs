using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRPG.Model
{
    public class WeaponModel : BaseModel
    {
        public string WeaponName { get; set; }

        public double WeaponDamage { get; set; }

        public double WeaponWeight { get; set; }
    }

}
