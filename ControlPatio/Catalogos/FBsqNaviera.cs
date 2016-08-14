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
    public partial class FBsqNaviera : DevExpress.XtraEditors.XtraForm
    {
        public static string cveNaviera;
        public static string NomNaviera;

        public FBsqNaviera()
        {
            InitializeComponent();
        }

        private void FBsqNaviera_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                navieraBindingSource.DataSource = bd.Naviera.ToList();
            }
        }

        private void FBsqNaviera_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gvBuque.FocusedRowHandle < 0)
            {
                cveNaviera = string.Empty;
                NomNaviera = string.Empty;
            }
            else
            {
                cveNaviera = gvBuque.GetRowCellValue(gvBuque.FocusedRowHandle, "NavieraId").ToString();
                NomNaviera = gvBuque.GetRowCellValue(gvBuque.FocusedRowHandle, "NavieraNombre").ToString();
            }
        }

        private void FBsqNaviera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                Close();
        }

        private void gcBuque_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}