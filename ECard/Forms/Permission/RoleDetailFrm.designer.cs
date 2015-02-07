namespace ECard.Forms.Permission
{
    partial class RoleDetailFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleDetailFrm));
            this.groupControlUpdate = new DevExpress.XtraEditors.GroupControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.CEUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.CESelect = new DevExpress.XtraEditors.CheckEdit();
            this.CEDelete = new DevExpress.XtraEditors.CheckEdit();
            this.CEInsert = new DevExpress.XtraEditors.CheckEdit();
            this.groupControlSelect = new DevExpress.XtraEditors.GroupControl();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new ECard.Datasource.dsData();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.roleDetialTableAdapter = new ECard.Datasource.dsDataTableAdapters.RoleDetialTableAdapter();
            this.rolesTableAdapter = new ECard.Datasource.dsDataTableAdapters.RolesTableAdapter();
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection16 = new DevExpress.Utils.ImageCollection(this.components);
            this.mbCDGeha = new DevExpress.XtraBars.BarButtonItem();
            this.mbTBLLabel = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPageCode = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCode = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageData = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageRoles = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageQry = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).BeginInit();
            this.groupControlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CESelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEInsert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).BeginInit();
            this.groupControlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlUpdate
            // 
            this.groupControlUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlUpdate.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlUpdate.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlUpdate.Controls.Add(this.ribbonControlMain);
            this.groupControlUpdate.Controls.Add(this.groupControl2);
            this.groupControlUpdate.Location = new System.Drawing.Point(9, 75);
            this.groupControlUpdate.Name = "groupControlUpdate";
            this.groupControlUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlUpdate.Size = new System.Drawing.Size(963, 251);
            this.groupControlUpdate.TabIndex = 1;
            this.groupControlUpdate.Text = "التفاصيل";
            // 
            // appMenu
            // 
            this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
            this.appMenu.Name = "appMenu";
            this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
            this.appMenu.ShowRightPane = true;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer2.Appearance.Options.UseBackColor = true;
            this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer2.Controls.Add(this.buttonEdit);
            this.popupControlContainer2.Location = new System.Drawing.Point(127, 218);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Size = new System.Drawing.Size(118, 28);
            this.popupControlContainer2.TabIndex = 5;
            this.popupControlContainer2.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "No Text";
            this.buttonEdit.Location = new System.Drawing.Point(3, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit.TabIndex = 0;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(45, 176);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
            this.popupControlContainer1.TabIndex = 4;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(36, 13);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "No Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(36, 13);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "No Info";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.CEUpdate);
            this.groupControl2.Controls.Add(this.CESelect);
            this.groupControl2.Controls.Add(this.CEDelete);
            this.groupControl2.Controls.Add(this.CEInsert);
            this.groupControl2.Location = new System.Drawing.Point(361, 169);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(240, 73);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "عناصر السماح";
            // 
            // CEUpdate
            // 
            this.CEUpdate.Location = new System.Drawing.Point(21, 49);
            this.CEUpdate.Name = "CEUpdate";
            this.CEUpdate.Properties.Caption = "تعديل";
            this.CEUpdate.Size = new System.Drawing.Size(75, 19);
            this.CEUpdate.TabIndex = 0;
            // 
            // CESelect
            // 
            this.CESelect.Location = new System.Drawing.Point(21, 24);
            this.CESelect.Name = "CESelect";
            this.CESelect.Properties.Caption = "عرض";
            this.CESelect.Size = new System.Drawing.Size(75, 19);
            this.CESelect.TabIndex = 0;
            // 
            // CEDelete
            // 
            this.CEDelete.Location = new System.Drawing.Point(144, 49);
            this.CEDelete.Name = "CEDelete";
            this.CEDelete.Properties.Caption = "حذف";
            this.CEDelete.Size = new System.Drawing.Size(75, 19);
            this.CEDelete.TabIndex = 0;
            // 
            // CEInsert
            // 
            this.CEInsert.Location = new System.Drawing.Point(144, 24);
            this.CEInsert.Name = "CEInsert";
            this.CEInsert.Properties.Caption = "اضافه";
            this.CEInsert.Size = new System.Drawing.Size(75, 19);
            this.CEInsert.TabIndex = 0;
            // 
            // groupControlSelect
            // 
            this.groupControlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlSelect.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlSelect.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlSelect.Controls.Add(this.LUEItems);
            this.groupControlSelect.Controls.Add(this.labelControl1);
            this.groupControlSelect.Location = new System.Drawing.Point(9, 10);
            this.groupControlSelect.Name = "groupControlSelect";
            this.groupControlSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControlSelect.Size = new System.Drawing.Size(963, 59);
            this.groupControlSelect.TabIndex = 0;
            this.groupControlSelect.Text = "جميع السماحيات";
            // 
            // LUEItems
            // 
            this.LUEItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUEItems.Location = new System.Drawing.Point(386, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "اسم الصلاحيه", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleDesc", "تعليق", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.LUEItems.Properties.DataSource = this.rolesBindingSource;
            this.LUEItems.Properties.DisplayMember = "RoleName";
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEItems.Properties.ValueMember = "RoleID";
            this.LUEItems.Size = new System.Drawing.Size(173, 20);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsTeachersUnion";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(565, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختار سماحيه";
            // 
            // roleDetialTableAdapter
            // 
            this.roleDetialTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Images = this.imageCollection16;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.mbCDGeha,
            this.mbTBLLabel});
            this.ribbonControlMain.LargeImages = this.imageCollection32;
            this.ribbonControlMain.Location = new System.Drawing.Point(2, 21);
            this.ribbonControlMain.MaxItemId = 3;
            this.ribbonControlMain.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCode,
            this.ribbonPageData,
            this.ribbonPageRoles,
            this.ribbonPageQry});
            this.ribbonControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControlMain.Size = new System.Drawing.Size(959, 142);
            // 
            // imageCollection16
            // 
            this.imageCollection16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection16.ImageStream")));
            this.imageCollection16.Images.SetKeyName(0, "CDGeha.png");
            this.imageCollection16.InsertGalleryImage("TBLLabel16.png", "images/chart/chart_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/chart_16x16.png"), 1);
            this.imageCollection16.Images.SetKeyName(1, "TBLLabel16.png");
            // 
            // mbCDGeha
            // 
            this.mbCDGeha.Caption = "اكواد الجهات";
            this.mbCDGeha.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbCDGeha.Id = 1;
            this.mbCDGeha.LargeImageIndex = 0;
            this.mbCDGeha.Name = "mbCDGeha";
            // 
            // mbTBLLabel
            // 
            this.mbTBLLabel.Caption = "حقول الكرت";
            this.mbTBLLabel.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mbTBLLabel.Id = 2;
            this.mbTBLLabel.ImageIndex = 1;
            this.mbTBLLabel.LargeImageIndex = 1;
            this.mbTBLLabel.Name = "mbTBLLabel";
            // 
            // imageCollection32
            // 
            this.imageCollection32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32.ImageStream")));
            this.imageCollection32.Images.SetKeyName(0, "CDGeha.png");
            this.imageCollection32.InsertGalleryImage("TBLLabel32.png", "images/chart/chart_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/chart_32x32.png"), 1);
            this.imageCollection32.Images.SetKeyName(1, "TBLLabel32.png");
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
            this.ribbonPageGroupData.Name = "ribbonPageGroupData";
            this.ribbonPageGroupData.Text = "ribbonPageGroup2";
            // 
            // ribbonPageRoles
            // 
            this.ribbonPageRoles.Name = "ribbonPageRoles";
            this.ribbonPageRoles.Text = "الصلاحيات";
            // 
            // ribbonPageQry
            // 
            this.ribbonPageQry.Name = "ribbonPageQry";
            this.ribbonPageQry.Text = "استعلامات";
            // 
            // RoleDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 330);
            this.Controls.Add(this.groupControlUpdate);
            this.Controls.Add(this.groupControlSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoleDetailFrm";
            this.Text = "السماحيات";
            this.Load += new System.EventHandler(this.EditorJobFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUpdate)).EndInit();
            this.groupControlUpdate.ResumeLayout(false);
            this.groupControlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CEUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CESelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEInsert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSelect)).EndInit();
            this.groupControlSelect.ResumeLayout(false);
            this.groupControlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlSelect;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit CEUpdate;
        private DevExpress.XtraEditors.CheckEdit CESelect;
        private DevExpress.XtraEditors.CheckEdit CEDelete;
        private DevExpress.XtraEditors.CheckEdit CEInsert;
        private Datasource.dsDataTableAdapters.RoleDetialTableAdapter roleDetialTableAdapter;
        private Datasource.dsData dsRetirementCenter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private Datasource.dsDataTableAdapters.RolesTableAdapter rolesTableAdapter;
        public DevExpress.XtraEditors.GroupControl groupControlUpdate;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.Utils.ImageCollection imageCollection16;
        private DevExpress.XtraBars.BarButtonItem mbCDGeha;
        private DevExpress.XtraBars.BarButtonItem mbTBLLabel;
        private DevExpress.Utils.ImageCollection imageCollection32;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCode;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageData;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupData;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRoles;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQry;
    }
}