using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ECard.Forms.Print
{
    public partial class PrintCard1UC : DevExpress.XtraEditors.XtraUserControl
    {
        public PrintCard1UC()
        {
            InitializeComponent();
            lueXRepCard1TableAdapter.Fill(dsQry.lueXRepCard1);
        }
        
        private void lueTBLALLData_EditValueChanged(object sender, EventArgs e)
        {
            xRepCard1TableAdapter.Fill(dsQry.XRepCard1, Convert.ToInt32(lueTBLALLData.EditValue));
        }
        private void lueCardLayout_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                return;
            if (FXFW.SqlDB.IsNullOrEmpty(lueTBLALLData.EditValue))
            {
                MsgDlg.Show("يجب اختيار من القائمة", MsgDlg.MessageType.Error);
                return;
            }
            Datasource.dsQry.XRepCard1DataTable PrintTbl = new Datasource.dsQry.XRepCard1DataTable();
            for (int i = 0; i < gridViewMain.SelectedRowsCount; i++)
            {
                PrintTbl.Rows.Add(gridViewMain.GetDataRow(gridViewMain.GetSelectedRows()[i]).ItemArray);
            }
            switch (lueCardLayout.SelectedIndex)
            {
                case 0: //Card 1
                    ECard.Forms.XRep.XRepCard1 FrmRep1 = new ECard.Forms.XRep.XRepCard1(PrintTbl);
                    ECard.Classes.Misc.ShowPrintPreview(FrmRep1, true);
                    break;
                case 1: //Card 2
                    ECard.Forms.XRep.XRepCard2 FrmRep2 = new ECard.Forms.XRep.XRepCard2(PrintTbl);
                    ECard.Classes.Misc.ShowPrintPreview(FrmRep2, true);
                    break;
                case 2: //Card 3
                    ECard.Forms.XRep.XRepCard3 FrmRep3 = new ECard.Forms.XRep.XRepCard3(PrintTbl);
                    ECard.Classes.Misc.ShowPrintPreview(FrmRep3, true);
                    break;
                case 3: //Card 4
                    ECard.Forms.XRep.XRepCard4 FrmRep4 = new ECard.Forms.XRep.XRepCard4(PrintTbl);
                    ECard.Classes.Misc.ShowPrintPreview(FrmRep4, true);
                    break;
                default:
                    break;
            }
            //Saving Printing Order
            if (MsgDlg.Show("هل تريد حقظ الطباعة؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
            {
                if (!Classes.Managers.DataManager.SavePrintOrder(PrintTbl))
                {
                    MsgDlg.Show("لم يتم الحفظ", MsgDlg.MessageType.Error);
                    return;
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
    }
}
