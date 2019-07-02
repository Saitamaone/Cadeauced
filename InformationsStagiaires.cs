using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1._1
{
    public partial class informationsStagiaires : Form
    {
        

        public Stagiaire Stagiaire_cours
        {
            get;
            private set;
        }
        public informationsStagiaires(Stagiaire p_stagiaire)
        {
            InitializeComponent();
            Stagiaire_cours = p_stagiaire;

            if (Stagiaire_cours == null)
            {
                this.Text = "Ajouter un Stagiaire";

                Stagiaire_cours = new Stagiaire();
            }
            else
            {
                this.Text = "Modifier un Stagiaire";

                txtBoxMatricule.Text = Stagiaire_cours.Matricule.ToString();
                txtBoxPrenom.Text = Stagiaire_cours.Prenom;
                txtNom.Text = Stagiaire_cours.Nom;
                txtBoxTelephone.Text = Stagiaire_cours.Telephone;
                txtBoxCourriel.Text = Stagiaire_cours.Courriel;


            }
        }
        private void txtBoxTelephone_Validating(object sender, CancelEventArgs e)
        {
            Regex NumeroTel = new Regex("^\\d{3}-\\d{3}-\\d{4}$");
            if (NumeroTel.IsMatch(txtBoxTelephone.Text))
            {
                GestionnaireErreur.SetError(txtBoxTelephone, "");
            }
            else
            {
                GestionnaireErreur.SetError(txtBoxTelephone, "Ecrivez un numero valide XXX-XXX-XXXX.");
                e.Cancel = true;
            }
        }


        private void txtBoxMatricule_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                int valeur = Int32.Parse(txtBoxMatricule.Text);
                
                if (valeur < 0)
                {
                    GestionnaireErreur.SetError(txtBoxMatricule, "Pas un nombre entier positif.");
                }
                /*if (GestionDesStagiaires.lsMatricules.IndexOf(valeur) != -1)
                {
                    GestionnaireErreur.SetError(txtBoxMatricule, "Ce matricule existe deja");
                }*/
                if (Matricule.matricule == null)
                {
                    Matricule.matricule.Add(valeur);
                }
                for (int i = 0 ; i < Matricule.Longueur(); i++)
                {
                    if (Matricule.matricule[i] == valeur)
                    {
                        GestionnaireErreur.SetError(txtBoxMatricule, "nombre existe deja");
                    }
                }
                Matricule.matricule.Add(valeur);
                GestionnaireErreur.SetError(txtBoxMatricule, "");
                

            }
            catch (Exception)
            {
                GestionnaireErreur.SetError(txtBoxMatricule, "Pas un nombre entier.");

            }
        }

        private void txtBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxPrenom.Text != "")
            {
                GestionnaireErreur.SetError(txtBoxPrenom, "");

            }
            else
            {
                GestionnaireErreur.SetError(txtBoxPrenom, "Ecrivez un Prenom.");
                e.Cancel = true;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            if (txtNom.Text != "")
            {
                GestionnaireErreur.SetError(txtNom, "");

            }
            else
            {
                GestionnaireErreur.SetError(txtNom, "Ecrivez un Nom.");
                e.Cancel = true;
            }
        }

        private void txtBoxCourriel_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxCourriel.Text != "")
            {
                GestionnaireErreur.SetError(txtBoxCourriel, "");

            }
            else
            {
                GestionnaireErreur.SetError(txtBoxCourriel, "Ecrivez un courriel.");
                e.Cancel = true;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            this.Stagiaire_cours = new Stagiaire(Int32.Parse(txtBoxMatricule.Text), txtBoxPrenom.Text, txtNom.Text, txtBoxTelephone.Text, txtBoxCourriel.Text);
            //this.Stagiaire_cours.Matricule = ;
            //this.Stagiaire_cours.Prenom = txtBoxPrenom.Text;
            //this.Stagiaire_cours.Nom = txtNom.Text;
            //this.Stagiaire_cours.Telephone = txtBoxTelephone.Text;
            //this.Stagiaire_cours.Courriel = txtBoxCourriel.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void informationsStagiaires_Load(object sender, EventArgs e)
        {

        }
    }
}
