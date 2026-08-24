using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBD.MySQL;

namespace FeralBoutique
{
    public partial class FrmListeClients : Form
    {
        public FrmListeClients()
        {
            InitializeComponent();
        }

        private void FrmListeClients_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();

            dgvClients.DataSource = GestionClients.getTuples();
            GestionInterface.coloriserDataGrid(dgvClients);

            GestionInterface.remplirComboBox(cbClient, GestionClients.getPatronymes(), "Patronyme", "id");

            
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idClient = (int)cbClient.SelectedValue;
                DataRow leClient = GestionClients.getTupleById(idClient);

                txtNom.Text = leClient[1].ToString();
                txtPrenom.Text = leClient[2].ToString();
            }
            catch
            {

            }
        }
    }
}
