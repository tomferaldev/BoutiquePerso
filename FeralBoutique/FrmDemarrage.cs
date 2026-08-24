using GestionBD;
using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FeralBoutique
{
    public partial class FrmDemarrage : Form
    {
        public FrmDemarrage()
        {
            InitializeComponent();


            GestionInterface.coloriserTextBox(txtLogin);
            GestionInterface.coloriserTextBox(txtMdp);
            GestionInterface.coloriserButton(btnLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text; //récupération du Login et du Mdp et hachage du mdp en sha1 
            string passe = txtMdp.Text;


            if (GestionUtilisateurs.isAdmin(login, passe) == true)
            {
                FrmMenu Menu = new FrmMenu();
                Menu.lblStatut.Text = "Admin";
                Menu.lblLogin.Text = login;
                Menu.Show();
                this.Hide();

            }
            else
            {
                if (GestionUtilisateurs.isUtilisateur(login, passe) == true)
                {
                    FrmMenu Menu = new FrmMenu();
                    Menu.lblStatut.Text = "Utilisateur";
                    Menu.lblLogin.Text = login;
                    Menu.Show();
                    this.Hide();


                }
                else
                {
                    lblErreur.Visible = true;
                    lblErreur.Text = "Mot de passe ou login invalide";
                }
            }
                        
                       
        }

        private void FrmDemarrage_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
        }
    }
}
