using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionBD;
using GestionBD.MySQL;

namespace FeralBoutique
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDemarrage());

            //GestionBoutique.seConnecter();

            //Console.WriteLine(GestionUtilisateurs.ComputeSHA1("utilisateur"));

            //Console.WriteLine(GestionUtilisateurs.isAdmin("feral", "admin"));
        }
    }
}
