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
using ControlPatio.Catalogos;

namespace ControlPatio.Control
{
    public partial class FControlSalida : DevExpress.XtraEditors.XtraForm
    {
        ControlPatioEntities dbcontext;
        bool nuevo = true;

        public FControlSalida()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtFolioEntrada.Text = string.Empty;
            txtContenedor.Text = string.Empty;
            txtBL.Text = string.Empty;
            txtBuque.Text = string.Empty;
            txtNaviera.Text = string.Empty;
            cbCalidad.SelectedIndex = -1;
            cbTam.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            cbTManiobra.SelectedIndex = -1;
            dtFechaSalida.Text = string.Empty;
            txtTipoId.Text = string.Empty;
            txtManiobraId.Text = string.Empty;
            txtCalidadId.Text = string.Empty;
            txtBuqueId.Text = string.Empty;
            txtNavieraId.Text = string.Empty;
            txtClienteId.Text = string.Empty;
            txtTransporteId.Text = string.Empty;
            txtAA.Text = string.Empty;
            txtAAId.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtTransporte.Text = string.Empty;
            txtEco.Text = string.Empty;
            txtPlacas.Text = string.Empty;
            txtOperador.Text = string.Empty;
            memObservaciones.Text = string.Empty;
            nuevo = true;
        }

        private void Habilita(bool opc)
        {
            //txtContenedor.Enabled = opc;
            txtBL.Enabled = opc;
            txtBuque.Enabled = opc;
            cbCalidad.Enabled = opc;
            cbTam.Enabled = opc;
            cbTipo.Enabled = opc;
            cbTManiobra.Enabled = opc;
            dtFechaSalida.Enabled = opc;
            txtAA.Enabled = opc;
            txtAAId.Enabled = opc;
            txtCliente.Enabled = opc;
            txtTransporte.Enabled = opc;
            txtEco.Enabled = opc;
            txtPlacas.Enabled = opc;
            txtOperador.Enabled = opc;
            memObservaciones.Enabled = opc;

            btnNuevo.Enabled = !opc;
            btnImprimir.Enabled = !opc;
            btnGuardar.Enabled = opc;
            btnDeshacer.Enabled = opc;
            btnEditar.Enabled = !opc;
            btnEliminar.Enabled = !opc;
            btnBuscar.Enabled = !opc;
            bnRegistros.Enabled = !opc;
        }

        public bool Validacampos()
        {
            bool valido = true;
            MsgError.ClearErrors();

            if (string.IsNullOrEmpty(dtFechaSalida.Text))
            {
                MsgError.SetError(dtFechaSalida, "Debe capturar la fecha de entrada");
                valido = false;
            }

            if (string.IsNullOrEmpty(cbCalidad.Text))
            {
                MsgError.SetError(cbCalidad, "Debe seleccionar la calidad");
                valido = false;
            }

            if (string.IsNullOrEmpty(cbTam.Text))
            {
                MsgError.SetError(cbTam, "Debe seleccionar el tamaño del contenedor");
                valido = false;
            }

            if (string.IsNullOrEmpty(cbTipo.Text))
            {
                MsgError.SetError(cbTipo, "Debe seleccionar el tipo de contenedor");
                valido = false;
            }

            if (string.IsNullOrEmpty(cbTManiobra.Text))
            {
                MsgError.SetError(cbTManiobra, "Debe seleccionar el tipo de maniobra");
                valido = false;
            }

            if (string.IsNullOrEmpty(txtBuqueId.Text))
            {
                MsgError.SetError(txtBuque, "Debe capturar el buque");
                valido = false;
            }

            if (string.IsNullOrEmpty(txtContenedor.Text))
            {
                MsgError.SetError(txtContenedor, "Debe capturar el contenedor");
                valido = false;
            }

            return valido;
        }

