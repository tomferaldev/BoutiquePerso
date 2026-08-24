using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBD;
using GestionBD.MySQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FeralBoutique
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            GestionInterface.coloriserTabControl(tbc1);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            GestionInterface.remplirComboBox(cbbType, GestionUtilisateurs.getTypes(),"type","type");
            GestionInterface.remplirComboBox(cbbModifType, GestionUtilisateurs.getTypes(), "type", "type");
            dgvUtilisateurs.DataSource = GestionUtilisateurs.getTuples();
            dgvProduits.DataSource = GestionModeles.getTuples();
            dgvListeCateg.DataSource = GestionCategories.getTuples();
            GestionInterface.remplirComboBox(cbbCategorie, GestionCategories.getTypes(), "nom", "id");
            GestionInterface.remplirComboBox(cbbModifCategorie, GestionCategories.getTypes(), "nom", "id");
            GestionInterface.remplirComboBox(cbbVoitureVendus, GestionModeles.getNomProduit(), "nom_modele", "nom_modele");


        }
        #region GestionUtilisateursS

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (!GestionInterface.isEmailOk(txbEmail.Text))
            {
                erpEmail.SetError(txbEmail, "Adresse e-mail invalide !");
                txbEmail.BackColor = Color.Red;
            }
            else
            {
                if (!GestionUtilisateurs.IsUsernameUnique(txbLogin.Text))
                {
                    erpLogin.SetError(txbLogin, "Login déjà utilisés !");
                    txbLogin.BackColor = Color.Red;
                }
                else
                {
                    GestionUtilisateurs.ajouter(txbLogin.Text, txbPasse.Text, txbEmail.Text, cbbType.Text);
                    lblValidation.Visible = true;
                }

            }

            
        }

        

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (!GestionInterface.isEmailOk(txbModifEmail.Text))
            {
                erpModifEmail.SetError(txbModifEmail, "Adresse e-mail invalide !");
                txbModifEmail.BackColor = Color.Red;
            }
            else
            {
                if (!GestionUtilisateurs.IsUsernameUnique(txbModifLogin.Text))
                {
                    erpLogin.SetError(txbModifLogin, "Login déjà utilisés !");
                    txbModifLogin.BackColor = Color.Red;
                }
                else
                {

                    GestionUtilisateurs.modifier(Convert.ToInt32(txbModifId.Text), txbModifLogin.Text, txbModifPasse.Text, txbModifEmail.Text, cbbModifType.Text);
                    lblModif.Visible = true;
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            GestionUtilisateurs.supprimer(Convert.ToInt32(txbModifId.Text));
            lblSupprimer.Visible = true;
        }

        #endregion



        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            if (!GestionModeles.IsModeleUnique(txbNom.Text))
            {
                erpNom.SetError(txbNom, "Nom de modele déjà utilisés !");
                txbNom.BackColor = Color.Red;
            }
            else
            {
                GestionModeles.ajouter(txbMarque.Text, txbNom.Text, txtbAnnee.Text, txtbPrix.Text, txtbMoteur.Text, txbPuissance.Text, txtbImage.Text, txtbDesc.Text, cbbCategorie.SelectedValue.ToString()); ;
                lblAjoutProduit.Visible = true;
            }
        }
        private void dgvProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifie que l'utilisateur n'a pas cliqué sur l'en-tête
            {
                DataGridViewRow row = dgvProduits.Rows[e.RowIndex];
                txbModifModele.Text = row.Cells[0].Value.ToString(); //id
                txbModifMarque.Text = row.Cells[1].Value.ToString(); //Marque
                txbModifNom.Text = row.Cells[2].Value.ToString(); //Nom
                txbModifAnnee.Text = row.Cells[3].Value.ToString();
                txbModifPrix.Text = row.Cells[4].Value.ToString();
                txbModifMoteur.Text = row.Cells[5].Value.ToString();
                txbModifPuissance.Text = row.Cells[6].Value.ToString();
                txbModifImage.Text = row.Cells[7].Value.ToString();
                txbModifDesc.Text = row.Cells[8].Value.ToString();
            }
        }

        private void dgvUtilisateurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifie que l'utilisateur n'a pas cliqué sur l'en-tête
            {
                DataGridViewRow row = dgvUtilisateurs.Rows[e.RowIndex];
                txbModifId.Text = row.Cells["Id"].Value.ToString();
                txbModifLogin.Text = row.Cells["Login"].Value.ToString();
                txbModifPasse.Text = row.Cells["Passe"].Value.ToString();
                txbModifEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnModifProduit_Click(object sender, EventArgs e)
        {
            if (!GestionModeles.IsModeleUnique(txbNom.Text) == true)
            {
                erpNom.SetError(txbNom, "Nom de modele déjà utilisés !");
                txbModifNom.BackColor = Color.Red;
            }
            else
            {
                GestionModeles.modifier(txbModifModele.Text, txbModifMarque.Text, txbModifNom.Text, txbModifAnnee.Text, txbModifPrix.Text, txbModifMoteur.Text, txbModifPuissance.Text, txbModifImage.Text,txbModifDesc.Text,cbbModifCategorie.SelectedValue.ToString());
                lblModifProduit.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProduits.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                return;
            }
            else
            {
                GestionModeles.supprimer(Convert.ToInt32(txbModifModele.Text));
                lblSuppression.Visible = true;
            }
        }

        private void tbProduits_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutCateg_Click(object sender, EventArgs e)
        {
            GestionCategories.ajouter(txbNomCateg.Text);
            lblAjoutCategorie.Visible = true;
        }

        private void dgvListeCateg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifie que l'utilisateur n'a pas cliqué sur l'en-tête
            {
                DataGridViewRow row = dgvListeCateg.Rows[e.RowIndex];
                txbId.Text = row.Cells["id"].Value.ToString();
                txbNomCategModif.Text = row.Cells["nom"].Value.ToString();

            }
        }

        private void btnModifCateg_Click(object sender, EventArgs e)
        {
                GestionCategories.modifier(txbNomCategModif.Text, txbId.Text);
                lblModifCateg.Visible = true;

        }

        private void btnSupprCateg_Click(object sender, EventArgs e)
        {
            GestionCategories.supprimer(Convert.ToInt32(txbId.Text));
            lblSupprCateg.Visible = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnNbrModelesVendu_Click(object sender, EventArgs e)
        {
            if(cbbVoitureVendus.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un modèle de voiture.");
                return;
            }
            else
            {
                lblResultatNbrVoitureVendues.Text = "Nombre de modèles vendus : " + GestionPS.getNbProduitsVendus(cbbVoitureVendus.SelectedIndex.ToString());  //GestionModeles.getNbModelesVendusParNom(cbbVoitureVendus.Text).ToString();
            }
        }

        private void dgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

