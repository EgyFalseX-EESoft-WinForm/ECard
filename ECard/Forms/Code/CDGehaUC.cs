using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace ECard.Forms.Code
{
    public partial class CDGehaUC : DevExpress.XtraEditors.XtraUserControl
    {
        public CDGehaUC()
        {
            InitializeComponent();

        }
        void LoadData()
        {

            //mBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            //{
            //    this.Invoke(new MethodInvoker(() =>
            //    {
            //        XPSCSData.Session.ConnectionString = Properties.Settings.Default.E_CardConnectionString;
            //        gridControlMain.DataSource = XPSCSData;
            //        mBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //    }));
            //});
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            Classes.Managers.DataManager.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);

            gridControlMain.Visible = Selecting;
            XPSCSData.AllowNew = Inserting;
            XPSCSData.AllowEdit = Updateing;
            XPSCSData.AllowRemove = Deleting;
        }
        private void CDGehaFrm_Load(object sender, EventArgs e)
        {
            //LoadData();
            ActivePriv();
        }
        private void mbExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        private void mbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DevExpress.Xpo.Helpers.ObjectSet obj = (DevExpress.Xpo.Helpers.ObjectSet)sessionData.GetObjectsToSave();
            //if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
            //    return;
            //DevExpress.Xpo.AsyncCommitCallback CommitCallBack = new DevExpress.Xpo.AsyncCommitCallback((o) =>
            //{
            //    SplashScreenManager.CloseForm();
            //    if (o == null)
            //        MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)this.ParentForm);
            //    else
            //        MsgDlg.ShowAlert("Saving Failed ..." + Environment.NewLine + o.Message, MsgDlg.MessageType.Error, (Form)this.ParentForm);
            //});
            //SplashScreenManager.ShowForm(typeof(ECard.Forms.Main.WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            //sessionData.CommitTransactionAsync(CommitCallBack);
        }
        private void repositoryItemButtonEditallimgpath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btn = (ButtonEdit)sender;
            if (ofd.ShowDialog() == DialogResult.OK)
                btn.EditValue = ofd.FileName;
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject obj = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(e.RowHandle);
            obj.SetMemberValue("GehaId", -1);
        }
        private void sessionData_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            DevExpress.Xpo.Helpers.ObjectSet obj = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave(true);
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in obj)
            {
                if (item.IsDeleted)
                    continue;

                if (item.GetMemberValue("GehaId").ToString() == "-1")
                    item.SetMemberValue("GehaId", Classes.Managers.DataManager.adpQry.GetNewId_CDGeha());
                item.SetMemberValue("userin", Classes.Managers.UserManager.UserInfo.UserID);
                item.SetMemberValue("datein", Classes.Managers.DataManager.GetServerDatetime);
            }
        }

    }
}