        private void FControlSalida_Load(object sender, EventArgs e)
        {
            dbcontext = new ControlPatioEntities();

            txtTipoId.Visible = false;
            txtManiobraId.Visible = false;
            txtCalidadId.Visible = false;
            txtBuqueId.Visible = false;
            txtNavieraId.Visible = false;
            txtClienteId.Visible = false;
            txtTransporteId.Visible = false;
            txtAAId.Visible = false;

            cbTipo.Properties.Items.Clear();
            cbCalidad.Properties.Items.Clear();
            cbTam.Properties.Items.Clear();
            Limpiar();

            var qryTipo = dbcontext.TipoContenedor.GroupBy(t => t.TamTipo).Select(lst => new { Tamtipo = lst.Key });
            foreach (var r in qryTipo)
                cbTipo.Properties.Items.Add(r.Tamtipo);

            var qryCalidad = dbcontext.Calidad.ToList();
            foreach (var r in qryCalidad)
                cbCalidad.Properties.Items.Add(r.CalidadClave);

            var qryTam = dbcontext.TipoContenedor.GroupBy(t => t.TamDimension).Select(lst => new { Dimension = lst.Key });
            foreach (var item in qryTam)
                cbTam.Properties.Items.Add(item.Dimension);

            var qryEntradas = from ent in dbcontext.EntradaSalida where ent.EntSalFolioEirEntrada != null select ent;
            entradaSalidaBindingSource.DataSource = qryEntradas.ToList();
            bnRegistros.DataSource = entradaSalidaBindingSource;
            Habilita(false);
        }

        private void txtContenedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            /*FBsqEntradas frmEntradas = new FBsqEntradas();
            frmEntradas.ShowDialog();*/
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            entradaSalidaBindingSource.DataSource = typeof(EntradaSalida);
            Limpiar();
            dtFechaSalida.Focus();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cont, tam, folio;
            int dim, tipo;

            folio = txtFolioEntrada.Text;
            cont = txtContenedor.Text;
            tam = txtTipoId.Text;
            dim = cbTam.SelectedIndex;
            tipo = cbTipo.SelectedIndex;

            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            nuevo = false;

            if (dtFechaSalida.Text == "")
                entradaSalidaBindingSource.DataSource = typeof(EntradaSalida);

            txtContenedor.Text = cont;
            txtTipoId.Text = tam;
            cbTam.SelectedIndex = dim;
            cbTipo.SelectedIndex = tipo;
            txtFolioEntrada.Text = folio;

