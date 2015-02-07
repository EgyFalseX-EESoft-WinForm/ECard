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

namespace ECard.Forms.Main
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowForm(UserControl uc, string Caption)
        {
            uc.Dock = DockStyle.Fill;
            Form Frm = new Form() { MdiParent = this, Text = Caption, WindowState = FormWindowState.Maximized, ShowIcon = false};
            Frm.Controls.Add(uc);
            Frm.Show();
        }
        private void mbCDGeha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ECard.Forms.Code.CDGehaUC(), "اكواد الجهات");
        }
        private void mbTBLLabel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ECard.Forms.Code.TBLLabelUC(), "حقول الكرت");
        }

        
    }
}
