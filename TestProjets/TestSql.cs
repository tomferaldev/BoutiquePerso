
using GestionBD;
using GestionBD.MySQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Security.Cryptography;
using System.Data;
using System.ComponentModel.Design;
namespace TestProjets
{
    [TestClass]
    public class TestSql
    {
        [TestMethod]
        public void testCreationDutilisateur()
        {
            // Login unique pour éviter conflits en base
            string login = "testuser_" + Guid.NewGuid().ToString("N").Substring(0, 8);
            string passe = "Password123!";
            string email = login + "@example.test";
            int createdId = -1;

            try
            {
                // Vérifier qu'il n'existe pas déjà (précondition)
                Assert.IsTrue(GestionUtilisateurs.IsUsernameUnique(login), "Le login de test existe déjà en base.");

                // Création
                GestionUtilisateurs.ajouter(login, passe, email, "user");

                // Récupérer l'utilisateur inséré
                string safeLogin = login.Replace("'", "''");
                DataTable dt = GestionBoutique.getTuplesRequeteSelect("SELECT * FROM utilisateur WHERE login = '" + safeLogin + "'", "TestUser");

                Assert.IsNotNull(dt, "La requête de récupération a retourné null.");
                Assert.IsTrue(dt.Rows.Count == 1, "L'utilisateur n'a pas été inséré en base.");

                // Récupérer l'id pour cleanup
                createdId = Convert.ToInt32(dt.Rows[0]["id"]);

                // Vérification supplémentaire : IsUsernameUnique doit maintenant être false
                Assert.IsFalse(GestionUtilisateurs.IsUsernameUnique(login), "IsUsernameUnique doit retourner false après insertion.");
            }
            finally
            {
                // Nettoyage : supprimer l'utilisateur créé si besoin
                if (createdId != -1)
                {
                    try
                    {
                        GestionUtilisateurs.supprimer(createdId);
                    }
                    catch
                    {
                        // Ne pas lever d'exception dans le finally du test
                    }
                }
            }
        }
    }
}

