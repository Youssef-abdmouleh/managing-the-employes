using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4

{
     class Ouvrier : Employe
    {
        

        private const int SMIG = 250;
        private double Salaire;
        private DateTime DateEnt;

        public Ouvrier() : base()
        {
            DateEnt = DateTime.Now;
            Salaire = 0;

        }

        public Ouvrier(int Mat, String nom, String pren, DateTime date, DateTime datee) : base(Mat, nom, pren, date)
        {
            base.Matricule = Mat;
            base.Nom = nom;
            base.Prenom = pren;
            base.DateDeNaissance = date;
            DateEnt = datee;
            Salaire = SMIG + (DateEnt.Year - DateTime.Now.Year * 100);

        }

        public override double getSalaire()
        {
            if (Salaire > SMIG * 2)
            {
                Salaire = SMIG * 2;
            }
            return Salaire;
        }
    }
}
