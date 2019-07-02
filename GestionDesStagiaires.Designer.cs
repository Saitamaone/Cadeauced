namespace Tp1._1
{
    partial class GestionDesStagiaires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSupprimerStagiaires = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.gBoxStagiaires = new System.Windows.Forms.GroupBox();
            this.listBoxStagiaire = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gBoxStages = new System.Windows.Forms.GroupBox();
            this.listBoxStage = new System.Windows.Forms.ListBox();
            this.btnAjouter2 = new System.Windows.Forms.Button();
            this.btnSupprimerStages = new System.Windows.Forms.Button();
            this.gBoxRecherche = new System.Windows.Forms.GroupBox();
            this.listBoxRecherche = new System.Windows.Forms.ListBox();
            this.tbxRecherche = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.fenetreSauvegarde = new System.Windows.Forms.SaveFileDialog();
            this.fenetreOuverture = new System.Windows.Forms.OpenFileDialog();
            this.gBoxStagiaires.SuspendLayout();
            this.gBoxStages.SuspendLayout();
            this.gBoxRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimerStagiaires
            // 
            this.btnSupprimerStagiaires.Location = new System.Drawing.Point(590, 96);
            this.btnSupprimerStagiaires.Name = "btnSupprimerStagiaires";
            this.btnSupprimerStagiaires.Size = new System.Drawing.Size(157, 44);
            this.btnSupprimerStagiaires.TabIndex = 1;
            this.btnSupprimerStagiaires.Text = "Supprimer";
            this.btnSupprimerStagiaires.UseVisualStyleBackColor = true;
            this.btnSupprimerStagiaires.Click += new System.EventHandler(this.btnConsulterModifier_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(590, 23);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(157, 23);
            this.btnRecherche.TabIndex = 1;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // gBoxStagiaires
            // 
            this.gBoxStagiaires.Controls.Add(this.listBoxStagiaire);
            this.gBoxStagiaires.Controls.Add(this.btnAjouter);
            this.gBoxStagiaires.Controls.Add(this.btnSupprimerStagiaires);
            this.gBoxStagiaires.Location = new System.Drawing.Point(12, 12);
            this.gBoxStagiaires.Name = "gBoxStagiaires";
            this.gBoxStagiaires.Size = new System.Drawing.Size(772, 194);
            this.gBoxStagiaires.TabIndex = 0;
            this.gBoxStagiaires.TabStop = false;
            this.gBoxStagiaires.Text = "Stagiaires";
            this.gBoxStagiaires.Enter += new System.EventHandler(this.gBoxStagiaires_Enter);
            // 
            // listBoxStagiaire
            // 
            this.listBoxStagiaire.FormattingEnabled = true;
            this.listBoxStagiaire.Location = new System.Drawing.Point(17, 20);
            this.listBoxStagiaire.Name = "listBoxStagiaire";
            this.listBoxStagiaire.Size = new System.Drawing.Size(551, 160);
            this.listBoxStagiaire.TabIndex = 3;
            this.listBoxStagiaire.SelectedIndexChanged += new System.EventHandler(this.listBoxStagiaire_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(592, 30);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(155, 45);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // gBoxStages
            // 
            this.gBoxStages.Controls.Add(this.listBoxStage);
            this.gBoxStages.Controls.Add(this.btnAjouter2);
            this.gBoxStages.Controls.Add(this.btnSupprimerStages);
            this.gBoxStages.Location = new System.Drawing.Point(12, 354);
            this.gBoxStages.Name = "gBoxStages";
            this.gBoxStages.Size = new System.Drawing.Size(772, 214);
            this.gBoxStages.TabIndex = 2;
            this.gBoxStages.TabStop = false;
            this.gBoxStages.Text = "Stages";
            // 
            // listBoxStage
            // 
            this.listBoxStage.FormattingEnabled = true;
            this.listBoxStage.Location = new System.Drawing.Point(17, 20);
            this.listBoxStage.Name = "listBoxStage";
            this.listBoxStage.Size = new System.Drawing.Size(543, 186);
            this.listBoxStage.TabIndex = 3;
            // 
            // btnAjouter2
            // 
            this.btnAjouter2.Location = new System.Drawing.Point(592, 19);
            this.btnAjouter2.Name = "btnAjouter2";
            this.btnAjouter2.Size = new System.Drawing.Size(155, 47);
            this.btnAjouter2.TabIndex = 2;
            this.btnAjouter2.Text = "Ajouter";
            this.btnAjouter2.UseVisualStyleBackColor = true;
            this.btnAjouter2.Click += new System.EventHandler(this.btnAjouter2_Click);
            // 
            // btnSupprimerStages
            // 
            this.btnSupprimerStages.Location = new System.Drawing.Point(592, 122);
            this.btnSupprimerStages.Name = "btnSupprimerStages";
            this.btnSupprimerStages.Size = new System.Drawing.Size(157, 47);
            this.btnSupprimerStages.TabIndex = 1;
            this.btnSupprimerStages.Text = "Supprimer";
            this.btnSupprimerStages.UseVisualStyleBackColor = true;
            this.btnSupprimerStages.Click += new System.EventHandler(this.btnConsulterModifierStages_Click_1);
            // 
            // gBoxRecherche
            // 
            this.gBoxRecherche.Controls.Add(this.listBoxRecherche);
            this.gBoxRecherche.Controls.Add(this.tbxRecherche);
            this.gBoxRecherche.Controls.Add(this.btnRecherche);
            this.gBoxRecherche.Location = new System.Drawing.Point(12, 212);
            this.gBoxRecherche.Name = "gBoxRecherche";
            this.gBoxRecherche.Size = new System.Drawing.Size(772, 136);
            this.gBoxRecherche.TabIndex = 1;
            this.gBoxRecherche.TabStop = false;
            this.gBoxRecherche.Text = "Recherche de Stagiaires";
            // 
            // listBoxRecherche
            // 
            this.listBoxRecherche.FormattingEnabled = true;
            this.listBoxRecherche.Location = new System.Drawing.Point(17, 50);
            this.listBoxRecherche.Name = "listBoxRecherche";
            this.listBoxRecherche.Size = new System.Drawing.Size(543, 82);
            this.listBoxRecherche.TabIndex = 2;
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.Location = new System.Drawing.Point(17, 23);
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(543, 20);
            this.tbxRecherche.TabIndex = 0;
            this.tbxRecherche.TextChanged += new System.EventHandler(this.tbxRecherche_TextChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(679, 591);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(82, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(565, 591);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(84, 23);
            this.btnSauvegarder.TabIndex = 0;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(474, 591);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(75, 23);
            this.btnCharger.TabIndex = 3;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // fenetreSauvegarde
            // 
            this.fenetreSauvegarde.DefaultExt = "xml";
            this.fenetreSauvegarde.Filter = "Fichiers XML |*.xml";
            // 
            // fenetreOuverture
            // 
            this.fenetreOuverture.FileName = "openFileDialog1";
            this.fenetreOuverture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // GestionDesStagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 635);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gBoxRecherche);
            this.Controls.Add(this.gBoxStages);
            this.Controls.Add(this.gBoxStagiaires);
            this.Name = "GestionDesStagiaires";
            this.Text = "GestionDesStagiaires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionDesStagiaires_FormClosing);
            this.Load += new System.EventHandler(this.GestionDesStagiaires_Load);
            this.gBoxStagiaires.ResumeLayout(false);
            this.gBoxStages.ResumeLayout(false);
            this.gBoxRecherche.ResumeLayout(false);
            this.gBoxRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimerStagiaires;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.GroupBox gBoxStagiaires;
        private System.Windows.Forms.GroupBox gBoxStages;
        private System.Windows.Forms.GroupBox gBoxRecherche;
        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.Button btnSupprimerStages;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjouter2;
        private System.Windows.Forms.SaveFileDialog fenetreSauvegarde;
        private System.Windows.Forms.OpenFileDialog fenetreOuverture;
        private System.Windows.Forms.ListBox listBoxStagiaire;
        private System.Windows.Forms.ListBox listBoxStage;
        private System.Windows.Forms.ListBox listBoxRecherche;
    }
}