namespace ECard.Forms.Code
{
    partial class CDGehaUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDGehaUC));
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mbSave = new DevExpress.XtraBars.BarButtonItem();
            this.mbExport = new DevExpress.XtraBars.BarButtonItem();
            this.mBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.XPSCSData = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionData = new DevExpress.Xpo.Session(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGeha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehaDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colallimgpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditallimgpath = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.SSM = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ECard.Forms.Main.WaitWindowFrm), true, true, DevExpress.XtraSplashScreen.ParentType.UserControl);
            this.dsData = new ECard.Datasource.dsData();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ECard.Datasource.dsDataTableAdapters.UsersTableAdapter();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditallimgpath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mbSave,
            this.mbExport,
            this.mBar});
            this.barManagerMain.MainMenu = this.bar2;
            this.barManagerMain.MaxItemId = 3;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mbSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.mBar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // mbSave
            // 
            this.mbSave.Caption = "Save";
            this.mbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("mbSave.Glyph")));
            this.mbSave.Id = 0;
            this.mbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mbSave.LargeGlyph")));
            this.mbSave.Name = "mbSave";
            this.mbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.mbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbSave_ItemClick);
            // 
            // mbExport
            // 
            this.mbExport.Caption = "Export";
            this.mbExport.Glyph = ((System.Drawing.Image)(resources.GetObject("mbExport.Glyph")));
            this.mbExport.Id = 1;
            this.mbExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mbExport.LargeGlyph")));
            this.mbExport.Name = "mbExport";
            this.mbExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbExport_ItemClick);
            // 
            // mBar
            // 
            this.mBar.Caption = "Please Wait ...";
            this.mBar.Edit = this.repositoryItemMarqueeProgressBar1;
            this.mBar.Id = 2;
            this.mBar.Name = "mBar";
            this.mBar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.mBar.Width = 100;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.MarqueeAnimationSpeed = 200;
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            this.repositoryItemMarqueeProgressBar1.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(787, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(787, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(787, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.XPSCSData;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 24);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditallimgpath});
            this.gridControlMain.Size = new System.Drawing.Size(787, 403);
            this.gridControlMain.TabIndex = 9;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // XPSCSData
            // 
            this.XPSCSData.AllowEdit = true;
            this.XPSCSData.AllowNew = true;
            this.XPSCSData.AllowRemove = true;
            this.XPSCSData.DeleteObjectOnRemove = true;
            this.XPSCSData.ObjectType = typeof(ECard.Datasource.dsData.CDGehaDataTable);
            this.XPSCSData.Session = this.sessionData;
            // 
            // sessionData
            // 
            this.sessionData.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionData.TrackPropertiesModifications = false;
            this.sessionData.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionData_BeforeCommitTransaction);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGeha,
            this.colGehaDes,
            this.colallimgpath});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new customer";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewMain_InitNewRow);
            // 
            // colGeha
            // 
            this.colGeha.AppearanceCell.Options.UseTextOptions = true;
            this.colGeha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeha.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeha.Caption = "الجهة";
            this.colGeha.FieldName = "Geha";
            this.colGeha.Name = "colGeha";
            this.colGeha.Visible = true;
            this.colGeha.VisibleIndex = 0;
            this.colGeha.Width = 187;
            // 
            // colGehaDes
            // 
            this.colGehaDes.AppearanceCell.Options.UseTextOptions = true;
            this.colGehaDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaDes.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehaDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaDes.Caption = "تعريف";
            this.colGehaDes.FieldName = "GehaDes";
            this.colGehaDes.Name = "colGehaDes";
            this.colGehaDes.Visible = true;
            this.colGehaDes.VisibleIndex = 1;
            this.colGehaDes.Width = 159;
            // 
            // colallimgpath
            // 
            this.colallimgpath.AppearanceCell.Options.UseTextOptions = true;
            this.colallimgpath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colallimgpath.AppearanceHeader.Options.UseTextOptions = true;
            this.colallimgpath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colallimgpath.Caption = "مسار الصور";
            this.colallimgpath.ColumnEdit = this.repositoryItemButtonEditallimgpath;
            this.colallimgpath.FieldName = "allimgpath";
            this.colallimgpath.Name = "colallimgpath";
            this.colallimgpath.Visible = true;
            this.colallimgpath.VisibleIndex = 2;
            this.colallimgpath.Width = 245;
            // 
            // repositoryItemButtonEditallimgpath
            // 
            this.repositoryItemButtonEditallimgpath.AutoHeight = false;
            this.repositoryItemButtonEditallimgpath.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditallimgpath.Name = "repositoryItemButtonEditallimgpath";
            this.repositoryItemButtonEditallimgpath.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemButtonEditallimgpath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditallimgpath_ButtonClick);
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsData;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // CDGehaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CDGehaUC";
            this.Size = new System.Drawing.Size(787, 427);
            this.Load += new System.EventHandler(this.CDGehaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditallimgpath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem mbSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem mbExport;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colGeha;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaDes;
        private DevExpress.XtraGrid.Columns.GridColumn colallimgpath;
        private DevExpress.XtraBars.BarEditItem mBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditallimgpath;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Datasource.dsData dsData;
        private Datasource.dsDataTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSData;
        private DevExpress.Xpo.Session sessionData;
        private DevExpress.XtraSplashScreen.SplashScreenManager SSM;
        private System.Windows.Forms.FolderBrowserDialog fbd;


    }
}
