namespace FeralBoutique
{
    partial class FrmDevis
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
            this.numCommande = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numCommande
            // 
            this.numCommande.AutoSize = true;
            this.numCommande.Location = new System.Drawing.Point(12, 20);
            this.numCommande.Name = "numCommande";
            this.numCommande.Size = new System.Drawing.Size(35, 13);
            this.numCommande.TabIndex = 0;
            this.numCommande.Text = "label1";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(652, 12);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(136, 28);
            this.btnImprimer.TabIndex = 1;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // FrmDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.numCommande);
            this.Name = "FrmDevis";
            this.Text = "FrmDevis";
            this.Load += new System.EventHandler(this.FrmDevis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numCommande;
        private System.Windows.Forms.Button btnImprimer;
    }
}