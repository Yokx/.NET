using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Medecin
{
    class Specialite
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
