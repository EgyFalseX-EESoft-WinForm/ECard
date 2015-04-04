using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ECard.Forms.XRep
{
    public partial class XRepCard1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepCard1(System.Data.DataTable TBL)
        {
            InitializeComponent();

            //this.Watermark.Image = ((System.Drawing.Image)(resources.GetObject("XRepCard1.Watermark.Image")));
            if (System.IO.File.Exists(Program.CardBackgroundPath))
            {
                this.Watermark.Image = Image.FromFile(Program.CardBackgroundPath);
            }
            //for (int i = 0; i < TBL.Rows.Count; i++)
            //{
            //    dsQry1.XRepCard1.Rows.Add(TBL.Rows[i].ItemArray);
            //}
            
            DataMember = string.Empty;
            DataSource = TBL;
        }
    }
}