            dtFechaSalida.Focus();
        }

        private void btnDeshacer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar();
            FControlSalida_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (!nuevo)
                {
                    int IdEntrada = Convert.ToInt32(txtFolioEntrada.Text);
                    var qryUpdate = from ent in dbcontext.EntradaSalida where ent.EntSalId == IdEntrada select ent;
                    if (qryUpdate.Count() > 0)
                    {
                        qryUpdate.FirstOrDefault().EntSalFechaSalida = dtFechaSalida.DateTime;
                        qryUpdate.FirstOrDefault().EntSalTipoManSalida = Convert.ToByte(cbTManiobra.SelectedIndex);
                        qryUpdate.FirstOrDefault().EntSalTipoManDescSalida = cbTManiobra.Text;
                        qryUpdate.FirstOrDefault().EntSalContenedor = txtContenedor.Text;
                        qryUpdate.FirstOrDefault().EntSalTamId = Convert.ToInt32(txtTipoId.Text);
                        qryUpdate.FirstOrDefault().EntSalCalidadIdSalida = Convert.ToInt32(txtCalidadId.Text);
                        //qryUpdate.FirstOrDefault().EntSalBL = txtBL.Text;
                        qryUpdate.FirstOrDefault().EntSalBuqueIdSalida = Convert.ToInt32(txtBuqueId.Text);
                        qryUpdate.FirstOrDefault().EntSalNavieraId = Convert.ToInt32(txtNavieraId.Text);
                        qryUpdate.FirstOrDefault().EntSalAgenteIdSalida = Convert.ToInt32(txtAAId.Text);
                        qryUpdate.FirstOrDefault().EntSalClienteIdSalida = Convert.ToInt32(txtClienteId.Text);
                        qryUpdate.FirstOrDefault().EntSalTransporteIdSalida = Convert.ToInt32(txtTransporteId.Text);
                        qryUpdate.FirstOrDefault().EntSalEconomicoSalida = txtEco.Text;
                        qryUpdate.FirstOrDefault().EntSalPlacasSalida = txtPlacas.Text;
                        qryUpdate.FirstOrDefault().EntSalOperadorSalida = txtOperador.Text;
                        qryUpdate.FirstOrDefault().EntSalObservacionesSalida = memObservaciones.Text;
                        dbcontext.SaveChanges();

                        var qryEntradas = from ent in dbcontext.EntradaSalida where ent.EntSalFolioEirEntrada != null select ent;
                        entradaSalidaBindingSource.DataSource = qryEntradas.ToList();
                    }
                }
                Habilita(false);
            }            
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (entradaSalidaBindingSource.Count > 0 && !string.IsNullOrEmpty(txtFolioEntrada.Text))
            {
                if (MessageBox.Show("Desea realmente eliminar el registro actual", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    int IdEnt = Convert.ToInt32(txtFolioEntrada.Text);
                    var query = from ent in dbcontext.EntradaSalida where ent.EntSalId == IdEnt select ent;
                    if (query.Count() > 0)
                    {
                        dbcontext.EntradaSalida.Remove(query.SingleOrDefault());
                        dbcontext.SaveChanges();
                        var qryEntradas = from ent in dbcontext.EntradaSalida where ent.EntSalFolioEirEntrada != null select ent;
                        entradaSalidaBindingSource.DataSource = qryEntradas.ToList();
                    }
                }
            }
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flyoutPanel1.ShowPopup();
            txtBuscar.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (rbContenedor.Checked)
                {
                    var obj = entradaSalidaBindingSource.List.OfType<EntradaSalida>().ToList().Find(f => f.EntSalContenedor == txtBuscar.Text && f.EntSalFolioEirEntrada != null);
                    var pos = entradaSalidaBindingSource.IndexOf(obj);
                    entradaSalidaBindingSource.Position = pos;
                }
                else
                {
                    int IdFolio;
                    if (Int32.TryParse(txtBuscar.Text, out IdFolio))
                    {
                        var obj = entradaSalidaBindingSource.List.OfType<EntradaSalida>().ToList().Find(f => f.EntSalId == IdFolio && f.EntSalFolioEirEntrada != null);
                        var pos = entradaSalidaBindingSource.IndexOf(obj);
                        entradaSalidaBindingSource.Position = pos;
                    }
                }
            }
            flyoutPanel1.HidePopup();
        }

        private void txtBuque_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqBuque frmBuque = new FBsqBuque();
            frmBuque.ShowDialog();

            txtBuque.Text = FBsqBuque.NombreBuque;
            txtBuqueId.Text = FBsqBuque.ClaveBuque;
            txtNavieraId.Text = FBsqBuque.IdNaviera.ToString();
            txtNaviera.Text = FBsqBuque.NombreNaviera;
            txtAA.Focus();
        }

        private void txtBuque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtBuque_ButtonClick(sender, null);
        }

        private void txtAA_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqAgenteAduanal frmAgente = new FBsqAgenteAduanal();
            frmAgente.ShowDialog();

            txtAA.Text = FBsqAgenteAduanal.NombreAA;
            txtAAId.Text = FBsqAgenteAduanal.ClaveAA;
            txtCliente.Focus();
        }

        private void txtAA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtAA_ButtonClick(sender, null);
        }

        private void txtCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqCliente frmCliente = new FBsqCliente();
            frmCliente.ShowDialog();

            txtCliente.Text = FBsqCliente.NombreCte;
            txtClienteId.Text = FBsqCliente.ClaveCte;
            txtTransporte.Focus();
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtCliente_ButtonClick(sender, null);
        }

        private void txtTransporte_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqTransporte frmTransporte = new FBsqTransporte();
            frmTransporte.ShowDialog();

            txtTransporte.Text = FBsqTransporte.NombreTransporte;
            txtTransporteId.Text = FBsqTransporte.ClaveTransporte;
            txtEco.Focus();
        }

        private void txtTransporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtTransporte_ButtonClick(sender, null);
        }

        private void cbCalidad_EditValueChanged(object sender, EventArgs e)
        {
            var qry = from c in dbcontext.Calidad where c.CalidadClave == cbCalidad.Text select c;
            if (qry.Count() > 0)
                txtCalidadId.Text = qry.FirstOrDefault().CalidadId.ToString();
        }
    }
}