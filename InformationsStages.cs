using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tp1._1
{
    public partial class InformationsStages : Form
    {

        public Stage currentStage { get; set; }

        public InformationsStages(Stage p_stage)
        {
            InitializeComponent();

            currentStage = p_stage;

            if (currentStage == null)
            {
                this.Text = "Ajouter un stage";

                currentStage = new Stage();
            }
            else
            {
                this.Text = "Modifier un stage";

                txtBoxTitre.Text = currentStage.Titre;
                txtBoxDateDebut.Text = currentStage.DateDebut.ToString();
                txtBoxDateFin.Text = currentStage.DateFin.ToString();
                txtBoxSuperviseur.Text = currentStage.Superviseur;
                txtBoxCommentaires.Text = currentStage.Commentaires;
            }
        }


        private void txtBoxTitre_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtBoxTitre.Text == "")
            {
                errorProvider1.SetError(txtBoxTitre, "Veuillez entrer le titre.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBoxTitre, "");

            }
        }


        private void txtBoxDateDebut_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateDebutEntreprise = new DateTime(1990, 06, 01);

            DateTime dateDebut = new DateTime();

            try
            {
                dateDebut = DateTime.ParseExact(this.txtBoxDateDebut.Text, "yyyy-MM-dd", null);
            }

            catch (FormatException)
            {
                errorProvider2.SetError(this.txtBoxDateDebut, "Veuillez entrer un format de date valide.");
                e.Cancel = true;
            }


            if (dateDebut < dateDebutEntreprise)
            {
                errorProvider2.SetError(this.txtBoxDateDebut, "Veuillez entrer une date supérieure au 1990-06-01");
                e.Cancel = true;
            }

            else
            {
                errorProvider2.SetError(this.txtBoxDateDebut, "");

            }
        }

        private void txtBoxDateFin_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateFin = new DateTime();

            try
            {
                dateFin = DateTime.ParseExact(this.txtBoxDateFin.Text, "yyyy-MM-dd", null);
            }

            catch (FormatException)
            {
                errorProvider3.SetError(this.txtBoxDateFin, "Veuillez entrer un format de date valide.");
                e.Cancel = true;
            }

            DateTime dateDebut = new DateTime();

            try
            {
                dateDebut = DateTime.ParseExact(this.txtBoxDateDebut.Text, "yyyy-MM-dd", null);
            }

            catch (FormatException)
            {
                errorProvider2.SetError(this.txtBoxDateDebut, "Veuillez entrer un format de date valide.");
                e.Cancel = true;
            }

            DateTime dateLimiteStage = new DateTime(dateDebut.Year + 1, dateDebut.Month, dateDebut.Day);

            if (dateFin < dateDebut)
            {
                errorProvider3.SetError(this.txtBoxDateFin, "Veuillez entrer une date supérieure à la date de début du stage.");
                e.Cancel = true;
            }

            else if (dateFin > dateLimiteStage)
            {
                errorProvider3.SetError(this.txtBoxDateFin, "Le stage ne peut durer plus d'un an.");
                e.Cancel = true;
            }

            else
            {
                errorProvider3.SetError(this.txtBoxDateFin, "");

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

            this.currentStage.Titre = this.txtBoxTitre.Text;
            this.currentStage.DateDebut = DateTime.ParseExact(this.txtBoxDateDebut.Text, "yyyy-MM-dd", null);
            this.currentStage.DateDebut = DateTime.ParseExact(this.txtBoxDateFin.Text, "yyyy-MM-dd", null);
            this.currentStage.Superviseur = this.txtBoxSuperviseur.Text;
            this.currentStage.Commentaires = this.txtBoxCommentaires.Text;
        }

        private void InformationsStages_Load(object sender, EventArgs e)
        {

        }
    }
}

