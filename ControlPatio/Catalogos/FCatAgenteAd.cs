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
    public partial class FCatAgenteAd : DevExpress.XtraEditors.XtraForm
    {
        ControlPatioEntities dbcontext;
        bool nuevo;
        public FCatAgenteAd()
        {
            InitializeComponent();
        }

        public void Limpia()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPatente.Text = string.Empty;
            nuevo = true;
        }

        public void Habilita(bool opc)
        {
            txtNombre.Enabled = opc;
            txtPatente.Enabled = opc;

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
                MsgError.SetError(txtNombre, "Debe capturar el nombre del Agente Aduanal");
                valido = false;
            }

            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                MsgError.SetError(txtPatente, "Debe capturar la patente del A.A.");
                valido = false;
            }
            return valido;
        }

        private void FCatAgenteAd_Load(object sender, EventArgs e)
        {
            dbcontext = new ControlPatioEntities();
            Limpia();
            agenteAduanalBindingSource.DataSource = dbcontext.AgenteAduanal.ToList();
            bnRegistros.DataSource = agenteAduanalBindingSource;
            Habilita(false);
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            agenteAduanalBindingSource.DataSource = typeof(AgenteAduanal);
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
            FCatAgenteAd_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (nuevo)
                {
                    AgenteAduanal ag = new AgenteAduanal()
                    {
                        AgenteNombre = txtNombre.Text,
                        AgentePatente = txtPatente.Text
                    };
                    dbcontext.AgenteAduanal.Add(ag);
                    dbcontext.SaveChanges();
                    agenteAduanalBindingSource.DataSource = dbcontext.AgenteAduanal.ToList();
                    agenteAduanalBindingSource.MoveLast();
                }
                else
                {
                    int IdAg = Convert.ToInt32(txtClave.Text);
                    var ag = from a in dbcontext.AgenteAduanal where a.AgenteId == IdAg select a;
                    if (ag.Count() > 0)
                    {
                        ag.FirstOrDefault().AgenteNombre = txtNombre.Text;
                        ag.FirstOrDefault().AgentePatente = txtPatente.Text;
                        dbcontext.SaveChanges();
                        agenteAduanalBindingSource.DataSource = dbcontext.AgenteAduanal.ToList();
                    }
                }
                Habilita(false);
            }
        }
    }
}