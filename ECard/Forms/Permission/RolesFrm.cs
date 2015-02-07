using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ECard.Forms.Permission
{
    public partial class RolesFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(RolesFrm));
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleID, RoleName, RoleDesc FROM Roles");
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "RoleName";
            LUEItems.Properties.ValueMember = "RoleID";
        }
        public RolesFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            Classes.Managers.DataManager.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEItems.Visible = Selecting;
            BtnAdd.Visible = Inserting;
            BtnUpdate.Visible = Updateing;
            BtnDelete.Visible = Deleting;
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadData();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد؟", MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;

            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Roles WHERE (RoleID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEItems.ItemIndex = -1;
                    MsgDlg.ShowAlert("تم الحذف ..", MsgDlg.MessageType.Success, this);
                    Logger.Info("تم الحذف ..");
                }
                catch (Exception ex)
                {
                    MsgDlg.ShowAlert(ex.Message, MsgDlg.MessageType.Success, this);
                    Logger.Info(ex.Message, ex);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO Roles (RoleID, RoleName, RoleDesc) VALUES ({0}, N'{1}', N'{2}')", FXFW.SqlDB.GetNewID("Roles", "RoleID"), TxtNewItem.Text.Trim(), TxtNewDes.Text.Trim()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MsgDlg.ShowAlert("تم الاضافه ..", MsgDlg.MessageType.Success, this);
                    Logger.Info("تم الاضافه ..");
                }
                catch (Exception ex)
                {
                    MsgDlg.ShowAlert(ex.Message, MsgDlg.MessageType.Success, this);
                    Logger.Info(ex.Message, ex);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Roles SET RoleName = N'{0}', RoleDesc = N'{1}' WHERE (RoleID = {2})", TxtEditItem.Text.Trim(), TxtEditDes.Text.Trim(), LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MsgDlg.ShowAlert("تم التعديل ..", MsgDlg.MessageType.Success, this);
                    Logger.Info("تم التعديل ..");

                }
                catch (Exception ex)
                {
                    MsgDlg.ShowAlert(ex.Message, MsgDlg.MessageType.Success, this);
                    Logger.Info(ex.Message, ex);
                }
            }
        }
        private void TxtNewItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewItem.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditItem.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditItem.Text = LUEItems.Text;
                TxtEditDes.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["RoleDesc"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                TxtEditDes.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        
        #endregion
    }
}