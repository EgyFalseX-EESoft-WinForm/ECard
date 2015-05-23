using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ECard.Forms.XRep
{
    public partial class XRepCard1 : DevExpress.XtraReports.UI.XtraReport
    {
        ECard.Datasource.dsQryTableAdapters.TblControlTableAdapter adpCtr = new Datasource.dsQryTableAdapters.TblControlTableAdapter();
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

            //Colors
            string colortext = TBL.Rows[0]["TextColor"].ToString();
            if (colortext != string.Empty)
            {
                try
                {
                    string[] RGB = colortext.Split('.');
                    Color clr = Color.FromArgb(Convert.ToInt32(RGB[0]), Convert.ToInt32(RGB[1]), Convert.ToInt32(RGB[2]));
                    lbl1.ForeColor = clr; lbl2.ForeColor = clr; lbl3.ForeColor = clr; lbl4.ForeColor = clr;
                    lbl7.BackColor = clr; lbl8.BackColor = clr; lbl9.BackColor = clr; lbl10.BackColor = clr; lbl11.BackColor = clr; lbl12.BackColor = clr;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Cant Set Color !!!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            
            //Load Control Visable State
            adpCtr.FillByGehaId(dsQry1.TblControl, Convert.ToInt32(TBL.Rows[0]["GehaId"]));
            if (dsQry1.TblControl.Rows.Count != 0)
            {
                Datasource.dsQry.TblControlRow row = (Datasource.dsQry.TblControlRow)dsQry1.TblControl.Rows[0];
                lbl7.Visible = row.ctr1; txt7.Visible = row.ctr1;
                lbl8.Visible = row.ctr2; txt8.Visible = row.ctr2;
                lbl9.Visible = row.ctr3; txt9.Visible = row.ctr3;
                lbl10.Visible = row.ctr4; txt10.Visible = row.ctr4;
                lbl11.Visible = row.ctr5; txt11.Visible = row.ctr5;
                lbl12.Visible = row.ctr6; txt12.Visible = row.ctr6;
            }
             
            
            
        }
    }
}
