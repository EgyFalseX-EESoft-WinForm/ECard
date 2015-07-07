namespace ECard.Forms.XRep
{
    partial class XRepCard2
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbl1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbl2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbl3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbl4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbl5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.dsQry1 = new ECard.Datasource.dsQry();
            this.xRepCard1TableAdapter = new ECard.Datasource.dsQryTableAdapters.XRepCard1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 546F;
            this.Detail.KeepTogether = true;
            this.Detail.MultiColumn.ColumnCount = 2;
            this.Detail.MultiColumn.ColumnSpacing = 30F;
            this.Detail.MultiColumn.ColumnWidth = 890F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("ImageUrl", null, "XRepCard1.imgpath")});
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(80.9445F, 185.8958F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(150F, 210.0175F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 254F;
            this.xrTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(266.1737F, 237.2844F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5});
            this.xrTable1.SizeF = new System.Drawing.SizeF(593.7709F, 150F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseForeColor = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.lbl1});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanGrow = false;
            this.xrTableCell2.CanShrink = true;
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text1lbl")});
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 0.72087537016330439D;
            // 
            // lbl1
            // 
            this.lbl1.CanGrow = false;
            this.lbl1.CanShrink = true;
            this.lbl1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text1")});
            this.lbl1.Dpi = 254F;
            this.lbl1.Name = "lbl1";
            this.lbl1.StylePriority.UseTextAlignment = false;
            this.lbl1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbl1.Weight = 2.1606031128089866D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.lbl2});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.CanShrink = true;
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text2lbl")});
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 0.72087536743217662D;
            // 
            // lbl2
            // 
            this.lbl2.CanGrow = false;
            this.lbl2.CanShrink = true;
            this.lbl2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text2")});
            this.lbl2.Dpi = 254F;
            this.lbl2.Name = "lbl2";
            this.lbl2.StylePriority.UseTextAlignment = false;
            this.lbl2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbl2.Weight = 2.1606031155401162D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.lbl3});
            this.xrTableRow3.Dpi = 254F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.CanShrink = true;
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text3lbl")});
            this.xrTableCell8.Dpi = 254F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell8.Weight = 0.72087506850684868D;
            // 
            // lbl3
            // 
            this.lbl3.CanGrow = false;
            this.lbl3.CanShrink = true;
            this.lbl3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text3")});
            this.lbl3.Dpi = 254F;
            this.lbl3.Name = "lbl3";
            this.lbl3.StylePriority.UseTextAlignment = false;
            this.lbl3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbl3.Weight = 2.1606034144654367D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell3,
            this.xrTableCell1,
            this.lbl4});
            this.xrTableRow4.Dpi = 254F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.CanShrink = true;
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text4lbl")});
            this.xrTableCell11.Dpi = 254F;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 0.72087558684669961D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text4", "{0:d/M/yyyy}")});
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 0.72727730329396079D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text5lbl")});
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.70801014478931168D;
            // 
            // lbl4
            // 
            this.lbl4.CanGrow = false;
            this.lbl4.CanShrink = true;
            this.lbl4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text5", "{0:d/M/yyyy}")});
            this.lbl4.Dpi = 254F;
            this.lbl4.Name = "lbl4";
            this.lbl4.StylePriority.UseTextAlignment = false;
            this.lbl4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbl4.Weight = 0.725315448042317D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.lbl5});
            this.xrTableRow5.Dpi = 254F;
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text6lbl")});
            this.xrTableCell6.Dpi = 254F;
            this.xrTableCell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.xrTableCell6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(95)))), ((int)(((byte)(71)))));
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseForeColor = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell6.Weight = 0.72087555823400618D;
            // 
            // lbl5
            // 
            this.lbl5.CanGrow = false;
            this.lbl5.CanShrink = true;
            this.lbl5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "XRepCard1.text6")});
            this.lbl5.Dpi = 254F;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(95)))), ((int)(((byte)(71)))));
            this.lbl5.Name = "lbl5";
            this.lbl5.StylePriority.UseFont = false;
            this.lbl5.StylePriority.UseForeColor = false;
            this.lbl5.StylePriority.UseTextAlignment = false;
            this.lbl5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbl5.Weight = 2.160602924738285D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 60F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 60F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dsQry1
            // 
            this.dsQry1.DataSetName = "dsQry";
            this.dsQry1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xRepCard1TableAdapter
            // 
            this.xRepCard1TableAdapter.ClearBeforeFill = true;
            // 
            // XRepCard2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataMember = "XRepCard1";
            this.DataSource = this.dsQry1;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(125, 150, 60, 60);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.Version = "14.2";
            this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private Datasource.dsQry dsQry1;
        private Datasource.dsQryTableAdapters.XRepCard1TableAdapter xRepCard1TableAdapter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell lbl1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell lbl2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell lbl3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell lbl4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell lbl5;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    }
}
