using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;

namespace ECard.Forms.Permission
{
    public partial class RoleDetailFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        //DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl = new MainFrm().ribbonControl;
        #endregion
        #region -   Functions   -
       
        private void DisableMenu()
        {
            for (int menuIndex = 0; menuIndex < ribbonControlMain.Items.Count; menuIndex++)
            {
                ribbonControlMain.Items[menuIndex].ImageIndex = -1; ribbonControlMain.Items[menuIndex].LargeImageIndex = -1;
            }
        }
        private void PrepareMenu()
        {
            //string msg = string.Empty;

            for (int menuIndex = 0; menuIndex < ribbonControlMain.Items.Count; menuIndex++)
            {
                //msg += ribbonControl.Items[menuIndex].Name + " - " + ribbonControl.Items[menuIndex].Caption + " - " + ribbonControl.Items[menuIndex].GetType().Name + Environment.NewLine;
                //if (ribbonControl.Items[menuIndex].GetType().Name != "BarButtonItem")
                //    ribbonControl.Items[menuIndex].Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                ribbonControlMain.Items[menuIndex].Tag = ribbonControlMain.Items[menuIndex].ImageIndex;
                ribbonControlMain.Items[menuIndex].ItemDoubleClick += Item_ItemDoubleClick;

                if (ribbonControlMain.Items[menuIndex].GetType() == typeof(DevExpress.XtraBars.BarSubItem))
                {
                    for (int i = 0; i < ((DevExpress.XtraBars.BarSubItem)ribbonControlMain.Items[menuIndex]).ItemLinks.Count; i++)
                        ((DevExpress.XtraBars.BarSubItem)ribbonControlMain.Items[menuIndex]).ItemLinks[i].Item.ItemClick += Item_ItemDoubleClick;
                }
                for (int i = 0; i < appMenu.ItemLinks.Count; i++)
                {
                    appMenu.ItemLinks[i].Item.ItemClick += Item_ItemDoubleClick;
                }
            }
            //Console.Write(msg);
            DisableMenu();
        }
        private void FillRoleDetial()
        {
            DisableMenu();
            for (int menuIndex = 0; menuIndex < ribbonControlMain.Items.Count; menuIndex++)
            {
                for (int rowIndex = 0; rowIndex < dsRetirementCenter.RoleDetial.Rows.Count; rowIndex++)
                {
                    Datasource.dsData.RoleDetialRow row = (Datasource.dsData.RoleDetialRow)dsRetirementCenter.RoleDetial.Rows[rowIndex];
                    if (ribbonControlMain.Items[menuIndex].Name == row.MenuItemName)
                    {
                        ribbonControlMain.Items[menuIndex].ImageIndex = (int)ribbonControlMain.Items[menuIndex].Tag;
                        ribbonControlMain.Items[menuIndex].LargeImageIndex = (int)ribbonControlMain.Items[menuIndex].Tag;
                        
                    }
                }
            }
        }
        public RoleDetailFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            //return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            Classes.Managers.DataManager.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEItems.Visible = Selecting;
            if (Inserting || Updateing || Deleting)
                ribbonControlMain.Visible = true;
            else
                ribbonControlMain.Visible = false;
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            //groupControlUpdate.Controls.Add(ribbonControl);
            PrepareMenu();
            // TODO: This line of code loads data into the 'dsTeachersUnion.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.dsRetirementCenter.Roles);
            ActivePriv();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.EditValue == null)
                return;
            roleDetialTableAdapter.FillByRoleID(dsRetirementCenter.RoleDetial, Convert.ToInt32(LUEItems.EditValue));
            FillRoleDetial();
        }
        private void Item_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            roleDetialTableAdapter.Insert(Convert.ToInt32(LUEItems.EditValue), e.Item.Name, 
                CESelect.Checked, CEInsert.Checked, CEUpdate.Checked, CEDelete.Checked);
            if (e.Item.ImageIndex == -1)
            {
                e.Item.ImageIndex = (int)e.Item.Tag;
                e.Item.LargeImageIndex = (int)e.Item.Tag;
            }
            else
            {
                e.Item.ImageIndex = -1;
                e.Item.LargeImageIndex = -1;
            }
        }
        #endregion

    }
}