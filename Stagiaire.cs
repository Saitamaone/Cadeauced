using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1._1
{
    public class Stagiaire
    {

        public Stagiaire()
        {
            this.Courriel = "";
            this.Matricule = -1;
            this.Nom = "";
            this.Prenom = "";
            this.stages = new List<Stage>();
            this.Telephone = "";
            
        }
        public Stagiaire(int p_Matricule,  string p_Prenom, string p_Nom, string p_Telephone, string p_Courriel)
        {
            Matricule = p_Matricule;
            Prenom = p_Prenom;
            Nom = p_Nom;
            Telephone = p_Telephone;
            Courriel = p_Courriel;
        }

        public List<Stage> stages { get; set; }

        public int Matricule {
            get {
            return m_matricule    ;
            }
            set {
              this.m_matricule  = value  ;
            }
        }
        public string Telephone {
            get
            {
                return m_telephone;
            }
            set
            {
                this.m_telephone  = value;
            }
        }
        public string Prenom {
            get
            {
                return m_prenom;
            }
            set
            {
                this.m_prenom  = value;
            }
        }
        public string Nom {
            get
            {
                return m_nom;
            }
            set
            {
                this.m_nom  = value;
            }
        }
        public string Courriel {
            get
            {
                return m_courriel;
            }
            set
            {
                this.m_courriel  = value;
            }
        }

        public override string ToString()
        {
            return m_matricule+ "  " + m_prenom + "  " + m_nom + "  " + m_telephone + "  " + m_courriel;
        }

        private int m_matricule;
        private string m_telephone;
        private string m_prenom;
        private string m_nom;
        private string m_courriel;

    }
}
