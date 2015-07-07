namespace ECard.Forms.Data
{
    partial class TBLALLDataUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLALLDataUC));
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
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditGehaId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cDGehaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new ECard.Datasource.dsData();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGeha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehaDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonNumerUonic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditallimgpath = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.XPSCSData = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionData = new DevExpress.Xpo.Session(this.components);
            this.SSM = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ECard.Forms.Main.WaitWindowFrm), true, true, DevExpress.XtraSplashScreen.ParentType.UserControl);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ECard.Datasource.dsDataTableAdapters.UsersTableAdapter();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cDGehaTableAdapter = new ECard.Datasource.dsDataTableAdapters.CDGehaTableAdapter();
            this.coltext13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGehaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDGehaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditallimgpath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).BeginInit();
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
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 24);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditallimgpath,
            this.repositoryItemGridLookUpEditGehaId});
            this.gridControlMain.Size = new System.Drawing.Size(787, 403);
            this.gridControlMain.TabIndex = 9;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colPersonNumerUonic,
            this.coltext1,
            this.coltext2,
            this.coltext3,
            this.coltext4,
            this.coltext5,
            this.coltext6,
            this.coltext7,
            this.coltext8,
            this.coltext9,
            this.coltext10,
            this.coltext11,
            this.coltext12,
            this.coltext13,
            this.colimgpath});
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
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "الجهة";
            this.gridColumn2.ColumnEdit = this.repositoryItemGridLookUpEditGehaId;
            this.gridColumn2.FieldName = "GehaId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEditGehaId
            // 
            this.repositoryItemGridLookUpEditGehaId.AutoHeight = false;
            this.repositoryItemGridLookUpEditGehaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditGehaId.DataSource = this.cDGehaBindingSource;
            this.repositoryItemGridLookUpEditGehaId.DisplayMember = "Geha";
            this.repositoryItemGridLookUpEditGehaId.Name = "repositoryItemGridLookUpEditGehaId";
            this.repositoryItemGridLookUpEditGehaId.NullText = "";
            this.repositoryItemGridLookUpEditGehaId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditGehaId.ValueMember = "GehaId";
            this.repositoryItemGridLookUpEditGehaId.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cDGehaBindingSource
            // 
            this.cDGehaBindingSource.DataMember = "CDGeha";
            this.cDGehaBindingSource.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGeha,
            this.colGehaDes});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colGeha
            // 
            this.colGeha.AppearanceCell.Options.UseTextOptions = true;
            this.colGeha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeha.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeha.Caption = "الاسم";
            this.colGeha.FieldName = "Geha";
            this.colGeha.Name = "colGeha";
            this.colGeha.Visible = true;
            this.colGeha.VisibleIndex = 0;
            // 
            // colGehaDes
            // 
            this.colGehaDes.AppearanceCell.Options.UseTextOptions = true;
            this.colGehaDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaDes.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehaDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaDes.Caption = "معلومات";
            this.colGehaDes.FieldName = "GehaDes";
            this.colGehaDes.Name = "colGehaDes";
            this.colGehaDes.Visible = true;
            this.colGehaDes.VisibleIndex = 1;
            // 
            // colPersonNumerUonic
            // 
            this.colPersonNumerUonic.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonNumerUonic.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonNumerUonic.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonNumerUonic.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonNumerUonic.Caption = "الرقم الخاص";
            this.colPersonNumerUonic.FieldName = "PersonNumerUonic";
            this.colPersonNumerUonic.Name = "colPersonNumerUonic";
            this.colPersonNumerUonic.Visible = true;
            this.colPersonNumerUonic.VisibleIndex = 1;
            this.colPersonNumerUonic.Width = 76;
            // 
            // coltext1
            // 
            this.coltext1.AppearanceCell.Options.UseTextOptions = true;
            this.coltext1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext1.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext1.Caption = "نص1";
            this.coltext1.FieldName = "text1";
            this.coltext1.Name = "coltext1";
            this.coltext1.Visible = true;
            this.coltext1.VisibleIndex = 2;
            // 
            // coltext2
            // 
            this.coltext2.AppearanceCell.Options.UseTextOptions = true;
            this.coltext2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext2.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext2.Caption = "نص2";
            this.coltext2.FieldName = "text2";
            this.coltext2.Name = "coltext2";
            this.coltext2.Visible = true;
            this.coltext2.VisibleIndex = 3;
            // 
            // coltext3
            // 
            this.coltext3.AppearanceCell.Options.UseTextOptions = true;
            this.coltext3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext3.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext3.Caption = "نص3";
            this.coltext3.FieldName = "text3";
            this.coltext3.Name = "coltext3";
            this.coltext3.Visible = true;
            this.coltext3.VisibleIndex = 4;
            // 
            // coltext4
            // 
            this.coltext4.AppearanceCell.Options.UseTextOptions = true;
            this.coltext4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext4.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext4.Caption = "نص4";
            this.coltext4.FieldName = "text4";
            this.coltext4.Name = "coltext4";
            this.coltext4.Visible = true;
            this.coltext4.VisibleIndex = 5;
            // 
            // coltext5
            // 
            this.coltext5.AppearanceCell.Options.UseTextOptions = true;
            this.coltext5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext5.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext5.Caption = "نص5";
            this.coltext5.FieldName = "text5";
            this.coltext5.Name = "coltext5";
            this.coltext5.Visible = true;
            this.coltext5.VisibleIndex = 6;
            // 
            // coltext6
            // 
            this.coltext6.AppearanceCell.Options.UseTextOptions = true;
            this.coltext6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext6.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext6.Caption = "نص6";
            this.coltext6.FieldName = "text6";
            this.coltext6.Name = "coltext6";
            this.coltext6.Visible = true;
            this.coltext6.VisibleIndex = 7;
            // 
            // coltext7
            // 
            this.coltext7.AppearanceCell.Options.UseTextOptions = true;
            this.coltext7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext7.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext7.Caption = "نص7";
            this.coltext7.FieldName = "text7";
            this.coltext7.Name = "coltext7";
            this.coltext7.Visible = true;
            this.coltext7.VisibleIndex = 8;
            // 
            // coltext8
            // 
            this.coltext8.AppearanceCell.Options.UseTextOptions = true;
            this.coltext8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext8.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext8.Caption = "نص8";
            this.coltext8.FieldName = "text8";
            this.coltext8.Name = "coltext8";
            this.coltext8.Visible = true;
            this.coltext8.VisibleIndex = 9;
            // 
            // coltext9
            // 
            this.coltext9.AppearanceCell.Options.UseTextOptions = true;
            this.coltext9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext9.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext9.Caption = "نص9";
            this.coltext9.FieldName = "text9";
            this.coltext9.Name = "coltext9";
            this.coltext9.Visible = true;
            this.coltext9.VisibleIndex = 10;
            // 
            // coltext10
            // 
            this.coltext10.AppearanceCell.Options.UseTextOptions = true;
            this.coltext10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext10.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext10.Caption = "نص10";
            this.coltext10.FieldName = "text10";
            this.coltext10.Name = "coltext10";
            this.coltext10.Visible = true;
            this.coltext10.VisibleIndex = 11;
            // 
            // coltext11
            // 
            this.coltext11.AppearanceCell.Options.UseTextOptions = true;
            this.coltext11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext11.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext11.Caption = "نص11";
            this.coltext11.FieldName = "text11";
            this.coltext11.Name = "coltext11";
            this.coltext11.Visible = true;
            this.coltext11.VisibleIndex = 12;
            // 
            // coltext12
            // 
            this.coltext12.AppearanceCell.Options.UseTextOptions = true;
            this.coltext12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext12.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext12.Caption = "نص12";
            this.coltext12.FieldName = "text12";
            this.coltext12.Name = "coltext12";
            this.coltext12.Visible = true;
            this.coltext12.VisibleIndex = 13;
            // 
            // colimgpath
            // 
            this.colimgpath.AppearanceCell.Options.UseTextOptions = true;
            this.colimgpath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimgpath.AppearanceHeader.Options.UseTextOptions = true;
            this.colimgpath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimgpath.Caption = "مسار الصورة";
            this.colimgpath.FieldName = "imgpath";
            this.colimgpath.Name = "colimgpath";
            this.colimgpath.Visible = true;
            this.colimgpath.VisibleIndex = 15;
            this.colimgpath.Width = 77;
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
            // XPSCSData
            // 
            this.XPSCSData.AllowEdit = true;
            this.XPSCSData.AllowNew = true;
            this.XPSCSData.AllowRemove = true;
            this.XPSCSData.DeleteObjectOnRemove = true;
            this.XPSCSData.ObjectType = typeof(ECard.Datasource.dsData.TBLALLDataDataTable);
            this.XPSCSData.Session = this.sessionData;
            // 
            // sessionData
            // 
            this.sessionData.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionData.TrackPropertiesModifications = false;
            this.sessionData.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionData_BeforeCommitTransaction);
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
            // cDGehaTableAdapter
            // 
            this.cDGehaTableAdapter.ClearBeforeFill = true;
            // 
            // coltext13
            // 
            this.coltext13.AppearanceCell.Options.UseTextOptions = true;
            this.coltext13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext13.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext13.Caption = "نص13";
            this.coltext13.FieldName = "text13";
            this.coltext13.Name = "coltext13";
            this.coltext13.Visible = true;
            this.coltext13.VisibleIndex = 14;
            // 
            // TBLALLDataUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TBLALLDataUC";
            this.Size = new System.Drawing.Size(787, 427);
            this.Load += new System.EventHandler(this.CDGehaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditGehaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDGehaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditallimgpath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).EndInit();
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
        private DevExpress.XtraBars.BarEditItem mBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditallimgpath;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Datasource.dsData dsData;
        private Datasource.dsDataTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSData;
        private DevExpress.Xpo.Session sessionData;
        private DevExpress.XtraSplashScreen.SplashScreenManager SSM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditGehaId;
        private System.Windows.Forms.BindingSource cDGehaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colGeha;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaDes;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonNumerUonic;
        private DevExpress.XtraGrid.Columns.GridColumn coltext1;
        private DevExpress.XtraGrid.Columns.GridColumn coltext2;
        private DevExpress.XtraGrid.Columns.GridColumn coltext3;
        private DevExpress.XtraGrid.Columns.GridColumn coltext4;
        private DevExpress.XtraGrid.Columns.GridColumn coltext5;
        private DevExpress.XtraGrid.Columns.GridColumn coltext6;
        private DevExpress.XtraGrid.Columns.GridColumn coltext7;
        private DevExpress.XtraGrid.Columns.GridColumn coltext8;
        private DevExpress.XtraGrid.Columns.GridColumn coltext9;
        private DevExpress.XtraGrid.Columns.GridColumn coltext10;
        private DevExpress.XtraGrid.Columns.GridColumn colimgpath;
        private Datasource.dsDataTableAdapters.CDGehaTableAdapter cDGehaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coltext11;
        private DevExpress.XtraGrid.Columns.GridColumn coltext12;
        private DevExpress.XtraGrid.Columns.GridColumn coltext13;


    }
}
