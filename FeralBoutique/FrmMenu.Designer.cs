namespace FeralBoutique
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tbpCustomisation = new System.Windows.Forms.TabPage();
            this.dgvCustom = new System.Windows.Forms.DataGridView();
            this.tbpPannier = new System.Windows.Forms.TabPage();
            this.txtIdClientDevis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCommandeDevis = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnCommander = new System.Windows.Forms.Button();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.tbpHistoire = new System.Windows.Forms.TabPage();
            this.tbpCatalogue = new System.Windows.Forms.TabPage();
            this.pnlTrie = new System.Windows.Forms.Panel();
            this.lblTrie = new System.Windows.Forms.Label();
            this.txbRechercheModele = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.cbbCateg = new System.Windows.Forms.ComboBox();
            this.cbbIdClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.lblPannier = new System.Windows.Forms.Label();
            this.btnAjoutPannier = new System.Windows.Forms.Button();
            this.dgvVoitures = new System.Windows.Forms.DataGridView();
            this.tbcMenu1 = new System.Windows.Forms.TabControl();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbbIdClient2 = new System.Windows.Forms.ComboBox();
            this.cbbIdCommande = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.tbpCustomisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustom)).BeginInit();
            this.tbpPannier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).BeginInit();
            this.tbpCatalogue.SuspendLayout();
            this.pnlTrie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoitures)).BeginInit();
            this.tbcMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConnexion.Location = new System.Drawing.Point(21, 25);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(116, 13);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Connecté en tant que :";
            this.lblConnexion.Click += new System.EventHandler(this.lblConnexion_Click);
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatut.Location = new System.Drawing.Point(137, 49);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(35, 13);
            this.lblStatut.TabIndex = 1;
            this.lblStatut.Text = "Statut";
            // 
            // picbLogo
            // 
            this.picbLogo.Image = ((System.Drawing.Image)(resources.GetObject("picbLogo.Image")));
            this.picbLogo.Location = new System.Drawing.Point(1545, 12);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(215, 206);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogo.TabIndex = 5;
            this.picbLogo.TabStop = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 68);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(113, 52);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tbpCustomisation
            // 
            this.tbpCustomisation.Controls.Add(this.dgvCustom);
            this.tbpCustomisation.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomisation.Name = "tbpCustomisation";
            this.tbpCustomisation.Size = new System.Drawing.Size(1091, 414);
            this.tbpCustomisation.TabIndex = 3;
            this.tbpCustomisation.Text = "Customisation";
            this.tbpCustomisation.UseVisualStyleBackColor = true;
            // 
            // dgvCustom
            // 
            this.dgvCustom.AllowUserToAddRows = false;
            this.dgvCustom.AllowUserToDeleteRows = false;
            this.dgvCustom.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCustom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustom.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustom.Location = new System.Drawing.Point(3, 3);
            this.dgvCustom.Name = "dgvCustom";
            this.dgvCustom.ReadOnly = true;
            this.dgvCustom.Size = new System.Drawing.Size(556, 164);
            this.dgvCustom.TabIndex = 2;
            // 
            // tbpPannier
            // 
            this.tbpPannier.Controls.Add(this.cbbIdClient2);
            this.tbpPannier.Controls.Add(this.cbbIdCommande);
            this.tbpPannier.Controls.Add(this.txtIdClientDevis);
            this.tbpPannier.Controls.Add(this.label2);
            this.tbpPannier.Controls.Add(this.label1);
            this.tbpPannier.Controls.Add(this.txtIdCommandeDevis);
            this.tbpPannier.Controls.Add(this.btnSupprimer);
            this.tbpPannier.Controls.Add(this.btnCommander);
            this.tbpPannier.Controls.Add(this.dgvPanier);
            this.tbpPannier.Location = new System.Drawing.Point(4, 22);
            this.tbpPannier.Name = "tbpPannier";
            this.tbpPannier.Size = new System.Drawing.Size(1091, 414);
            this.tbpPannier.TabIndex = 2;
            this.tbpPannier.Text = "Pannier";
            this.tbpPannier.UseVisualStyleBackColor = true;
            // 
            // txtIdClientDevis
            // 
            this.txtIdClientDevis.Location = new System.Drawing.Point(694, 37);
            this.txtIdClientDevis.Name = "txtIdClientDevis";
            this.txtIdClientDevis.Size = new System.Drawing.Size(100, 20);
            this.txtIdClientDevis.TabIndex = 7;
            this.txtIdClientDevis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdClientDevis_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "num Utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "num Commande :";
            // 
            // txtIdCommandeDevis
            // 
            this.txtIdCommandeDevis.Location = new System.Drawing.Point(377, 34);
            this.txtIdCommandeDevis.Name = "txtIdCommandeDevis";
            this.txtIdCommandeDevis.Size = new System.Drawing.Size(100, 20);
            this.txtIdCommandeDevis.TabIndex = 4;
            this.txtIdCommandeDevis.TextChanged += new System.EventHandler(this.txtIdCommandeDevis_TextChanged);
            this.txtIdCommandeDevis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCommandeDevis_KeyPress);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupprimer.Location = new System.Drawing.Point(567, 269);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(175, 70);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnCommander
            // 
            this.btnCommander.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCommander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCommander.Location = new System.Drawing.Point(202, 269);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(181, 70);
            this.btnCommander.TabIndex = 2;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = false;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // dgvPanier
            // 
            this.dgvPanier.AllowUserToAddRows = false;
            this.dgvPanier.AllowUserToDeleteRows = false;
            this.dgvPanier.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPanier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanier.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPanier.Location = new System.Drawing.Point(82, 72);
            this.dgvPanier.Name = "dgvPanier";
            this.dgvPanier.ReadOnly = true;
            this.dgvPanier.Size = new System.Drawing.Size(915, 164);
            this.dgvPanier.TabIndex = 1;
            // 
            // tbpHistoire
            // 
            this.tbpHistoire.Location = new System.Drawing.Point(4, 22);
            this.tbpHistoire.Name = "tbpHistoire";
            this.tbpHistoire.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistoire.Size = new System.Drawing.Size(1091, 414);
            this.tbpHistoire.TabIndex = 1;
            this.tbpHistoire.Text = "Histoire";
            this.tbpHistoire.UseVisualStyleBackColor = true;
            // 
            // tbpCatalogue
            // 
            this.tbpCatalogue.Controls.Add(this.pnlTrie);
            this.tbpCatalogue.Controls.Add(this.cbbIdClient);
            this.tbpCatalogue.Controls.Add(this.label3);
            this.tbpCatalogue.Controls.Add(this.btnCustom);
            this.tbpCatalogue.Controls.Add(this.lblPannier);
            this.tbpCatalogue.Controls.Add(this.btnAjoutPannier);
            this.tbpCatalogue.Controls.Add(this.dgvVoitures);
            this.tbpCatalogue.Location = new System.Drawing.Point(4, 22);
            this.tbpCatalogue.Name = "tbpCatalogue";
            this.tbpCatalogue.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCatalogue.Size = new System.Drawing.Size(1091, 414);
            this.tbpCatalogue.TabIndex = 0;
            this.tbpCatalogue.Text = "Catalogue";
            this.tbpCatalogue.UseVisualStyleBackColor = true;
            // 
            // pnlTrie
            // 
            this.pnlTrie.Controls.Add(this.lblTrie);
            this.pnlTrie.Controls.Add(this.txbRechercheModele);
            this.pnlTrie.Controls.Add(this.label4);
            this.pnlTrie.Controls.Add(this.lblCateg);
            this.pnlTrie.Controls.Add(this.cbbCateg);
            this.pnlTrie.Location = new System.Drawing.Point(69, 270);
            this.pnlTrie.Name = "pnlTrie";
            this.pnlTrie.Size = new System.Drawing.Size(331, 119);
            this.pnlTrie.TabIndex = 12;
            // 
            // lblTrie
            // 
            this.lblTrie.AutoSize = true;
            this.lblTrie.Location = new System.Drawing.Point(109, 5);
            this.lblTrie.Name = "lblTrie";
            this.lblTrie.Size = new System.Drawing.Size(31, 13);
            this.lblTrie.TabIndex = 11;
            this.lblTrie.Text = "Trie :";
            // 
            // txbRechercheModele
            // 
            this.txbRechercheModele.Location = new System.Drawing.Point(160, 38);
            this.txbRechercheModele.Name = "txbRechercheModele";
            this.txbRechercheModele.Size = new System.Drawing.Size(100, 20);
            this.txbRechercheModele.TabIndex = 9;
            this.txbRechercheModele.TextChanged += new System.EventHandler(this.txbRechercheModele_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recherche Modele :\r\n";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Location = new System.Drawing.Point(71, 81);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(58, 13);
            this.lblCateg.TabIndex = 8;
            this.lblCateg.Text = "Catégorie :";
            // 
            // cbbCateg
            // 
            this.cbbCateg.FormattingEnabled = true;
            this.cbbCateg.Location = new System.Drawing.Point(160, 78);
            this.cbbCateg.Name = "cbbCateg";
            this.cbbCateg.Size = new System.Drawing.Size(121, 21);
            this.cbbCateg.TabIndex = 4;
            this.cbbCateg.SelectedIndexChanged += new System.EventHandler(this.cbbCateg_SelectedIndexChanged);
            // 
            // cbbIdClient
            // 
            this.cbbIdClient.FormattingEnabled = true;
            this.cbbIdClient.Location = new System.Drawing.Point(712, 313);
            this.cbbIdClient.Name = "cbbIdClient";
            this.cbbIdClient.Size = new System.Drawing.Size(121, 21);
            this.cbbIdClient.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "idCient :";
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.Blue;
            this.btnCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustom.Location = new System.Drawing.Point(903, 308);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(111, 23);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // lblPannier
            // 
            this.lblPannier.AutoSize = true;
            this.lblPannier.Location = new System.Drawing.Point(123, 198);
            this.lblPannier.Name = "lblPannier";
            this.lblPannier.Size = new System.Drawing.Size(0, 13);
            this.lblPannier.TabIndex = 3;
            // 
            // btnAjoutPannier
            // 
            this.btnAjoutPannier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjoutPannier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjoutPannier.Location = new System.Drawing.Point(475, 302);
            this.btnAjoutPannier.Name = "btnAjoutPannier";
            this.btnAjoutPannier.Size = new System.Drawing.Size(165, 40);
            this.btnAjoutPannier.TabIndex = 1;
            this.btnAjoutPannier.Text = "Ajouter au panier ";
            this.btnAjoutPannier.UseVisualStyleBackColor = false;
            this.btnAjoutPannier.Click += new System.EventHandler(this.btnAjoutPannier_Click_1);
            // 
            // dgvVoitures
            // 
            this.dgvVoitures.AllowUserToAddRows = false;
            this.dgvVoitures.AllowUserToDeleteRows = false;
            this.dgvVoitures.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVoitures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVoitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoitures.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVoitures.Location = new System.Drawing.Point(6, 3);
            this.dgvVoitures.Name = "dgvVoitures";
            this.dgvVoitures.ReadOnly = true;
            this.dgvVoitures.Size = new System.Drawing.Size(1079, 231);
            this.dgvVoitures.TabIndex = 0;
            this.dgvVoitures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoitures_CellContentClick);
            // 
            // tbcMenu1
            // 
            this.tbcMenu1.Controls.Add(this.tbpCatalogue);
            this.tbcMenu1.Controls.Add(this.tbpHistoire);
            this.tbcMenu1.Controls.Add(this.tbpPannier);
            this.tbcMenu1.Controls.Add(this.tbpCustomisation);
            this.tbcMenu1.Location = new System.Drawing.Point(298, 226);
            this.tbcMenu1.Name = "tbcMenu1";
            this.tbcMenu1.SelectedIndex = 0;
            this.tbcMenu1.Size = new System.Drawing.Size(1099, 440);
            this.tbcMenu1.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLogin.Location = new System.Drawing.Point(137, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 8;
            // 
            // cbbIdClient2
            // 
            this.cbbIdClient2.FormattingEnabled = true;
            this.cbbIdClient2.Location = new System.Drawing.Point(795, 308);
            this.cbbIdClient2.Name = "cbbIdClient2";
            this.cbbIdClient2.Size = new System.Drawing.Size(121, 21);
            this.cbbIdClient2.TabIndex = 9;
            this.cbbIdClient2.SelectedIndexChanged += new System.EventHandler(this.cbbIdClient2_SelectedIndexChanged);
            // 
            // cbbIdCommande
            // 
            this.cbbIdCommande.FormattingEnabled = true;
            this.cbbIdCommande.Location = new System.Drawing.Point(795, 269);
            this.cbbIdCommande.Name = "cbbIdCommande";
            this.cbbIdCommande.Size = new System.Drawing.Size(121, 21);
            this.cbbIdCommande.TabIndex = 8;
            this.cbbIdCommande.SelectedIndexChanged += new System.EventHandler(this.cbbIdCommande_SelectedIndexChanged);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1785, 859);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.tbcMenu1);
            this.Controls.Add(this.picbLogo);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.lblConnexion);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.tbpCustomisation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustom)).EndInit();
            this.tbpPannier.ResumeLayout(false);
            this.tbpPannier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).EndInit();
            this.tbpCatalogue.ResumeLayout(false);
            this.tbpCatalogue.PerformLayout();
            this.pnlTrie.ResumeLayout(false);
            this.pnlTrie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoitures)).EndInit();
            this.tbcMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Button btnAdmin;
        public System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.TabPage tbpCustomisation;
        private System.Windows.Forms.TabPage tbpPannier;
        private System.Windows.Forms.TabPage tbpHistoire;
        private System.Windows.Forms.TabPage tbpCatalogue;
        private System.Windows.Forms.Button btnAjoutPannier;
        private System.Windows.Forms.DataGridView dgvVoitures;
        private System.Windows.Forms.TabControl tbcMenu1;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Label lblPannier;
        private System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.DataGridView dgvPanier;
        private System.Windows.Forms.ComboBox cbbCateg;
        public System.Windows.Forms.DataGridView dgvCustom;
        private System.Windows.Forms.Button btnCustom;
        public System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCommandeDevis;
        private System.Windows.Forms.TextBox txtIdClientDevis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRechercheModele;
        private System.Windows.Forms.ComboBox cbbIdClient;
        private System.Windows.Forms.Panel pnlTrie;
        private System.Windows.Forms.Label lblTrie;
        private System.Windows.Forms.ComboBox cbbIdClient2;
        private System.Windows.Forms.ComboBox cbbIdCommande;
    }
}