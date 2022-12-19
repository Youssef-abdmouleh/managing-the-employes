using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Patron : Employe
    {
        private double CA;
        private double Salaire;
        private double percent;
        public Patron() : base()
        {
            percent = 0;
            CA = 0;
            Salaire = 0;
        }
        public Patron(int Mat, String nom, String pren, DateTime date, double perc, double ca) : base(Mat, nom, pren, date)
        {
            base.Matricule = Mat;
            base.Nom = nom;
            base.Prenom = pren;
            base.DateDeNaissance = date;

            percent = perc;
            CA = ca;
            Salaire = CA * percent / 100;
        }

        public override double getSalaire()
        {
            return Salaire;
        }


    }
}
