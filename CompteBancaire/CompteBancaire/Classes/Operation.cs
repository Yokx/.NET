using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    class Operation
    {
        private string numeroCompte;
        private DateTime dateOperation;
        private double montant;

        public Operation(string numeroCompte, double montant)
        {
            this.numeroCompte = numeroCompte;
            this.montant = montant;
            DateOperation = DateTime.Now;
        }

        public string NumeroCompte { get => numeroCompte; set => numeroCompte = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }
        public double Montant { get => montant; set => montant = value; }

        public override string ToString()
        {
            return "Date Opération : " + DateOperation + " Montant : " + Montant;
        }
    }
}
