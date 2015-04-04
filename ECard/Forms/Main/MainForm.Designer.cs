namespace ECard.Forms.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.imageCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.mbCDGeha = new DevExpress.XtraBars.BarButtonItem();
            this.mbTBLLabel = new DevExpress.XtraBars.BarButtonItem();
            this.mbImportTBLALLDataUC = new DevExpress.XtraBars.BarButtonItem();
            this.mbTBLALLDataUC = new DevExpress.XtraBars.BarButtonItem();
            this.mbPrintCard1UC = new DevExpress.XtraBars.BarButtonItem();
            this.mbUsers = new DevExpress.XtraBars.BarButtonItem();
            this.mbRoles = new DevExpress.XtraBars.BarButtonItem();
            this.mbRoleDetail = new DevExpress.XtraBars.BarButtonItem();
            this.mbUserRoles = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPageCode = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCode = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageData = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageRoles = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQry = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPagePrint = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Images = this.imageCollection16;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.mbCDGeha,
            this.mbTBLLabel,
            this.mbImportTBLALLDataUC,
            this.mbTBLALLDataUC,
            this.mbPrintCard1UC,
            this.mbUsers,
            this.mbRoles,
            this.mbRoleDetail,
            this.mbUserRoles,
            this.ribbonGalleryBarItem1});
            this.ribbonControlMain.LargeImages = this.imageCollection32;
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 2;
            this.ribbonControlMain.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCode,
            this.ribbonPageData,
            this.ribbonPageRoles,
            this.ribbonPageQry,
            this.ribbonPagePrint});
            this.ribbonControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControlMain.Size = new System.Drawing.Size(1014, 144);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(12, 150);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Ribbon = this.ribbonControlMain;
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem1;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            this.backstageViewControl1.TabIndex = 1;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(189, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(290, 86);
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
            // 
            // imageCollection16
            // 
            this.imageCollection16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection16.ImageStream")));
            this.imageCollection16.Images.SetKeyName(0, "CDGeha.png");
            this.imageCollection16.InsertGalleryImage("TBLLabel16.png", "images/chart/chart_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/chart_16x16.png"), 1);
            this.imageCollection16.Images.SetKeyName(1, "TBLLabel16.png");
            this.imageCollection16.InsertGalleryImage("print_16x16.png", "images/print/print_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_16x16.png"), 2);
            this.imageCollection16.Images.SetKeyName(2, "print_16x16.png");
            this.imageCollection16.InsertGalleryImage("customer_16x16.png", "images/people/customer_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_16x16.png"), 3);
            this.imageCollection16.Images.SetKeyName(3, "customer_16x16.png");
            this.imageCollection16.InsertGalleryImage("technology_16x16.png", "images/programming/technology_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/technology_16x16.png"), 4);
            this.imageCollection16.Images.SetKeyName(4, "technology_16x16.png");
            this.imageCollection16.InsertGalleryImage("customization_16x16.png", "images/edit/customization_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/customization_16x16.png"), 5);
            this.imageCollection16.Images.SetKeyName(5, "customization_16x16.png");
            this.imageCollection16.InsertGalleryImage("publicfix_16x16.png", "images/people/publicfix_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/publicfix_16x16.png"), 6);
            this.imageCollection16.Images.SetKeyName(6, "publicfix_16x16.png");
            // 
            // mbCDGeha
            // 
            this.mbCDGeha.Caption = "اكواد الجهات";
            this.mbCDGeha.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbCDGeha.Id = 1;
            this.mbCDGeha.LargeImageIndex = 0;
            this.mbCDGeha.Name = "mbCDGeha";
            this.mbCDGeha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbCDGeha_ItemClick);
            // 
            // mbTBLLabel
            // 
            this.mbTBLLabel.Caption = "حقول الكرت";
            this.mbTBLLabel.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbTBLLabel.Id = 2;
            this.mbTBLLabel.ImageIndex = 1;
            this.mbTBLLabel.LargeImageIndex = 1;
            this.mbTBLLabel.Name = "mbTBLLabel";
            this.mbTBLLabel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbTBLLabel_ItemClick);
            // 
            // mbImportTBLALLDataUC
            // 
            this.mbImportTBLALLDataUC.Caption = "استيراد بيانات الكروت";
            this.mbImportTBLALLDataUC.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbImportTBLALLDataUC.Id = 3;
            this.mbImportTBLALLDataUC.ImageIndex = 1;
            this.mbImportTBLALLDataUC.LargeImageIndex = 1;
            this.mbImportTBLALLDataUC.Name = "mbImportTBLALLDataUC";
            this.mbImportTBLALLDataUC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbTBLALLData_ItemClick);
            // 
            // mbTBLALLDataUC
            // 
            this.mbTBLALLDataUC.Caption = "بيانات الكروت";
            this.mbTBLALLDataUC.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbTBLALLDataUC.Id = 4;
            this.mbTBLALLDataUC.ImageIndex = 1;
            this.mbTBLALLDataUC.LargeImageIndex = 1;
            this.mbTBLALLDataUC.Name = "mbTBLALLDataUC";
            this.mbTBLALLDataUC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbTBLALLDataUC_ItemClick);
            // 
            // mbPrintCard1UC
            // 
            this.mbPrintCard1UC.Caption = "طباعة الكارت 1";
            this.mbPrintCard1UC.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbPrintCard1UC.Id = 5;
            this.mbPrintCard1UC.ImageIndex = 2;
            this.mbPrintCard1UC.LargeImageIndex = 2;
            this.mbPrintCard1UC.Name = "mbPrintCard1UC";
            this.mbPrintCard1UC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbPrintCard1UC_ItemClick);
            // 
            // mbUsers
            // 
            this.mbUsers.Caption = "المستخدمين";
            this.mbUsers.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbUsers.Id = 6;
            this.mbUsers.ImageIndex = 3;
            this.mbUsers.LargeImageIndex = 3;
            this.mbUsers.Name = "mbUsers";
            this.mbUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbUsers_ItemClick);
            // 
            // mbRoles
            // 
            this.mbRoles.Caption = "الصلاحيات";
            this.mbRoles.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbRoles.Id = 7;
            this.mbRoles.ImageIndex = 4;
            this.mbRoles.LargeImageIndex = 4;
            this.mbRoles.Name = "mbRoles";
            this.mbRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbRoles_ItemClick);
            // 
            // mbRoleDetail
            // 
            this.mbRoleDetail.Caption = "تفاصيل الصلاحيات";
            this.mbRoleDetail.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbRoleDetail.Id = 8;
            this.mbRoleDetail.ImageIndex = 5;
            this.mbRoleDetail.LargeImageIndex = 5;
            this.mbRoleDetail.Name = "mbRoleDetail";
            this.mbRoleDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbRoleDetail_ItemClick);
            // 
            // mbUserRoles
            // 
            this.mbUserRoles.Caption = "صلاحيات المستخدمين";
            this.mbUserRoles.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbUserRoles.Id = 9;
            this.mbUserRoles.ImageIndex = 6;
            this.mbUserRoles.LargeImageIndex = 6;
            this.mbUserRoles.Name = "mbUserRoles";
            this.mbUserRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbUserRoles_ItemClick);
            // 
            // imageCollection32
            // 
            this.imageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32.ImageStream")));
            this.imageCollection32.Images.SetKeyName(0, "CDGeha.png");
            this.imageCollection32.InsertGalleryImage("TBLLabel32.png", "images/chart/chart_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/chart_32x32.png"), 1);
            this.imageCollection32.Images.SetKeyName(1, "TBLLabel32.png");
            this.imageCollection32.InsertGalleryImage("print_32x32.png", "images/print/print_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_32x32.png"), 2);
            this.imageCollection32.Images.SetKeyName(2, "print_32x32.png");
            this.imageCollection32.InsertGalleryImage("customer_32x32.png", "images/people/customer_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_32x32.png"), 3);
            this.imageCollection32.Images.SetKeyName(3, "customer_32x32.png");
            this.imageCollection32.InsertGalleryImage("technology_32x32.png", "images/programming/technology_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/technology_32x32.png"), 4);
            this.imageCollection32.Images.SetKeyName(4, "technology_32x32.png");
            this.imageCollection32.InsertGalleryImage("customization_32x32.png", "images/edit/customization_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/customization_32x32.png"), 5);
            this.imageCollection32.Images.SetKeyName(5, "customization_32x32.png");
            this.imageCollection32.InsertGalleryImage("publicfix_32x32.png", "images/people/publicfix_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/publicfix_32x32.png"), 6);
            this.imageCollection32.Images.SetKeyName(6, "publicfix_32x32.png");
            // 
            // ribbonPageCode
            // 
            this.ribbonPageCode.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCode});
            this.ribbonPageCode.Name = "ribbonPageCode";
            this.ribbonPageCode.Text = "الاكواد";
            // 
            // ribbonPageGroupCode
            // 
            this.ribbonPageGroupCode.ItemLinks.Add(this.mbCDGeha);
            this.ribbonPageGroupCode.Name = "ribbonPageGroupCode";
            this.ribbonPageGroupCode.Text = "الاكواد";
            // 
            // ribbonPageData
            // 
            this.ribbonPageData.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupData});
            this.ribbonPageData.Name = "ribbonPageData";
            this.ribbonPageData.Text = "ادخال البيانات";
            // 
            // ribbonPageGroupData
            // 
            this.ribbonPageGroupData.ItemLinks.Add(this.mbTBLLabel);
            this.ribbonPageGroupData.ItemLinks.Add(this.mbImportTBLALLDataUC);
            this.ribbonPageGroupData.ItemLinks.Add(this.mbTBLALLDataUC);
            this.ribbonPageGroupData.Name = "ribbonPageGroupData";
            this.ribbonPageGroupData.Text = "ribbonPageGroup2";
            // 
            // ribbonPageRoles
            // 
            this.ribbonPageRoles.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageRoles.Name = "ribbonPageRoles";
            this.ribbonPageRoles.Text = "الصلاحيات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mbUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.mbRoles);
            this.ribbonPageGroup1.ItemLinks.Add(this.mbRoleDetail);
            this.ribbonPageGroup1.ItemLinks.Add(this.mbUserRoles);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "الصلاحيات";
            // 
            // ribbonPageQry
            // 
            this.ribbonPageQry.Name = "ribbonPageQry";
            this.ribbonPageQry.Text = "استعلامات";
            // 
            // ribbonPagePrint
            // 
            this.ribbonPagePrint.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupPrint});
            this.ribbonPagePrint.Name = "ribbonPagePrint";
            this.ribbonPagePrint.Text = "الطباعة";
            // 
            // ribbonPageGroupPrint
            // 
            this.ribbonPageGroupPrint.ItemLinks.Add(this.mbPrintCard1UC);
            this.ribbonPageGroupPrint.Name = "ribbonPageGroupPrint";
            this.ribbonPageGroupPrint.Text = "طباعة الكروت";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            // 
            // 
            // 
            galleryItemGroup2.Caption = "Group1";
            this.ribbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.ribbonGalleryBarItem1.Id = 1;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 695);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbonControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControlMain;
            this.Text = "E Card";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCode;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageData;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRoles;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQry;
        private DevExpress.XtraBars.BarButtonItem mbCDGeha;
        private DevExpress.XtraBars.BarButtonItem mbTBLLabel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupData;
        private DevExpress.Utils.ImageCollection imageCollection16;
        private DevExpress.Utils.ImageCollection imageCollection32;
        private DevExpress.XtraBars.BarButtonItem mbImportTBLALLDataUC;
        private DevExpress.XtraBars.BarButtonItem mbTBLALLDataUC;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagePrint;
        private DevExpress.XtraBars.BarButtonItem mbPrintCard1UC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPrint;
        private DevExpress.XtraBars.BarButtonItem mbUsers;
        private DevExpress.XtraBars.BarButtonItem mbRoles;
        private DevExpress.XtraBars.BarButtonItem mbRoleDetail;
        private DevExpress.XtraBars.BarButtonItem mbUserRoles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
    }
}

