using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRPG.Model
{
    public class Character : BaseModel
    {
        public string Breed { get; set; }
        public string BaseDamage { get; set; }
        public string Class { get; set; }
    }
}
