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
    public partial class FCatCalidad : DevExpress.XtraEditors.XtraForm
    {
        ControlPatioEntities dbcontext;
        bool nuevo;

        public FCatCalidad()
        {
            InitializeComponent();
        }

        public void Limpia()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            nuevo = true;
        }

        public void Habilita(bool opc)
        {
            txtNombre.Enabled = opc;
            txtDescripcion.Enabled = opc;

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
                MsgError.SetError(txtNombre, "Debe capturar el nombre del buque");
                valido = false;
            }
            return valido;
        }

        private void FCatCalidad_Load(object sender, EventArgs e)
        {
            dbcontext = new ControlPatioEntities();
            Limpia();
            calidadBindingSource.DataSource = dbcontext.Calidad.ToList();
            bnRegistros.DataSource = calidadBindingSource;
            Habilita(false);
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            calidadBindingSource.DataSource = typeof(Calidad);
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
            FCatCalidad_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (nuevo)
                {
                    Calidad calidad = new Calidad()
                    {
                        CalidadClave = txtNombre.Text,
                        CalidadDescripcion = txtDescripcion.Text
                    };
                    dbcontext.Calidad.Add(calidad);
                    dbcontext.SaveChanges();
                    calidadBindingSource.DataSource = dbcontext.Calidad.ToList();
                    calidadBindingSource.MoveLast();
                }
                else
                {
                    int IdCalidad = Convert.ToInt32(txtClave.Text);
                    var ag = from a in dbcontext.Calidad where a.CalidadId == IdCalidad select a;
                    if (ag.Count() > 0)
                    {
                        ag.FirstOrDefault().CalidadClave = txtNombre.Text;
                        ag.FirstOrDefault().CalidadDescripcion = txtDescripcion.Text;
                        dbcontext.SaveChanges();
                        calidadBindingSource.DataSource = dbcontext.Calidad.ToList();
                    }
                }
                Habilita(false);
            }
        }
    }
}