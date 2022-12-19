using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
   public class Cadre : Employe
    {
       
        private int Indice;
        private double Salaire;
        public Cadre() : base()
        {
            Indice= 0;
            Salaire= 0;
        }
        public Cadre(int Mat, String nom, String pren, DateTime date, int indice) : base(Mat,nom,pren,date)
        {

            base.Matricule = Mat;
            base.Nom = nom;
            base.Prenom = pren;
            base.DateDeNaissance = date;

            Indice = indice;
            Salaire = 0;
        }

        public override double getSalaire()
        {
            switch (Indice)
            {
                case 1:
                    Salaire = 1300;
                    break;
                case 2:
                    Salaire = 1500;
                    break;
                case 3:
                    Salaire = 1700;
                    break;
                case 4:
                    Salaire = 2000;
                    break;
            }
            return Salaire;
        }
        public String to_String()
        {
            return Indice + " : Salaire mensuel " + Salaire + "D";
        }
    }
}
