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
    public partial class FCatTransportes : DevExpress.XtraEditors.XtraForm
    {
        ControlPatioEntities dbcontext;
        bool nuevo;

        public FCatTransportes()
        {
            InitializeComponent();
        }

        public void Limpia()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            nuevo = true;
        }

        public void Habilita(bool opc)
        {
            txtNombre.Enabled = opc;

            btnNuevo.Enabled = !opc;
            btnImprimir.Enabled = !opc;
            btnGuardar.Enabled = opc;
            btnDeshacer.Enabled = opc;
            btnEditar.Enabled = !opc;
            btnEliminar.Enabled = !opc;
            btnBuscar.Enabled = !opc;
        }

        public bool Validacampos()
        {
            bool valido = true;
            MsgError.ClearErrors();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MsgError.SetError(txtNombre, "Debe capturar el nombre del transporte");
                valido = false;
            }
            return valido;
        }

        private void FCatTransportes_Load(object sender, EventArgs e)
        {
            dbcontext = new ControlPatioEntities();
            Limpia();
            transporteBindingSource.DataSource = dbcontext.Transporte.ToList();
            bnRegistros.DataSource = transporteBindingSource;
            Habilita(false);
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            transporteBindingSource.DataSource = typeof(Transporte);
            Limpia();
            txtNombre.Focus();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClave.Text))
            {
                nuevo = false;
                Habilita(true);
                txtNombre.Focus();
            }
        }

        private void btnDeshacer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCatTransportes_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (nuevo)
                {
                    Transporte tra = new Transporte()
                    {
                        TransporteNombre = txtNombre.Text
                    };
                    dbcontext.Transporte.Add(tra);
                    dbcontext.SaveChanges();
                    transporteBindingSource.DataSource = dbcontext.Transporte.ToList();
                    transporteBindingSource.MoveLast();
                }
                else
                {
                    int Idtra = Convert.ToInt32(txtClave.Text);
                    var tra = from t in dbcontext.Transporte where t.TransporteId == Idtra select t;
                    if (tra.Count() > 0)
                    {
                        tra.FirstOrDefault().TransporteNombre = txtNombre.Text;
                        dbcontext.SaveChanges();
                        transporteBindingSource.DataSource = dbcontext.Transporte.ToList();
                    }
                }
                Habilita(false);
            }
        }
    }
}