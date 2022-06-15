using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text;
using My_Médiathèque_Online.inc.view;
using My_Médiathèque_Online.inc.view.mdp;
using My_Médiathèque_Online.service;
using My_Médiathèque_Online.secure;
using System.Configuration;
/*
* judicael 11/04/2022
*
*/

namespace My_Médiathèque_Online
{
    static class Program
    {

        private static bool isConnected = false;
        private static IDictionary<string,Form> pages = new Dictionary<string,Form>();
        private static long nbr;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            System.Diagnostics.Debug.WriteLine("static void main");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pages.Add("StartUp", new StartUp() );
            Application.Run(pages["StartUp"]);

        }
        public static bool IsConnected()
        {
            System.Diagnostics.Debug.WriteLine("static void IsConnected");
            return isConnected;
        }
        public static void SetConnected(bool connect)
        {
            isConnected = connect;
        }
        public static void ChangePage(string nextPage, string previousPage)
        {
            if (previousPage != "none")
            {
                pages[previousPage].Hide();
            }
            if (IsConnected())
            {
                System.Diagnostics.Debug.WriteLine("static bool login");
                if (!pages.ContainsKey(nextPage))
                {
                    switch (nextPage)
                    {
                        case "accueil":
                            pages.Add("accueil", new page_acceuil());
                            pages["accueil"].ShowDialog();
                            break;
                        case "login":
                            pages.Add("login", new page_login());
                            pages["login"].ShowDialog();
                            break;
                        case "mdp_demande":
                            pages.Add("mdp_demande", new page_mdp_demande());
                            pages["mdp_demande"].ShowDialog();
                            break;
                        case "mdp_change":
                            pages.Add("mdp_change", new page_mdp_change());
                            pages["mdp_change"].ShowDialog();
                            break;
                        case "mdp_codeConf":
                            pages.Add("mdp_codeConf", new page_mdp_codeConf());
                            pages["mdp_codeConf"].ShowDialog();
                            break;
                        case "gestion_users":
                            pages.Add("gestion_users", new page_gestion_users());
                            pages["gestion_users"].ShowDialog();
                            break;
                        case "userRecord":
                            pages.Add("userRecord", new page_userRecord());
                            pages["userRecord"].ShowDialog();
                            break;

                        case "gestionLivres":
                            pages.Add("gestionLivres", new page_gestion_livres());
                            pages["gestionLivres"].ShowDialog();
                            break;

                        case "gestionBiblio":
                            pages.Add("gestionBiblio", new page_gestion_bibliotheque());
                            pages["gestionBiblio"].ShowDialog();
                            break;
                        case "gestionRetards":
                            pages.Add("gestionRetards", new page_gestion_retard());
                            pages["gestionRetards"].ShowDialog();
                            break;
                        case "newUserRecord":
                            pages.Add("newUserRecord", new page_new_user());
                            pages["newUserRecord"].ShowDialog();
                            break;
                        case "ficheRetard":
                            pages.Add("ficheRetard", new page_ficheRetard());
                            pages["ficheRetard"].ShowDialog();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (nextPage)
                    {
                        case "accueil":
                            pages.Remove("accueil");
                            pages.Add("accueil", new page_acceuil());
                            pages["accueil"].ShowDialog();
                            break;
                        case "login":
                            pages.Remove("login");
                            pages.Add("login", new page_login());
                            pages["login"].ShowDialog();
                            break;
                        case "mdp_demande":
                            pages.Remove("mdp_demande");
                            pages.Add("mdp_demande", new page_mdp_demande());
                            pages["mdp_demande"].ShowDialog();
                            break;
                        case "mdp_change":
                            pages.Remove("mdp_change");
                            pages.Add("mdp_change", new page_mdp_change());
                            pages["mdp_change"].ShowDialog();
                            break;
                        case "mdp_codeConf":
                            pages.Remove("mdp_codeConf");
                            pages.Add("mdp_codeConf", new page_mdp_codeConf());
                            pages["mdp_codeConf"].ShowDialog();
                            break;
                        case "gestion_users":
                            pages.Remove("gestion_users");
                            pages.Add("gestion_users", new page_gestion_users());
                            pages["gestion_users"].ShowDialog();
                            break;
                        case "userRecord":
                            pages.Remove("userRecord");
                            pages.Add("userRecord", new page_userRecord());
                            pages["userRecord"].ShowDialog();
                            break;

                        case "gestionLivres":
                            pages.Remove("gestionLivres");
                            pages.Add("gestionLivres", new page_gestion_livres());
                            pages["gestionLivres"].ShowDialog();
                            break;

                        case "gestionBiblio":
                            pages.Remove("gestionBiblio");
                            pages.Add("gestionBiblio", new page_gestion_bibliotheque());
                            pages["gestionBiblio"].ShowDialog();
                            break;
                        case "gestionRetards":
                            pages.Remove("gestionRetards");
                            pages.Add("gestionRetards", new page_gestion_retard());
                            pages["gestionRetards"].ShowDialog();
                            break;
                        case "newUserRecord":
                            pages.Remove("newUserRecord");
                            pages.Add("newUserRecord", new page_new_user());
                            pages["newUserRecord"].ShowDialog();
                            break;
                        case "ficheRetard":
                            pages.Remove("ficheRetard");
                            pages.Add("ficheRetard", new page_ficheRetard());
                            pages["ficheRetard"].ShowDialog();
                            break;

                        default:
                            break;
                    }
                }
            }
            else
            {
                if (!pages.ContainsKey("login"))
                {
                    pages.Add("login", new page_login());
                    pages["login"].ShowDialog();
                }
                else
                {
                    if(!pages["login"].IsDisposed)
                    {
                        pages["login"] = new page_login();
                        pages["login"].ShowDialog();
                    }
                    else
                    {
                        pages.Remove("login");
                        pages["login"].ShowDialog();
                    }
                }
            }

        }
       
        public static void SetNbr(long id)
        {
            nbr = id;
        }
        public static long GetNbr()
        {
            return nbr;
        }
        
    }
}
