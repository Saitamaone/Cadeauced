using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Tp1._1
{
    public partial class GestionDesStagiaires : Form
    {

         
        public GestionDesStagiaires()
        {
            InitializeComponent();
            stagiaires = new List<Stagiaire>();
            
            matricules = new List<int>();
        }

        private void btnConsulterModifierStages_Click(object sender, EventArgs e)
        {
    
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            informationsStagiaires informationsStagiaire = new informationsStagiaires(null);
            DialogResult resultat = informationsStagiaire.ShowDialog(this);

            if (resultat == DialogResult.OK)
            {
                this.listBoxStagiaire.Items.Add(informationsStagiaire.Stagiaire_cours);
     
            }
        }

        private void btnConsulterModifier_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjouter2_Click(object sender, EventArgs e)
        {

            int index = listBoxStagiaire.SelectedIndex;
            InformationsStages fenetreStages = new InformationsStages(null);
            DialogResult resultat = fenetreStages.ShowDialog(this);

            if (listBoxStagiaire.SelectedItem == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un stagiaire.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            else
            {
                if (resultat == DialogResult.OK)
                {

                    listBoxStage.Items.Add(fenetreStages.currentStage.Titre + fenetreStages.currentStage.DateDebut +
                        fenetreStages.currentStage.DateFin + fenetreStages.currentStage.Superviseur + fenetreStages.currentStage.Commentaires);

                }
            }


        }

        private void btnConsulterModifierStages_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {    
            fenetreSauvegarde.ShowDialog();

            string nomFichier = fenetreSauvegarde.FileName;

            sauvegarder(nomFichier);
        }

        private void sauvegarder(string p_nomFichier)
        {
            XElement element = new XElement("Items");
            foreach (var item in listBoxStagiaire.Items)
            {
                element.Add(new XElement("Stagiaire", item));
            }
            XDocument document = new XDocument();
            document.Add(element);
            document.Save(p_nomFichier, SaveOptions.DisableFormatting);
           
        }
        
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            listBoxStagiaire.SelectedItems.Clear();
            for ( int i=listBoxStagiaire.Items.Count-1; i>=0;i--  )
            {
                if (listBoxStagiaire.Items[i].ToString().ToLower().Contains(tbxRecherche.Text.ToLower()))
                {
                    this.listBoxRecherche.Items.Add(listBoxStagiaire.Items[i].ToString());
                }
            }
            
        }
        private DataGridViewCell GetCellWhereTextExistsInGridView(string searchText, DataGridView dataGridView1, int columnIndex)
        {
            DataGridViewCell cellWhereTextIsMet = null;

            // For every row in the grid (obviously)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // I did not test this case, but cell.Value is an object, and objects can be null
                // So check if the cell is null before using .ToString()
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    // the searchText is equals to the text in this cell.
                    cellWhereTextIsMet = row.Cells[columnIndex];
                    break;
                }
            }

            return cellWhereTextIsMet;
        }
        public List<Stagiaire> lsStagiaires { get; set; }
        public List<int> lsMatricules { get; set; }




        private List<Stagiaire> stagiaires; // { get; set; }
        private List<int> matricules; //{ get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            fenetreOuverture.ShowDialog();
            string nomFichier = fenetreOuverture.FileName;
            Charger(nomFichier);
        }

        private void Charger(string p_nom)
        {
            {

                string path_of_xml = p_nom;

                XmlDocument doc = new XmlDocument();

                doc.Load(path_of_xml);



                listBoxStagiaire.Items.Clear();

                foreach (XmlNode node in doc.ChildNodes)

                {





                    listBoxStagiaire.Items.Add(node[""].InnerText);



                       

                   

                }



            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void gBoxStagiaires_Enter(object sender, EventArgs e)
        {

        }

        private void tbxRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionDesStagiaires_Load(object sender, EventArgs e)
        {

        }

        private void listBoxStagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionDesStagiaires_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
            "Etes-vous sure de quitter sans sauvegarder";
            const string caption = "Fermeture";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                fenetreSauvegarde.ShowDialog();

                string nomFichier = fenetreSauvegarde.FileName;

                sauvegarder(nomFichier);// cancel the closure of the form.

            }
        }
    }
}
