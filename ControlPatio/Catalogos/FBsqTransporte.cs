using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ControlPatio.Catalogos
{
    public partial class FBsqTransporte : DevExpress.XtraEditors.XtraForm
    {
        public static string ClaveTransporte;
        public static string NombreTransporte;

        public FBsqTransporte()
        {
            InitializeComponent();
        }

        private void FBsqTransporte_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                transporteBindingSource.DataSource = bd.Transporte.ToList();
            }
        }

        private void FBsqTransporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gvTransporte.FocusedRowHandle < 0)
            {
                ClaveTransporte = string.Empty;
                NombreTransporte = string.Empty;
            }
            else
            {
                ClaveTransporte = gvTransporte.GetRowCellValue(gvTransporte.FocusedRowHandle, "TransporteId").ToString();
                NombreTransporte = gvTransporte.GetRowCellValue(gvTransporte.FocusedRowHandle, "TransporteNombre").ToString();
            }
        }

        private void FBsqTransporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                Close();
        }

        private void gcTransporte_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}