using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1._1
{
    public class Stage
    {
        public Stage()
        {
            this.Titre = "";
            this.Matricule = -1;
            this.stagiaire = new Stagiaire();
            this.Superviseur = "";
            this.Commentaires = "";
            this.DateDebut = DateTime.Now;
            this.DateFin = DateTime.Now;

        }
        public string Titre { get; set; }

        public int Matricule { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Superviseur { get; set; }
        public string Commentaires { get; set; }

        public Stagiaire stagiaire { get; set; }






    }
}

/*public Stage(string p_Titre, string p_Matricule, string p_DateDebut, string p_DateFin, string p_Superviseur, string p_Commentaires)
       {
           p_Titre = this.Titre;
           p_Matricule = this.Matricule;
           p_DateDebut = this.DateDebut;
           p_DateFin = this.DateFin;
           p_Superviseur = this.Superviseur;
           p_Commentaires = this.Commentaires;
       } */
