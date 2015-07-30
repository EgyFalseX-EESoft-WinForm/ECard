using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.SqlClient;
using log4net;
using ECard.Classes.Managers;

namespace ECard.Forms.Data
{
    public partial class ImportTBLALLDataUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportTBLALLDataUC));
        Datasource.dsDataTableAdapters.TBLALLDataTableAdapter adp = new Datasource.dsDataTableAdapters.TBLALLDataTableAdapter();
        
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
No	
1
2
3
4
5
6
7
8
9
10
11
12
13
14
img
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportTBLALLDataUC()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(adp, DataManager.ConnectionTimeout);
            cDGehaTableAdapter.Fill(dsData.CDGeha);
        }
        private void ShowHideProgress(bool ShowHide)
        {
            if (ShowHide)
                PnlProg.Invoke(new MethodInvoker(() => { PnlProg.Show(); layoutControlItemPnlProg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; }));
            else
                PnlProg.Invoke(new MethodInvoker(() => { PnlProg.Hide(); layoutControlItemPnlProg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; }));
            Application.DoEvents();
        }
        private void ChangeProgressCaption(string Caption)
        {
            PnlProg.Invoke(new MethodInvoker(() => { PnlProg.Caption = Caption; }));
            Application.DoEvents();
        }
        private bool ImportFromExcel()
        {
            //return false;
            bool output = false;

            AddLog("بداء الاستيراد ...");
            DataTable dtExcel = new DataTable();

            //if (SSM.IsSplashFormVisible)
            //    SSM.CloseWaitForm();
            ShowHideProgress(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        ChangeProgressCaption(String.Format("تحميل ملف [{0}] المحتوي[1 of 1]", (i + 1)));
                        DataTable dtPart = DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                        {
                            AddLog("File empty " + lbcFilePath.Items[i]);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
            }));

            if (dtExcel.Rows.Count == 0)
            {
                ShowHideProgress(false);
                AddLog("Importing Aborted");
                MsgDlg.Show("No Data Found", MsgDlg.MessageType.Error);
                return false;
            }

            DateTime dtStart = DateTime.Now;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.E_CardConnectionString);
            SqlCommand cmd = new SqlCommand("", con) { CommandTimeout = 0 };

            con.Open();

            int ProcessedCounter = 0;
            int ProcessedMax = dtExcel.Rows.Count;
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));

            ShowHideProgress(false);

            DateTime DateIn = DataManager.GetServerDatetime;
            int Geha = Convert.ToInt32(lueGeha.EditValue);

            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    //double DonePercent = ProcessedCounter / ProcessedMax;
                    Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);
                        Application.DoEvents();
                    }));
                }
                Datasource.dsData.TBLALLDataRow SqlRow = dsData.TBLALLData.NewTBLALLDataRow();

                SqlRow.GehaId = Geha;
                if (row["No"].ToString() != string.Empty)
                    SqlRow.PersonNumerUonic = Convert.ToInt32(row["No"]);
                SqlRow.text1 = row["1"].ToString();
                SqlRow.text2 = row["2"].ToString();
                SqlRow.text3 = row["3"].ToString();
                SqlRow.text4 = row["4"].ToString();
                DateTime dt;
                if (DateTime.TryParse(row["5"].ToString(), out dt))
                    SqlRow.text5 = dt;    
                if (DateTime.TryParse(row["6"].ToString(), out dt))
                    SqlRow.text6 = dt;
                SqlRow.text7 = row["7"].ToString();
                SqlRow.text8 = row["8"].ToString();
                SqlRow.text9 = row["9"].ToString();
                SqlRow.text10 = row["10"].ToString();
                SqlRow.text11 = row["11"].ToString();
                SqlRow.text12 = row["12"].ToString();
                SqlRow.text13 = row["13"].ToString();
                SqlRow.text14 = row["14"].ToString();
                SqlRow.imgpath = row["img"].ToString();
                SqlRow.datein = DateIn;
                SqlRow.userin = UserManager.UserInfo.UserID;
                SqlRow.DataId = 1;
                dsData.TBLALLData.AddTBLALLDataRow(SqlRow);
                SqlRow.EndEdit();
                adp.Update(SqlRow);
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTime.Text = "0 sec";
                ProgressBarMain.EditValue = ProcessedMax;
                lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);
                Application.DoEvents();
            }));
            ShowHideProgress(true);
            ChangeProgressCaption("تحديث قاعدة البيانات ...");
            //if (!Equipment.UpdateBulkEquipment(cmd, dsData.Equipment, Convert.ToInt16(tbYear.EditValue), Convert.ToInt16(tbMonth.EditValue)))
            //    MsgDlg.Show("Update Equipment Failed", MsgDlg.MessageType.Error);
            //else
            //{
            //    AddLog("New Equipment Saved " + dsData.Equipment.Count);
            //}
            
            output = true;
            dsData.TBLALLData.AcceptChanges();
            ShowHideProgress(false);
            MsgDlg.Show("تم الحفظ ...", MsgDlg.MessageType.Success);
            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.TBLALLData.Clear(); dsData.TBLALLData.Dispose();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();

            return output;
        }
        private void AddLog(string strLog)
        {
            Invoke(new MethodInvoker(() =>
            {
                tbLog.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                Logger.Info(strLog);
            }));
        }
        public void ActivateRules()
        {
            //btnImport.Visible = _elementRule.Inserting;
        }
        
        #endregion
        #region -   Event Handlers   -
        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string item in ofd.FileNames)
            {
                int found = lbcFilePath.FindString(item);
                if (found != -1)
                    continue;
                lbcFilePath.Items.Add(item);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lbcFilePath.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbcFilePath.Items.Remove(lbcFilePath.SelectedItems[i]);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lbcFilePath.ItemCount == 0)
            {
                MsgDlg.Show("من فضلك اضف ملف", MsgDlg.MessageType.Info, null);
                return;
            }
            if (FXFW.SqlDB.IsNullOrEmpty(lueGeha.EditValue))
            {
                MsgDlg.Show("من فضلك اختر جهة", MsgDlg.MessageType.Info, null);
                return;
            }
            layoutControlGroupCommand.Enabled = false;
            try
            {
                BackgroundWorker ImportWorker = new BackgroundWorker();
                ImportWorker.DoWork += ImportWorker_DoWork;
                ImportWorker.RunWorkerCompleted += ImportWorker_RunWorkerCompleted;
                ImportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MsgDlg.Show("لم نتمكن من الاستيراد. - " + ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportFromExcel())
            {
                e.Result = dt;
            }
            else
                e.Result = null;
        }
        void ImportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                DateTime dt = (DateTime)e.Result;
                MsgDlg.Show(String.Format("تم الاستيراد {0} in {1} ثانية", Environment.NewLine, Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds)), MsgDlg.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion
        
    }
}
