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
        private void btnPrint_Click(object sender, EventArgs e)
        {
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
            //Saving Printing Order
            //if (!Classes.Managers.DataManager.SavePrintOrder(PrintTbl))
            //{
            //    MsgDlg.Show("لم يتم الحفظ. لن نتمكن من الطباعة", MsgDlg.MessageType.Error);
            //    return;
            //}
            //Show Print Form
            ECard.Forms.XRep.XRepCard1 FrmRep = new ECard.Forms.XRep.XRepCard1(PrintTbl);
            ECard.Classes.Misc.ShowPrintPreview(FrmRep);
        }
        private void lueTBLALLData_EditValueChanged(object sender, EventArgs e)
        {
            xRepCard1TableAdapter.Fill(dsQry.XRepCard1, Convert.ToInt32(lueTBLALLData.EditValue));
        }
        
    }
}
