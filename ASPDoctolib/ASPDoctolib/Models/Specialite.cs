using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Models
{
    public class Specialite
    {
        private string nomSpecialite;

        public Specialite(string nomSpecialite)
        {
            this.nomSpecialite = nomSpecialite;
        }

        public string NomSpecialite { get => nomSpecialite; set => nomSpecialite = value; }

        public override string ToString()
        {
            return NomSpecialite;
        }
    }
}
