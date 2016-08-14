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
    public partial class FBsqAgenteAduanal : DevExpress.XtraEditors.XtraForm
    {
        public static string ClaveAA;
        public static string NombreAA;
        public static string Patente;

        public FBsqAgenteAduanal()
        {
            InitializeComponent();
        }

        private void FBsqAgenteAduanal_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                agenteAduanalBindingSource.DataSource = bd.AgenteAduanal.ToList();
            }
        }

        private void FBsqAgenteAduanal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gvAA.FocusedRowHandle < 0)
            {
                ClaveAA = string.Empty;
                NombreAA = string.Empty;
                Patente = string.Empty;
            }
            else
            {
                ClaveAA = gvAA.GetRowCellValue(gvAA.FocusedRowHandle, "AgenteId").ToString();
                NombreAA = gvAA.GetRowCellValue(gvAA.FocusedRowHandle, "AgenteNombre").ToString();
                Patente = gvAA.GetRowCellValue(gvAA.FocusedRowHandle, "AgentePatente").ToString();
            }
        }

        private void FBsqAgenteAduanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                Close();
        }

        private void gcAA_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}