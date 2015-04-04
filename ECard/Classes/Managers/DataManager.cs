using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ECard.Classes.Managers
{
    public static class DataManager
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));
        public static Datasource.dsData ds = new Datasource.dsData();
        public static Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        private readonly static string AppMenuName = "mb";
        public static int ConnectionTimeout = 0;
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
        public static void SetAllCommandTimeouts(object adapter, int timeout)
        {
            var commands = adapter.GetType().InvokeMember("CommandCollection",
                    System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                    null, adapter, new object[0]);
            var sqlCommand = (System.Data.IDbCommand[])commands;
            foreach (var cmd in sqlCommand)
            {
                cmd.CommandTimeout = timeout;
            }
        }
        public static DataTable LoadExcelFile(string strFile, string sheetName, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                string query = string.Format("SELECT {0} FROM [{1}$]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MsgDlg.Show("Load Excel File Failed - " + ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            return dt;
        }
        public static DataTable LoadExcelFile(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);

                //strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

                OleDbConnection con = new OleDbConnection(strConnectionString);
                con.Open();
                DataTable dtSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                con.Close();
                if (dtSchema == null)
                    return dt;
                string sheetName = dtSchema.Rows[sheetIndex]["TABLE_NAME"].ToString();
                string query = string.Format("SELECT {0} FROM [{1}]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MsgDlg.Show("Load Excel File Failed - " + ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            return dt;
        }

        public static bool SavePrintOrder(Datasource.dsQry.XRepCard1DataTable PrintTbl)
        {
            bool output = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.E_CardConnectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLPrintOut (DataId, printdate, datein, userin) VALUES (@DataId, GETDATE(), GETDATE(), @userin)", con);
            SqlParameter PramDataId = new SqlParameter("@DataId", SqlDbType.Int);
            SqlParameter Pramuserin = new SqlParameter("@userin", SqlDbType.Int) { Value = UserManager.UserInfo.UserID };
            cmd.Parameters.Add(PramDataId);
            cmd.Parameters.Add(Pramuserin);
            
            try
            {
                con.Open();
                foreach (Datasource.dsQry.XRepCard1Row row in PrintTbl.Rows)
                {
                    PramDataId.Value = row.DataId;
                    cmd.ExecuteNonQuery();
                }
                output = true;
            }
            catch (SqlException ex)
            {
                Logger.Error(ex.Message, ex);
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error While Saving Printing Order", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            con.Close();
            return output;
        }
    }
}
