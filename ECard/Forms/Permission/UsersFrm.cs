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
    public partial class UsersFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(RolesFrm));
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = FXFW.SqlDB.LoadDataTable("SELECT UserID, UserName, UserPass, IsActive FROM Users");
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "UserName";
            LUEItems.Properties.ValueMember = "UserID";
        }
        public UsersFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            //return;//ActivePrivReady
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
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Users WHERE (UserID = {0})", LUEItems.EditValue), Con);
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
            if (TxtAddPass1.Text.Trim().Length == 0 || TxtAddPass1.Text.Trim() != TxtAddPass2.Text.Trim())
            {
                MsgDlg.Show("من فضلك ادخل كلمة المرور ..", MsgDlg.MessageType.Info);
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format(@"INSERT INTO Users (UserID, UserName, UserPass, IsActive) VALUES 
                ({0}, N'{1}', N'{2}', N'{3}')", FXFW.SqlDB.GetNewID("Users", "UserID"), TxtAddItem.Text.Trim(),
                TxtAddPass1.Text.Trim(), CEAddActive.Checked.ToString()), Con);
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
            if (TxtEditPass1.Text.Trim().Length == 0 || TxtEditPass1.Text.Trim() != TxtEditPass2.Text.Trim())
            {
                MsgDlg.Show("من فضلك ادخل كلمة المرور ..", MsgDlg.MessageType.Info);
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format(@"UPDATE Users SET UserName = N'{0}', UserPass = N'{1}', IsActive = N'{2}'
                WHERE (UserID = {3})", TxtEditItem.Text.Trim(), TxtEditPass1.Text.Trim(), CEEditActive.Checked.ToString(), LUEItems.EditValue), Con);
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
            if (TxtAddItem.Text.Trim().Length > 0)
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
                TxtEditPass1.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["UserPass"].ToString();
                TxtEditPass2.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["UserPass"].ToString();
                if (ItemsTbl.Rows[LUEItems.ItemIndex]["IsActive"].ToString() == "True")
                    CEEditActive.Checked = true;
                else
                    CEEditActive.Checked = false;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                TxtEditPass1.Text = string.Empty;
                TxtEditPass2.Text = string.Empty;
                CEEditActive.Checked = true;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LUEItems.EditValue = null;
        }
       
        #endregion
    }
}