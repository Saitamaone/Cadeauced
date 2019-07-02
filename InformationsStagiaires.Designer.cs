namespace Tp1._1
{
    partial class informationsStagiaires
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxMatricule = new System.Windows.Forms.TextBox();
            this.txtBoxTelephone = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtBoxCourriel = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.GestionnaireErreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GestionnaireErreur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxMatricule
            // 
            this.txtBoxMatricule.Location = new System.Drawing.Point(12, 31);
            this.txtBoxMatricule.Name = "txtBoxMatricule";
            this.txtBoxMatricule.Size = new System.Drawing.Size(112, 20);
            this.txtBoxMatricule.TabIndex = 0;
            this.txtBoxMatricule.TextChanged += new System.EventHandler(this.txtBoxMatricule_TextChanged);
            this.txtBoxMatricule.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxMatricule_Validating);
            // 
            // txtBoxTelephone
            // 
            this.txtBoxTelephone.Location = new System.Drawing.Point(171, 31);
            this.txtBoxTelephone.Name = "txtBoxTelephone";
            this.txtBoxTelephone.Size = new System.Drawing.Size(212, 20);
            this.txtBoxTelephone.TabIndex = 1;
            this.txtBoxTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxTelephone_Validating);
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(12, 73);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(371, 20);
            this.txtBoxPrenom.TabIndex = 2;
            this.txtBoxPrenom.TextChanged += new System.EventHandler(this.txtBoxPrenom_TextChanged);
            this.txtBoxPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPrenom_Validating);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(13, 112);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(370, 20);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtNom_Validating);
            // 
            // txtBoxCourriel
            // 
            this.txtBoxCourriel.Location = new System.Drawing.Point(13, 148);
            this.txtBoxCourriel.Name = "txtBoxCourriel";
            this.txtBoxCourriel.Size = new System.Drawing.Size(370, 20);
            this.txtBoxCourriel.TabIndex = 4;
            this.txtBoxCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCourriel_Validating);
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(10, 15);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 5;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(168, 15);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 58);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 96);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(13, 135);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(42, 13);
            this.lblCourriel.TabIndex = 9;
            this.lblCourriel.Text = "Courriel";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(405, 112);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(405, 148);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // GestionnaireErreur
            // 
            this.GestionnaireErreur.ContainerControl = this;
            // 
            // informationsStagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 192);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.txtBoxCourriel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxTelephone);
            this.Controls.Add(this.txtBoxMatricule);
            this.Name = "informationsStagiaires";
            this.Text = "Informations du stagiaire";
            this.Load += new System.EventHandler(this.informationsStagiaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GestionnaireErreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMatricule;
        private System.Windows.Forms.TextBox txtBoxTelephone;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtBoxCourriel;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
       
        private System.Windows.Forms.ErrorProvider GestionnaireErreur;
    }
}

