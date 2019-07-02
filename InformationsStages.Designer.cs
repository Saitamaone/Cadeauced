namespace Tp1._1
{
    partial class InformationsStages
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
            this.components = new System.ComponentModel.Container();
            this.txtBoxTitre = new System.Windows.Forms.TextBox();
            this.txtBoxDateDebut = new System.Windows.Forms.TextBox();
            this.txtBoxDateFin = new System.Windows.Forms.TextBox();
            this.txtBoxSuperviseur = new System.Windows.Forms.TextBox();
            this.txtBoxCommentaires = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblNomSuperviseur = new System.Windows.Forms.Label();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtBoxMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTitre
            // 
            this.txtBoxTitre.Location = new System.Drawing.Point(39, 23);
            this.txtBoxTitre.Name = "txtBoxTitre";
            this.txtBoxTitre.Size = new System.Drawing.Size(293, 20);
            this.txtBoxTitre.TabIndex = 0;
            
            this.txtBoxTitre.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxTitre_Validating);
            // 
            // txtBoxDateDebut
            // 
            this.txtBoxDateDebut.Location = new System.Drawing.Point(39, 129);
            this.txtBoxDateDebut.Name = "txtBoxDateDebut";
            this.txtBoxDateDebut.Size = new System.Drawing.Size(128, 20);
            this.txtBoxDateDebut.TabIndex = 1;
            this.txtBoxDateDebut.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxDateDebut_Validating);
            // 
            // txtBoxDateFin
            // 
            this.txtBoxDateFin.Location = new System.Drawing.Point(197, 129);
            this.txtBoxDateFin.Name = "txtBoxDateFin";
            this.txtBoxDateFin.Size = new System.Drawing.Size(137, 20);
            this.txtBoxDateFin.TabIndex = 2;
            this.txtBoxDateFin.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxDateFin_Validating);
            // 
            // txtBoxSuperviseur
            // 
            this.txtBoxSuperviseur.Location = new System.Drawing.Point(39, 183);
            this.txtBoxSuperviseur.Name = "txtBoxSuperviseur";
            this.txtBoxSuperviseur.Size = new System.Drawing.Size(293, 20);
            this.txtBoxSuperviseur.TabIndex = 3;
            // 
            // txtBoxCommentaires
            // 
            this.txtBoxCommentaires.Location = new System.Drawing.Point(39, 232);
            this.txtBoxCommentaires.Multiline = true;
            this.txtBoxCommentaires.Name = "txtBoxCommentaires";
            this.txtBoxCommentaires.Size = new System.Drawing.Size(295, 131);
            this.txtBoxCommentaires.TabIndex = 4;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(34, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Titre";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(38, 113);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebut.TabIndex = 6;
            this.lblDateDebut.Text = "Date de debut";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(194, 113);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(59, 13);
            this.lblDateFin.TabIndex = 7;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblNomSuperviseur
            // 
            this.lblNomSuperviseur.AutoSize = true;
            this.lblNomSuperviseur.Location = new System.Drawing.Point(38, 167);
            this.lblNomSuperviseur.Name = "lblNomSuperviseur";
            this.lblNomSuperviseur.Size = new System.Drawing.Size(86, 13);
            this.lblNomSuperviseur.TabIndex = 8;
            this.lblNomSuperviseur.Text = "Nom superviseur";
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(38, 216);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(73, 13);
            this.lblCommentaires.TabIndex = 9;
            this.lblCommentaires.Text = "Commentaires";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmer.Location = new System.Drawing.Point(36, 381);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(257, 381);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtBoxMatricule
            // 
            this.txtBoxMatricule.Location = new System.Drawing.Point(39, 75);
            this.txtBoxMatricule.Name = "txtBoxMatricule";
            this.txtBoxMatricule.ReadOnly = true;
            this.txtBoxMatricule.Size = new System.Drawing.Size(160, 20);
            this.txtBoxMatricule.TabIndex = 12;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(38, 59);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 13;
            this.lblMatricule.Text = "Matricule";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // InformationsStages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 416);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.txtBoxMatricule);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblCommentaires);
            this.Controls.Add(this.lblNomSuperviseur);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtBoxCommentaires);
            this.Controls.Add(this.txtBoxSuperviseur);
            this.Controls.Add(this.txtBoxDateFin);
            this.Controls.Add(this.txtBoxDateDebut);
            this.Controls.Add(this.txtBoxTitre);
            this.Name = "InformationsStages";
            this.Text = "Informations stages";
            this.Load += new System.EventHandler(this.InformationsStages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBoxTitre;
        public System.Windows.Forms.TextBox txtBoxMatricule;
        public System.Windows.Forms.TextBox txtBoxDateDebut;
        public System.Windows.Forms.TextBox txtBoxDateFin;
        public System.Windows.Forms.TextBox txtBoxSuperviseur;
        public System.Windows.Forms.TextBox txtBoxCommentaires;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblNomSuperviseur;
        private System.Windows.Forms.Label lblCommentaires;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;      
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}