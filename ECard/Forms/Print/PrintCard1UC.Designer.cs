namespace ECard.Forms.Print
{
    partial class PrintCard1UC
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
            this.dsData = new ECard.Datasource.dsData();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.xRepCard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new ECard.Datasource.dsQry();
            this.xRepCard1TableAdapter = new ECard.Datasource.dsQryTableAdapters.XRepCard1TableAdapter();
            this.lueXRepCard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueXRepCard1TableAdapter = new ECard.Datasource.dsQryTableAdapters.lueXRepCard1TableAdapter();
            this.lueTBLALLData = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.xRepCard1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltext1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltext5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepCard1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueXRepCard1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTBLALLData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepCard1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(474, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "الجهة";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::ECard.Properties.Resources.print_16x16;
            this.btnPrint.Location = new System.Drawing.Point(585, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "الطباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // xRepCard1BindingSource
            // 
            this.xRepCard1BindingSource.DataMember = "XRepCard1";
            this.xRepCard1BindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xRepCard1TableAdapter
            // 
            this.xRepCard1TableAdapter.ClearBeforeFill = true;
            // 
            // lueXRepCard1BindingSource
            // 
            this.lueXRepCard1BindingSource.DataMember = "lueXRepCard1";
            this.lueXRepCard1BindingSource.DataSource = this.dsQry;
            // 
            // lueXRepCard1TableAdapter
            // 
            this.lueXRepCard1TableAdapter.ClearBeforeFill = true;
            // 
            // lueTBLALLData
            // 
            this.lueTBLALLData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lueTBLALLData.Location = new System.Drawing.Point(222, 24);
            this.lueTBLALLData.Name = "lueTBLALLData";
            this.lueTBLALLData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTBLALLData.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Geha", "الاسم", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.lueTBLALLData.Properties.DataSource = this.lueXRepCard1BindingSource;
            this.lueTBLALLData.Properties.DisplayMember = "Geha";
            this.lueTBLALLData.Properties.NullText = "";
            this.lueTBLALLData.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTBLALLData.Properties.ValueMember = "GehaId";
            this.lueTBLALLData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lueTBLALLData.Size = new System.Drawing.Size(238, 20);
            this.lueTBLALLData.TabIndex = 0;
            this.lueTBLALLData.EditValueChanged += new System.EventHandler(this.lueTBLALLData_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lueTBLALLData);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(720, 49);
            this.groupControl1.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMain);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 49);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(720, 306);
            this.groupControl2.TabIndex = 5;
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.xRepCard1BindingSource1;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(2, 21);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(716, 283);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // xRepCard1BindingSource1
            // 
            this.xRepCard1BindingSource1.DataMember = "XRepCard1";
            this.xRepCard1BindingSource1.DataSource = this.dsQry;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltext1,
            this.coltext2,
            this.coltext3,
            this.coltext4,
            this.coltext5});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // coltext1
            // 
            this.coltext1.AppearanceCell.Options.UseTextOptions = true;
            this.coltext1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext1.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext1.Caption = "نص 1";
            this.coltext1.FieldName = "text1";
            this.coltext1.Name = "coltext1";
            this.coltext1.Visible = true;
            this.coltext1.VisibleIndex = 1;
            // 
            // coltext2
            // 
            this.coltext2.AppearanceCell.Options.UseTextOptions = true;
            this.coltext2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext2.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext2.Caption = "نص 2";
            this.coltext2.FieldName = "text2";
            this.coltext2.Name = "coltext2";
            this.coltext2.Visible = true;
            this.coltext2.VisibleIndex = 2;
            // 
            // coltext3
            // 
            this.coltext3.AppearanceCell.Options.UseTextOptions = true;
            this.coltext3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext3.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext3.Caption = "نص 3";
            this.coltext3.FieldName = "text3";
            this.coltext3.Name = "coltext3";
            this.coltext3.Visible = true;
            this.coltext3.VisibleIndex = 3;
            // 
            // coltext4
            // 
            this.coltext4.AppearanceCell.Options.UseTextOptions = true;
            this.coltext4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext4.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext4.Caption = "نص 4";
            this.coltext4.FieldName = "text4";
            this.coltext4.Name = "coltext4";
            this.coltext4.Visible = true;
            this.coltext4.VisibleIndex = 4;
            // 
            // coltext5
            // 
            this.coltext5.AppearanceCell.Options.UseTextOptions = true;
            this.coltext5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext5.AppearanceHeader.Options.UseTextOptions = true;
            this.coltext5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltext5.Caption = "نص 5";
            this.coltext5.FieldName = "text5";
            this.coltext5.Name = "coltext5";
            this.coltext5.Visible = true;
            this.coltext5.VisibleIndex = 5;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnPrint);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 300);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(720, 55);
            this.groupControl3.TabIndex = 5;
            // 
            // PrintCard1UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "PrintCard1UC";
            this.Size = new System.Drawing.Size(720, 355);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepCard1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueXRepCard1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTBLALLData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepCard1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private Datasource.dsData dsData;
        private System.Windows.Forms.BindingSource xRepCard1BindingSource;
        private Datasource.dsQry dsQry;
        private Datasource.dsQryTableAdapters.XRepCard1TableAdapter xRepCard1TableAdapter;
        private System.Windows.Forms.BindingSource lueXRepCard1BindingSource;
        private Datasource.dsQryTableAdapters.lueXRepCard1TableAdapter lueXRepCard1TableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lueTBLALLData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn coltext1;
        private DevExpress.XtraGrid.Columns.GridColumn coltext2;
        private DevExpress.XtraGrid.Columns.GridColumn coltext3;
        private DevExpress.XtraGrid.Columns.GridColumn coltext4;
        private DevExpress.XtraGrid.Columns.GridColumn coltext5;
        private System.Windows.Forms.BindingSource xRepCard1BindingSource1;
    }
}
