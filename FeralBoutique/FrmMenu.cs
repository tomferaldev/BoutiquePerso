using GestionBD;
using GestionBD.MySQL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FeralBoutique
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            GestionInterface.coloriserButton(btnAdmin);
            GestionInterface.coloriserTabControl(tbcMenu1);
            GestionInterface.coloriserLabel(lblConnexion);
            GestionInterface.coloriserLabel(lblStatut);
            

        }

        private void lblCatalogue_Click(object sender, EventArgs e)
        {

        }

        private void lblConnexion_Click(object sender, EventArgs e)
        {

        }

        private void tbcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbpCatalogue_Click(object sender, EventArgs e)
        {
            //GestionBoutique.seConnecter();

            //dgvVoitures.DataSource = GestionProduits.getTuples();
            //GestionInterface.coloriserDataGrid(dgvVoitures);


        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (lblStatut.Text == "Admin")
            {
                btnAdmin.Visible = true;
                btnAdmin.Enabled = true;
            }

            // Remplir le DataGridView "dgvVoitures" avec les modèles de voitures  
            DataTable vehiculesTable = GestionModeles.getTuples(); // Récupère les données des modèles de voitures  
            dgvVoitures.DataSource = vehiculesTable;

            // Optionnel : Appliquer un style ou une mise en forme au DataGridView  
            GestionInterface.coloriserDataGrid(dgvVoitures);
            GestionInterface.coloriserDataGrid(dgvCustom);

            // Remplir la ComboBox "cbbCateg" avec toutes les catégories
            DataTable categoriesTable = GestionCategories.getTuples(); // Récupère les catégories
            cbbCateg.Items.Clear();
            foreach (DataRow row in categoriesTable.Rows)
            {
                cbbCateg.Items.Add(row["nom"].ToString());
            }

            DataTable pannierTable = new DataTable();
            pannierTable.Columns.Add("marque", typeof(string));
            pannierTable.Columns.Add("nom_modele", typeof(string));
            pannierTable.Columns.Add("annee", typeof(int));
            pannierTable.Columns.Add("prix", typeof(decimal));
            pannierTable.Columns.Add("moteur", typeof(string));
            pannierTable.Columns.Add("puissance", typeof(int));

            dgvPanier.DataSource = pannierTable;
            cbbIdClient.Focus();

            //Remplissage des comboBox
            DataTable Utilisateurs = GestionUtilisateurs.getTuples();

            cbbIdClient.DataSource = Utilisateurs;
            cbbIdClient.DisplayMember = "login";   // ce qui est affiché
            cbbIdClient.ValueMember = "id";

            cbbIdClient2.DataSource = Utilisateurs;
            cbbIdClient2.DisplayMember = "login";   // ce qui est affiché
            cbbIdClient2.ValueMember = "id";

            DataTable Commandes = GestionCommande.getToutesLesCommandes();

            cbbIdCommande.DataSource = Commandes;
            cbbIdCommande.DisplayMember = "idCommande";
            cbbIdCommande.ValueMember = "idClient";
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin Admin = new FrmAdmin();
            Admin.Show();
        }



        private void btnAjoutPannier_Click_1(object sender, EventArgs e)
        {


            if (dgvVoitures.CurrentRow == null)
                return;
            else
            {
                if (cbbIdClient.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez entrer un ID client ou Utilisateur avant d'ajouter des articles au panier.");
                    return;
                }
                else
                {
                    int idUtilisateur = Convert.ToInt32(cbbIdClient.SelectedValue);

                    DataGridViewRow selectedRow = dgvVoitures.CurrentRow;
                    string idProduit = selectedRow.Cells["id"].Value.ToString();
                    string marque = selectedRow.Cells["marque"].Value.ToString();
                    string modele = selectedRow.Cells["nom_modele"].Value.ToString();
                    string annee = selectedRow.Cells["annee"].Value.ToString();
                    string prix = selectedRow.Cells["prix"].Value.ToString();
                    string moteur = selectedRow.Cells["moteur"].Value.ToString();
                    string puissance = selectedRow.Cells["puissance"].Value.ToString();

                    if (GestionUtilisateurs.isClient(idUtilisateur) == false)
                    {
                        GestionClients.ajouterSansInfo(idUtilisateur); //Transformatino d'utilisateur en client 
                    }
                    if (GestionCommande.verifierCommande(idUtilisateur) == false)
                    {
                        GestionCommande.ajouterCommande(idUtilisateur); // Si le client n'a pas de commande en cours on l'ajoute
                    }
                    int idCommande = GestionCommande.getIdCommandeEnCours(idUtilisateur); // Récupération de l'id de la commande en cours
                    GestionCommande.ajouterLigne(idCommande, Convert.ToInt16(idProduit)); // Ajout de la ligne commande en base de données
                    lblPannier.Text = $"Articles dans le panier : {dgvPanier.Rows.Count}";


                    dgvPanier.Refresh();
                }
            }

        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            string pdfPath = "devis.pdf";

            Document doc = new Document(PageSize.A4, 40, 40, 60, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
            doc.Open();

            // ---------- ENTÊTE ----------
            Paragraph header = new Paragraph("Feral Boutique\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 26));
            header.Alignment = Element.ALIGN_CENTER;
            doc.Add(header);

            Paragraph subHeader = new Paragraph("Devis client\n\n",
                FontFactory.GetFont(FontFactory.HELVETICA, 14, BaseColor.DARK_GRAY));
            subHeader.Alignment = Element.ALIGN_CENTER;
            doc.Add(subHeader);

            // Ligne horizontale
            LineSeparator line = new LineSeparator();
            line.LineWidth = 1;
            line.LineColor = BaseColor.GRAY;
            doc.Add(new Chunk(line));

            doc.Add(new Paragraph("\n")); // espace

            // ---------- TABLEAU DES ARTICLES ----------
            PdfPTable table = new PdfPTable(dgvPanier.Columns.Count);
            table.WidthPercentage = 100;
            table.SpacingBefore = 10f;
            table.SpacingAfter = 10f;

            // Style entêtes
            BaseColor headerBg = new BaseColor(230, 230, 230);
            Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            foreach (DataGridViewColumn col in dgvPanier.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                cell.BackgroundColor = headerBg;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5;
                table.AddCell(cell);
            }

            // Lignes du tableau
            Font rowFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);

            decimal total = 0;

            foreach (DataGridViewRow row in dgvPanier.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell bodyCell = new PdfPCell(
                            new Phrase(cell.Value?.ToString() ?? "", rowFont)
                        );
                        bodyCell.Padding = 5;
                        bodyCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(bodyCell);
                    }

                    // total
                    decimal prix = Convert.ToDecimal(row.Cells["prix"].Value);
                    total += prix;
                }
            }

            doc.Add(table);

            // ---------- TOTAL ----------
            Paragraph totalText = new Paragraph(
                $"Total : {total:C2}\n\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK)
            );
            totalText.Alignment = Element.ALIGN_RIGHT;
            doc.Add(totalText);

            // ---------- FOOTER ----------
            doc.Add(new Paragraph("\nMerci pour votre confiance.",
                FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12)));

            doc.Add(new Paragraph("Signature : __________________________\n\n",
                FontFactory.GetFont(FontFactory.HELVETICA, 12)));

            doc.Close();
            writer.Close();

            MessageBox.Show("PDF généré avec succès !");

            System.Diagnostics.Process.Start(pdfPath);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPanier.CurrentRow != null) // Vérifie si une ligne est sélectionnée
            {
                // Supprime la ligne sélectionnée du DataGridView "dgvPannier"
                dgvPanier.Rows.RemoveAt(dgvPanier.CurrentRow.Index);

                // Met à jour le label lblPannier avec le nombre de lignes restantes dans dgvPannier
                lblPannier.Text = $"Articles dans le panier : {dgvPanier.Rows.Count}";
            }
            else
            {
                // Affiche un message d'erreur si aucune ligne n'est sélectionnée
                MessageBox.Show("Aucune ligne sélectionnée pour suppression !");
            }
        }

        private void cbbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCateg.SelectedItem != null) // Vérifie si une catégorie est sélectionnée
            {
                string selectedCategory = cbbCateg.SelectedItem.ToString();

                // Récupère les modèles de voitures filtrés par la catégorie sélectionnée
                DataTable filteredVehicles = GestionModeles.getTuplesByCategory(selectedCategory);

                // Met à jour le DataGridView "dgvVoitures" avec les données filtrées
                dgvVoitures.DataSource = filteredVehicles;

                // Optionnel : Appliquer un style ou une mise en forme au DataGridView
                GestionInterface.coloriserDataGrid(dgvVoitures);
            }
        }

        private void dgvVoitures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (dgvVoitures.CurrentRow != null) // Vérifie si une ligne est sélectionnée
            {
                // Copie la ligne sélectionnée dans le DataGridView "dgvCustom"
                DataGridViewRow selectedRow = dgvVoitures.CurrentRow;
                DataTable customTable = (DataTable)dgvCustom.DataSource;

                if (customTable == null)
                {
                    customTable = new DataTable();
                    foreach (DataGridViewColumn column in dgvVoitures.Columns)
                    {
                        customTable.Columns.Add(column.Name, column.ValueType);
                    }
                    dgvCustom.DataSource = customTable;
                }

                DataRow newRow = customTable.NewRow();
                foreach (DataGridViewColumn column in dgvVoitures.Columns)
                {
                    newRow[column.Name] = selectedRow.Cells[column.Name].Value;
                }
                customTable.Rows.Add(newRow);
            }
            else
            {
                // Affiche un message d'erreur si aucune ligne n'est sélectionnée
                MessageBox.Show("Aucune ligne sélectionnée !");
            }
        }

        private void txtIdCommandeDevis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCommandeDevis_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtIdCommandeDevis.Text == string.Empty)
                {
                    MessageBox.Show("Veuillez entrer un ID de commande.");
                    return;
                }
                string idCommande = txtIdCommandeDevis.Text;
                DataTable dt = GestionPS.getLignesCommande(Convert.ToInt32(idCommande));
                dgvPanier.DataSource = dt;
                dgvPanier.Refresh();
            }
        }

        private void txtIdClientDevis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtIdClientDevis.Text == string.Empty)
                {
                    MessageBox.Show("Veuillez entrer un ID de client");
                    return;
                }
                string idClient = txtIdClientDevis.Text;
                DataTable dt = GestionPS.getLignesCommandesByClient(Convert.ToInt16(idClient));
                dgvPanier.DataSource = dt;
                dgvPanier.Refresh();
            }
        }

        private void txbRechercheModele_TextChanged(object sender, EventArgs e)
        {
            string recherche = txbRechercheModele.Text.ToLower();
            DataTable vehiculesTable = GestionModeles.getTuples();
            var filteredRows = vehiculesTable.AsEnumerable()
                .Where(row => row.Field<string>("nom_modele").ToLower().Contains(recherche) ||
                              row.Field<string>("marque").ToLower().Contains(recherche));
            if (filteredRows.Any())
            {
                dgvVoitures.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                dgvVoitures.DataSource = null; 
            }
            GestionInterface.coloriserDataGrid(dgvVoitures);
        }

        private void cbbIdCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbIdCommande.ValueMember == string.Empty)
            {
                MessageBox.Show("Veuillez entrer un ID de client");
                return;
            }
            string idClient = cbbIdCommande.ValueMember;
            DataTable dt = GestionPS.getLignesCommandesByClient(Convert.ToInt16(idClient));
            dgvPanier.DataSource = dt;
            dgvPanier.Refresh();
        }

        private void cbbIdClient2_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (cbbIdClient2.ValueMember == string.Empty)
        //    {
        //        MessageBox.Show("Veuillez entrer un ID de client");
        //        return;
        //    }
        //    string idClient = cbbIdClient2.ValueMember;
        //    DataTable dt = GestionPS.getLignesCommandesByClient(Convert.ToInt16(idClient));
        //    dgvPanier.DataSource = dt;
        //    dgvPanier.Refresh();
        }
    }
}

