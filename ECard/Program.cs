using DevExpress.LookAndFeel;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ECard
{
    static class Program
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(Application.StartupPath + "\\Classes\\Log4Net\\L4N.config"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (FXFW.SqlDB.LoadSqlDBPath("E_Card"))
            {
                Classes.Managers.DataManager.SetConnectionString(FXFW.SqlDB.SqlConStr);

                using (ECard.Forms.Main.LoginFrm FrmLogin = new ECard.Forms.Main.LoginFrm())
                {
                    //Create Administrator user if not exists b4 show login form
                    if (!Classes.Managers.DataManager.PrepareBaseRole())
                        return;
                    //DatabaseScripts.FireScript();//add my views
                    FrmLogin.ShowDialog();
                }

                Application.Run(new Forms.Main.MainForm());
            }
            
        }
    }
}
