using ECard.Forms.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;

namespace ECard.Forms.Main
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            //Load Skins and layout
            InitSkinGallery();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true, true);
            ribbonGalleryBarItem1.GalleryItemClick += rgbiSkins_GalleryItemClick;
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);

            //IsMdiContainer = true;
        }
        void rgbiSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            FXFW.UserSkinSettings us = new FXFW.UserSkinSettings() { SkinName = UserLookAndFeel.Default.ActiveSkinName };
            SaveSettings(us);
        }
        private static FXFW.UserSkinSettings LoadSettings(string fileName)
        {
            FXFW.UserSkinSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as FXFW.UserSkinSettings; }
            finally { fStream.Close(); }
            return us;
        }
        private static void SaveSettings(FXFW.UserSkinSettings us)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (System.IO.Stream fStream = new System.IO.FileStream(FXFW.SqlDB.StyleSettingsPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }
        private void LoadUserPriv()
        {
            //Hide All Tools
            for (int i = 0; i < ribbonControlMain.Items.Count; i++)
            {
                if (ribbonControlMain.Items[i].GetType().Name == "BarButtonItem")
                {
                    if (ribbonControlMain.Items[i].Name == "mbHelp" || ribbonControlMain.Items[i].Name == "mbExit" || ribbonControlMain.Items[i].Name == "mbAbout" ||
                        ribbonControlMain.Items[i].Name == "mbSkins" || ribbonControlMain.Items[i].Name == "mbInfo" || ribbonControlMain.Items[i].Name == "mbStatus" ||
                        ribbonControlMain.Items[i].Name == "mbPasswordChanger")
                        continue;
                    ribbonControlMain.Items[i].Visibility = BarItemVisibility.Never;
                }

            }
            //Customizing menu visibility depand on user roles
            foreach (Datasource.dsData.RoleDetialRow row in Classes.Managers.UserManager.RoleDetial)
            {
                for (int i = 0; i < ribbonControlMain.Items.Count; i++)
                {
                    if (row.MenuItemName == ribbonControlMain.Items[i].Name)
                        ribbonControlMain.Items[i].Visibility = BarItemVisibility.Always;
                }
            }
        }
        private void ShowUC(UserControl uc, string Caption)
        {
            uc.Dock = DockStyle.Fill;
            Form Frm = new Form() { MdiParent = this, Text = Caption, WindowState = FormWindowState.Maximized, ShowIcon = false};
            Frm.Controls.Add(uc);
            Frm.Show();
        }
        private void ShowForm(Form Frm)
        {
            Frm.WindowState = FormWindowState.Maximized;
            Frm.ShowIcon = false;
            Frm.MdiParent = this;
            Frm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserPriv();
            this.Text += " - " + Classes.Managers.UserManager.UserInfo.UserName;
        }
        private void mbCDGeha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUC(new ECard.Forms.Code.CDGehaUC(), "اكواد الجهات");
        }
        private void mbTBLLabel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUC(new ECard.Forms.Code.TBLLabelUC(), "حقول الكرت");
        }
        private void mbTBLALLData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUC(new ECard.Forms.Data.ImportTBLALLDataUC(), "استيراد بيانات الكروت");
        }
        private void mbTBLALLDataUC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUC(new ECard.Forms.Data.TBLALLDataUC(), "بيانات الكروت");
        }
        private void mbPrintCard1UC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUC(new ECard.Forms.Print.PrintCard1UC(), "طباعة الكارت 1");
        }
        private void mbUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ECard.Forms.Permission.UsersFrm());
        }
        private void mbRoles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ECard.Forms.Permission.RolesFrm());
        }
        private void mbRoleDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ECard.Forms.Permission.RoleDetailFrm());
        }
        private void mbUserRoles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ECard.Forms.Permission.UserRolesFrm());
        }

        

        
    }
}
