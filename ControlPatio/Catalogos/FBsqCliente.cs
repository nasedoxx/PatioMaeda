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
    public partial class FBsqCliente : DevExpress.XtraEditors.XtraForm
    {
        public static string ClaveCte;
        public static string NombreCte;

        public FBsqCliente()
        {
            InitializeComponent();
        }

        private void FBsqCliente_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                clienteBindingSource.DataSource = bd.Cliente.ToList();
            }
        }

        private void FBsqCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gvCliente.FocusedRowHandle < 0)
            {
                ClaveCte = string.Empty;
                NombreCte = string.Empty;
            }
            else
            {
                ClaveCte = gvCliente.GetRowCellValue(gvCliente.FocusedRowHandle, "ClienteId").ToString();
                NombreCte = gvCliente.GetRowCellValue(gvCliente.FocusedRowHandle, "ClienteNombre").ToString();
            }
        }

        private void FBsqCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                Close();
        }

        private void gcCliente_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}