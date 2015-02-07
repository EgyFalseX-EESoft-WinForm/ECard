using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECard.Classes.Managers
{
    public static class DataManager
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));
        public static Datasource.dsData ds = new Datasource.dsData();
        public static Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        private readonly static string AppMenuName = "mb";
        public static void SetConnectionString(string connectionString)
        {
            Properties.Settings.Default["E_CardConnectionString"] = connectionString;
            DevExpress.Xpo.XpoDefault.ConnectionString = connectionString;
        }
        public static DateTime GetServerDatetime
        {
            get
            {
                return (DateTime)adpQry.GetServerDatetime();
            }
        }
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;

            if (FormName.Substring(FormName.Length - 3).ToLower() == "frm")
                FormName = FormName.Substring(0, FormName.Length - 3);
            if (FormName.Substring(FormName.Length - 2).ToLower() == "uc")
                FormName = FormName.Substring(0, FormName.Length - 2);
            FormName = AppMenuName + FormName;
            foreach (Datasource.dsData.RoleDetialRow row in UserManager.RoleDetial.Rows)
            {
                if (row.MenuItemName != FormName)
                    continue;
                if (row.Selecting)
                    Selecting = row.Selecting;
                if (row.Inserting)
                    Inserting = row.Inserting;
                if (row.Updateing)
                    Updateing = row.Updateing;
                if (row.Deleting)
                    Deleting = row.Deleting;
            }
        }
        public static bool PrepareBaseRole()
        {
            using (Forms.Main.MainForm frm = new Forms.Main.MainForm())
            {
                using (Datasource.dsDataTableAdapters.RoleDetialTableAdapter adp = new Datasource.dsDataTableAdapters.RoleDetialTableAdapter())
                {
                    try
                    {
                        foreach (DevExpress.XtraBars.BarItem item in frm.ribbonControlMain.Items)
                        {
                            if (item.Name != string.Empty)
                            {
                                adp.InsertBaseRole(1, item.Name, true, true, true, true);
                            }
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MsgDlg.ShowAlert(ex.Message, System.Windows.Forms.MsgDlg.MessageType.Success, new System.Windows.Forms.Form());
                        Logger.Info(ex.Message, ex);
                        throw ex;
                    }
                }
            }
        }
    }
}
