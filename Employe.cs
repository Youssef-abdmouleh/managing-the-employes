using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4

{
  public abstract class Employe
    {
        public int Matricule { get; protected set; }
        public String Nom { get; protected set; }
        public String Prenom { get; protected set; }
        public DateTime DateDeNaissance { get; protected set; }
        public Employe()
        {
            Matricule = 0;
            Nom= null;
            Prenom = null;
            DateDeNaissance = DateTime.Now;
        }
        public Employe(int Mat, String nom, String pren, DateTime date)
        {
            Matricule = Mat;
            Nom = nom;
            Prenom = pren;
            DateDeNaissance = date;
        }

        public String toStrng()
        {
            return (Matricule + ", Nom : " + Nom + ", Prenom : " + Prenom + ", Date de naissance : " + DateDeNaissance);
        }

        abstract public double getSalaire();
    }
}
