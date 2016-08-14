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
    public partial class FCatBuques : DevExpress.XtraEditors.XtraForm
    {
        ControlPatioEntities dbcontext;
        bool nuevo;
        public FCatBuques()
        {
            InitializeComponent();
        }

        public void Limpia()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNaviera.Text = string.Empty;
            txtNavieraId.Text = string.Empty;
            nuevo = true;
        }

        public void Habilita(bool opc)
        {
            txtNombre.Enabled = opc;
            txtNaviera.Enabled = opc;

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

            if (string.IsNullOrEmpty(txtNavieraId.Text))
            {
                MsgError.SetError(txtNaviera, "Debe capturar la naviera");
                valido = false;
            }
            return valido;
        }

        private void FCatBuques_Load(object sender, EventArgs e)
        {
            txtNavieraId.Visible = false;
            dbcontext = new ControlPatioEntities();
            Limpia();
            buqueBindingSource.DataSource = dbcontext.Buque.ToList();
            bnRegistros.DataSource = buqueBindingSource;
            Habilita(false);
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            buqueBindingSource.DataSource = typeof(Buque);
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
            FCatBuques_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (nuevo)
                {
                    Buque buque = new Buque()
                    {
                        BuqueNombre = txtNombre.Text,
                        BuqueNavieraId = Convert.ToInt32(txtNavieraId.Text)
                    };
                    dbcontext.Buque.Add(buque);
                    dbcontext.SaveChanges();
                    buqueBindingSource.DataSource = dbcontext.Buque.ToList();
                    buqueBindingSource.MoveLast();
                }
                else
                {
                    int IdBuque = Convert.ToInt32(txtClave.Text);
                    var ag = from a in dbcontext.Buque where a.BuqueId == IdBuque select a;
                    if (ag.Count() > 0)
                    {
                        ag.FirstOrDefault().BuqueNombre = txtNombre.Text;
                        ag.FirstOrDefault().BuqueNavieraId = Convert.ToInt32(txtNavieraId.Text);
                        dbcontext.SaveChanges();
                        buqueBindingSource.DataSource = dbcontext.Buque.ToList();
                    }
                }
                Habilita(false);
            }
        }

        private void txtNaviera_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqNaviera frmNaviera = new FBsqNaviera();
            frmNaviera.ShowDialog();

            txtNavieraId.Text = FBsqNaviera.cveNaviera;
            txtNaviera.Text = FBsqNaviera.NomNaviera;
        }

        private void txtNaviera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtNaviera_ButtonClick(sender, null);
        }
    }
}