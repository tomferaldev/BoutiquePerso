using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeralBoutique
{
    internal class GestionInterface
    {
        private static readonly Color ThemeBackground = Color.FromArgb(18, 18, 18);
        private static readonly Color ThemePanel = Color.FromArgb(24, 24, 24);
        private static readonly Color ThemeText = Color.Gray;
        private static readonly Color ThemeAccent = Color.FromArgb(30, 144, 255);
        private static readonly Color ThemeAccentDark = Color.FromArgb(0, 102, 204);
        private static readonly Color ThemeMuted = Color.FromArgb(90, 90, 90);

        public static void remplirComboBox(ComboBox maComboBox, DataTable maDataTable, string displayMember, string valueMember)
        {
            maComboBox.DataSource = maDataTable;
            maComboBox.DisplayMember = displayMember;
            maComboBox.ValueMember = valueMember;
        }

        public static void coloriserDataGrid(DataGridView monDataDridView)
        {
            if (monDataDridView == null) return;

            monDataDridView.EnableHeadersVisualStyles = false;
            monDataDridView.ColumnHeadersDefaultCellStyle.BackColor = ThemePanel;
            monDataDridView.ColumnHeadersDefaultCellStyle.ForeColor = ThemeText;
            monDataDridView.DefaultCellStyle.Font = new Font("Arial", 12F);
            monDataDridView.DefaultCellStyle.SelectionBackColor = ThemeAccent;
            monDataDridView.DefaultCellStyle.SelectionForeColor = Color.Blue;
            monDataDridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            monDataDridView.BackgroundColor = ThemeBackground;
            monDataDridView.GridColor = Color.FromArgb(60, 60, 60);
        }

        // Applique le style à un bouton individuel
        public static void coloriserButton(Button btn)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = ThemePanel;
            btn.ForeColor = ThemeText;
            btn.Font = new Font("Bahnschrift Light", 12F);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = ThemeAccent;
            btn.FlatAppearance.MouseOverBackColor = ThemeAccent;
            btn.FlatAppearance.MouseDownBackColor = ThemeAccentDark;
        }

        // Style pour TextBox
        public static void coloriserTextBox(TextBox tb)
        {
            if (tb == null) return;

            tb.BackColor = Color.FromArgb(30, 30, 30);
            tb.ForeColor = ThemeText;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("Bahnschrift Light", 12F);
        }

        // Style pour ComboBox
        public static void coloriserComboBox(ComboBox cb)
        {
            if (cb == null) return;

            cb.BackColor = Color.FromArgb(30, 30, 30);
            cb.ForeColor = ThemeText;
            cb.FlatStyle = FlatStyle.Standard;
            cb.Font = new Font("Bahnschrift Light", 12F);
        }

        // Style pour Label
        public static void coloriserLabel(Label lbl)
        {
            if (lbl == null) return;

            lbl.ForeColor = ThemeText;
            lbl.Font = new Font("Bahnschrift Light", 12F);
            lbl.BackColor = Color.Transparent;
        }

        // Style pour LinkLabel (labels cliquables)
        public static void coloriserLinkLabel(LinkLabel ll)
        {
            if (ll == null) return;

            ll.LinkColor = ThemeAccent;
            ll.ActiveLinkColor = ThemeAccentDark;
            ll.VisitedLinkColor = ThemeMuted;
            ll.DisabledLinkColor = ThemeMuted;
            ll.BackColor = Color.Transparent;
            ll.Font = new Font("Bahnschrift Light", 12F);
        }

        // Style pour Panel
        public static void coloriserPanel(Panel pnl)
        {
            if (pnl == null) return;

            pnl.BackColor = ThemePanel;
            foreach (Control c in pnl.Controls)
            {
                coloriserControle(c);
            }
        }

        // Style pour MenuStrip / ToolStrip / StatusStrip
        public static void coloriserToolStrip(ToolStrip ts)
        {
            if (ts == null) return;

            ts.BackColor = ThemePanel;
            ts.ForeColor = ThemeText;
            foreach (ToolStripItem item in ts.Items)
            {
                item.ForeColor = ThemeText;
            }
        }

        // Style pour TabPage
        public static void coloriserTabPage(TabPage tp)
        {
            if (tp == null) return;

            tp.BackColor = ThemePanel;
            tp.ForeColor = ThemeText;
            tp.Font = new Font("Bahnschrift Light", 12F);

            foreach (Control c in tp.Controls)
            {
                coloriserControle(c);
            }
        }

        // Style pour TabControl (owner-draw pour onglets)
        public static void coloriserTabControl(TabControl tc)
        {
            if (tc == null) return;

            tc.BackColor = ThemeBackground;
            tc.ForeColor = ThemeText;
            tc.Font = new Font("Arial", 12F);
            tc.DrawMode = TabDrawMode.OwnerDrawFixed;
            tc.ItemSize = new Size(120, 28);
            tc.Padding = new Point(12, 3);

            // éviter d'attacher plusieurs fois les handlers
            tc.DrawItem -= TabControl_DrawItem;
            tc.DrawItem += TabControl_DrawItem;

            tc.Paint -= TabControl_PaintHeader;
            tc.Paint += TabControl_PaintHeader;

            foreach (TabPage tp in tc.TabPages)
            {
                coloriserTabPage(tp);
            }
        }

        // Paint handler : efface proprement la zone d'en-tête des onglets pour éviter les "lignes blanches"
        private static void TabControl_PaintHeader(object sender, PaintEventArgs e)
        {
            var tc = sender as TabControl;
            if (tc == null) return;

            // si aucun onglet, rien à faire
            if (tc.TabCount == 0) return;

            // hauteur de la zone d'onglets (utilise le premier onglet)
            Rectangle firstTab = tc.GetTabRect(0);
            int headerHeight = firstTab.Height + 4; // petite marge
            Rectangle headerRect = new Rectangle(0, 0, tc.Width, headerHeight);

            using (var bg = new SolidBrush(ThemeBackground))
            {
                e.Graphics.FillRectangle(bg, headerRect);
            }
        }

        // Handler de dessin des onglets : dessine la totalité du tabRect (évite gaps)
        private static void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tc = sender as TabControl;
            if (tc == null) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle tabRect = tc.GetTabRect(e.Index);

            // Remplir tout le rectangle d'onglet (pas de innerRect qui laisse des lignes)
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            using (var backBrush = new SolidBrush(selected ? ThemeAccent : ThemePanel))
            {
                g.FillRectangle(backBrush, tabRect);
            }

            // Optionnel : dessiner une légère séparation entre onglets (même couleur que background)
            using (var sepPen = new Pen(ThemeBackground, 1))
            {
                // ligne verticale droite pour séparer des onglets suivants
                g.DrawLine(sepPen, tabRect.Right - 1, tabRect.Top + 2, tabRect.Right - 1, tabRect.Bottom - 2);
            }

            // Bordure de l'onglet
            using (var borderPen = new Pen(selected ? ThemeAccentDark : Color.FromArgb(60, 60, 60)))
            {
                g.DrawRectangle(borderPen, tabRect.X, tabRect.Y, tabRect.Width - 1, tabRect.Height - 1);
            }

            // Texte onglet : couleur contrastée (utilise ThemeText pour lisibilité)
            string text = tc.TabPages[e.Index].Text ?? string.Empty;
            using (var foreBrush = new SolidBrush(ThemeText))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(text, tc.Font, foreBrush, tabRect, sf);
            }
        }

        // Méthode générique qui applique le style en fonction du type de contrôle
        public static void coloriserControle(Control c)
        {
            if (c == null) return;

            switch (c)
            {
                case Button b:
                    coloriserButton(b);
                    break;
                case TextBox t:
                    coloriserTextBox(t);
                    break;
                case ComboBox cb:
                    coloriserComboBox(cb);
                    break;
                case Label l:
                    coloriserLabel(l);
                    break;
                case Panel p:
                    coloriserPanel(p);
                    break;
                case DataGridView dgv:
                    coloriserDataGrid(dgv);
                    break;
                case MenuStrip ms:
                    coloriserToolStrip(ms);
                    break;
                case ToolStrip ts:
                    coloriserToolStrip(ts);
                    break;
                case TabControl tc:
                    coloriserTabControl(tc);
                    break;
                default:
                    c.ForeColor = ThemeText;
                    break;
            }

            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    coloriserControle(child);
                }
            }
        }

        // Applique le thème à un formulaire entier
        public static void coloriserForm(Form form)
        {
            if (form == null) return;

            form.BackColor = ThemeBackground;
            form.ForeColor = ThemeText;
            form.Font = new Font("Bahnschrift Light", 12F);

            foreach (Control c in form.Controls)
            {
                coloriserControle(c);
            }

            // si le formulaire contient des ToolStrip séparés (ex: statusStrip)
            foreach (Control c in form.Controls)
            {
                if (c is ToolStripContainer tsc)
                {
                    foreach (Control inner in tsc.Controls)
                        coloriserControle(inner);
                }
            }
        }

        public static bool isChaineValide(string chaine)
        {
            Regex myRegex;
            myRegex = new Regex("[a-zA-Z]");

            return myRegex.IsMatch(chaine); // retourne true ou false selon la vérification
        }
        public static bool isEmailOk(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

    }
}
