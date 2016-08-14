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
    public partial class FBsqEntradas : DevExpress.XtraEditors.XtraForm
    {
        public static string contenedor;
        public FBsqEntradas()
        {
            InitializeComponent();
        }

        private void FBsqEntradas_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                var qryEntrada = from ent in bd.EntradaSalida
                                 where ent.EntSalFolioEirSalida == null
                                 select new
                                 {
                                     Contenedor = ent.EntSalContenedor,
                                     Fecha = ent.EntSalFechaIngreso,
                                     Tam = ent.TipoContenedor.TamDescripcion,
                                     EirEntrada = ent.EntSalFolioEirEntrada,
                                     EirSalida = ent.EntSalFolioEirSalida
                                 };
                gcEntradas.DataSource = qryEntrada.ToList();
            }
        }

        private void FBsqEntradas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gvEntradas.FocusedRowHandle < 0)
                contenedor = string.Empty;
            else
                contenedor = gvEntradas.GetRowCellValue(gvEntradas.FocusedRowHandle, "Contenedor").ToString();
        }

        private void FBsqEntradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                Close();
        }

        private void gcEntradas_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}