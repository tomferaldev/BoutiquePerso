using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FeralBoutique
{
    public partial class FrmDevis : Form
    {
        FrmMenu leFormulaireParent = new FrmMenu();
        public FrmDevis(FrmMenu leFormulaire)
        {
            InitializeComponent();

            this.leFormulaireParent = leFormulaire;

        }

        private void FrmDevis_Load(object sender, EventArgs e)
        {
            // Initialisation ou configuration si nécessaire
        }



        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Exemple de mise en page pour le devis
            float yPosition = 100;
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;

            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);

            // Titre du devis
            e.Graphics.DrawString("Devis", headerFont, Brushes.Black, leftMargin, yPosition);
            yPosition += 40;

            // Parcourir les éléments du DataGridView dgvPannier
            foreach (DataGridViewRow row in leFormulaireParent.dgvPanier.Rows)
            {
                if (row.Cells["nom_modele"].Value != null && row.Cells["prix"].Value != null)
                {
                    string productName = row.Cells["nom_modele"].Value.ToString();
                    string productPrice = row.Cells["prix"].Value.ToString();

                    e.Graphics.DrawString($"{productName} - {productPrice} €", bodyFont, Brushes.Black, leftMargin, yPosition);
                    yPosition += 20;
                }
            }

            // Total
            yPosition += 20;
            e.Graphics.DrawString("Total: " + CalculerTotal() + " €", headerFont, Brushes.Black, leftMargin, yPosition);
        }

        private decimal CalculerTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in leFormulaireParent.dgvPanier.Rows)
            {
                if (row.Cells["prix"].Value != null && decimal.TryParse(row.Cells["prix"].Value.ToString(), out decimal price))
                {
                    total += price;
                }
            }

            return total;
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            previewDialog.ShowDialog();
        }
    }
}
