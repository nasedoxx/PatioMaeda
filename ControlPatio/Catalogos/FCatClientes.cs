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
    public partial class FCatClientes : DevExpress.XtraEditors.XtraForm
    {
        ControlPatioEntities dbcontext;
        bool nuevo;

        public FCatClientes()
        {
            InitializeComponent();
        }

        public void Limpia()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRFC.Text = string.Empty;
            nuevo = true;
        }

        public void Habilita(bool opc)
        {
            txtNombre.Enabled = opc;
            txtRFC.Enabled = opc;

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
                MsgError.SetError(txtNombre, "Debe capturar el nombre del cliente");
                valido = false;
            }
            return valido;
        }

        private void FCatClientes_Load(object sender, EventArgs e)
        {
            dbcontext = new ControlPatioEntities();
            Limpia();
            clienteBindingSource.DataSource = dbcontext.Cliente.ToList();
            bnRegistros.DataSource = clienteBindingSource;
            Habilita(false);
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            clienteBindingSource.DataSource = typeof(Cliente);
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
            FCatClientes_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (nuevo)
                {
                    Cliente cte = new Cliente()
                    {
                        ClienteNombre = txtNombre.Text,
                        ClienteRFC = txtRFC.Text
                    };
                    dbcontext.Cliente.Add(cte);
                    dbcontext.SaveChanges();
                    clienteBindingSource.DataSource = dbcontext.Cliente.ToList();
                    clienteBindingSource.MoveLast();
                }
                else
                {
                    int IdCte = Convert.ToInt32(txtClave.Text);
                    var cte = from c in dbcontext.Cliente where c.ClienteId == IdCte select c;
                    if (cte.Count() > 0)
                    {
                        cte.FirstOrDefault().ClienteNombre = txtNombre.Text;
                        cte.FirstOrDefault().ClienteRFC = txtRFC.Text;
                        dbcontext.SaveChanges();
                        clienteBindingSource.DataSource = dbcontext.Cliente.ToList();
                    }
                }
                Habilita(false);
            }
        }
    }
}