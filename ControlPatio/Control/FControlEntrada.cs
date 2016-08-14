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
using System.Data.Entity;


namespace ControlPatio.Control
{
    public partial class FControlEntrada : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bs = new BindingSource();
        ControlPatioEntities dbcontext;
        bool nuevo = true;

        public FControlEntrada()
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
            cbStatus.SelectedIndex = 0;
            dtFechaEntrada.Text = string.Empty;
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
            txtContenedor.Enabled = opc;
            txtBL.Enabled = opc;
            txtBuque.Enabled = opc;
            cbCalidad.Enabled = opc;
            cbTam.Enabled = opc;
            cbTipo.Enabled = opc;
            cbTManiobra.Enabled = opc;
            cbStatus.Enabled = opc;
            dtFechaEntrada.Enabled = opc;
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
            btnAdd.Enabled = opc;
            btnDel.Enabled = opc;
            btnVaciar.Enabled = opc;
            bnRegistros.Enabled = !opc;
        }

        public bool Validacampos()
        {
            bool valido = true;
            MsgError.ClearErrors();

            if (string.IsNullOrEmpty(dtFechaEntrada.Text))
            {
                MsgError.SetError(dtFechaEntrada, "Debe capturar la fecha de entrada");
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

            if (string.IsNullOrEmpty(txtBL.Text))
            {
                MsgError.SetError(txtBL, "Debe capturar el BL");
                valido = false;
            }

            if (string.IsNullOrEmpty(txtContenedor.Text))
            {
                MsgError.SetError(txtContenedor, "Debe capturar el contenedor");
                valido = false;
            }

            return valido;
        }

        private void FControlEntrada_Load(object sender, EventArgs e)
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
            
            entradaSalidaBindingSource.DataSource = dbcontext.EntradaSalida.ToList();
            bnRegistros.DataSource = entradaSalidaBindingSource;
            Habilita(false);
        }

        private void txtTipoId_EditValueChanged(object sender, EventArgs e)
        {
            /*            if (!string.IsNullOrEmpty(txtTipoId.Text))
                           cbTipo.SelectedIndex = Convert.ToInt32(txtTipoId.Text);*/
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            entradaSalidaBindingSource.DataSource = typeof(EntradaSalida);
            Limpiar();
            dtFechaEntrada.Focus();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Habilita(true);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            nuevo = false;
        }

        private void btnDeshacer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar();
            FControlEntrada_Load(sender, null);
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
                        entradaSalidaBindingSource.DataSource = dbcontext.EntradaSalida.ToList();
                    }
                }
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validacampos())
            {
                if (nuevo)
                {
                    EntradaSalida entrada = new EntradaSalida()
                    {
                        EntSalFechaIngreso = dtFechaEntrada.DateTime,                        
                        EntSalTipoMan = Convert.ToByte(cbTManiobra.SelectedIndex),
                        EntSalTipoManDesc = cbTManiobra.Text,
                        EntSalContenedor = txtContenedor.Text,
                        EntSalTamId = Convert.ToInt32(txtTipoId.Text),
                        EntSalCalidadId = Convert.ToInt32(txtCalidadId.Text),
                        EntSalStatus = cbStatus.Text,
                        EntSalBL = txtBL.Text,
                        EntSalBuqueId = Convert.ToInt32(txtBuqueId.Text),
                        EntSalNavieraId = Convert.ToInt32(txtNavieraId.Text),
                        EntSalAgenteId = Convert.ToInt32(txtAAId.Text),
                        EntSalClienteId = Convert.ToInt32(txtClienteId.Text),
                        EntSalTransporteId = Convert.ToInt32(txtTransporteId.Text),
                        EntSalEconomico = txtEco.Text,
                        EntSalPlacas = txtPlacas.Text,
                        EntSalOperador = txtOperador.Text,
                        EntSalObservaciones = memObservaciones.Text
                    };
                    dbcontext.EntradaSalida.Add(entrada);
                    dbcontext.SaveChanges();
                    //entradaSalidaBindingSource.DataSource = dbcontext.EntradaSalida.ToList();
                    FControlEntrada_Load(sender, null);
                    entradaSalidaBindingSource.MoveLast();
                }
                else
                {
                    int IdEntrada = Convert.ToInt32(txtFolioEntrada.Text);
                    var qryUpdate = from ent in dbcontext.EntradaSalida where ent.EntSalId == IdEntrada select ent;
                    if (qryUpdate.Count() > 0)
                    {
                        qryUpdate.FirstOrDefault().EntSalFechaIngreso = dtFechaEntrada.DateTime;
                        qryUpdate.FirstOrDefault().EntSalTipoMan = Convert.ToByte(cbTManiobra.SelectedIndex);
                        qryUpdate.FirstOrDefault().EntSalTipoManDesc = cbTManiobra.Text;
                        qryUpdate.FirstOrDefault().EntSalContenedor = txtContenedor.Text;
                        qryUpdate.FirstOrDefault().EntSalTamId = Convert.ToInt32(txtTipoId.Text);
                        qryUpdate.FirstOrDefault().EntSalCalidadId = Convert.ToInt32(txtCalidadId.Text);
                        qryUpdate.FirstOrDefault().EntSalStatus = cbStatus.Text;
                        qryUpdate.FirstOrDefault().EntSalBL = txtBL.Text;
                        qryUpdate.FirstOrDefault().EntSalBuqueId = Convert.ToInt32(txtBuqueId.Text);
                        qryUpdate.FirstOrDefault().EntSalNavieraId = Convert.ToInt32(txtNavieraId.Text);
                        qryUpdate.FirstOrDefault().EntSalAgenteId = Convert.ToInt32(txtAAId.Text);
                        qryUpdate.FirstOrDefault().EntSalClienteId = Convert.ToInt32(txtClienteId.Text);
                        qryUpdate.FirstOrDefault().EntSalTransporteId = Convert.ToInt32(txtTransporteId.Text);
                        qryUpdate.FirstOrDefault().EntSalEconomico = txtEco.Text;
                        qryUpdate.FirstOrDefault().EntSalPlacas = txtPlacas.Text;
                        qryUpdate.FirstOrDefault().EntSalOperador = txtOperador.Text;
                        qryUpdate.FirstOrDefault().EntSalObservaciones = memObservaciones.Text;
                        dbcontext.SaveChanges();
                        entradaSalidaBindingSource.DataSource = dbcontext.EntradaSalida.ToList();
                    }
                }
                Habilita(false);
            }
        }

        private void cbTam_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbTam.Text) && !string.IsNullOrEmpty(cbTipo.Text))
            {
                var qry = from t in dbcontext.TipoContenedor where t.TamDimension == cbTam.Text && t.TamTipo == cbTipo.Text select t;
                if (qry.Count() > 0)
                    txtTipoId.Text = qry.FirstOrDefault().TamId.ToString();
            }
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

        private void txtTransporte_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqTransporte frmTransporte = new FBsqTransporte();
            frmTransporte.ShowDialog();

            txtTransporte.Text = FBsqTransporte.NombreTransporte;
            txtTransporteId.Text = FBsqTransporte.ClaveTransporte;
            txtEco.Focus();
        }

        private void txtManiobraId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtManiobraId.Text))
                cbTManiobra.SelectedIndex = Convert.ToInt32(txtManiobraId.Text);
        }

        private void cbCalidad_EditValueChanged(object sender, EventArgs e)
        {
            var qry = from c in dbcontext.Calidad where c.CalidadClave == cbCalidad.Text select c;
            if (qry.Count() > 0)
                txtCalidadId.Text = qry.FirstOrDefault().CalidadId.ToString();
        }

        private void dtFechaEntrada_DoubleClick(object sender, EventArgs e)
        {
            dtFechaEntrada.DateTime = DateTime.Now;
        }

        private void txtTransporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtTransporte_ButtonClick(sender, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (rbContenedor.Checked)
                {
                    var obj = entradaSalidaBindingSource.List.OfType<EntradaSalida>().ToList().Find(f => f.EntSalContenedor == txtBuscar.Text);
                    var pos = entradaSalidaBindingSource.IndexOf(obj);
                    entradaSalidaBindingSource.Position = pos;                    
                }
                else
                {
                    int IdFolio;
                    if (Int32.TryParse(txtBuscar.Text, out IdFolio))
                    {
                        var obj = entradaSalidaBindingSource.List.OfType<EntradaSalida>().ToList().Find(f => f.EntSalId == IdFolio);
                        var pos = entradaSalidaBindingSource.IndexOf(obj);
                        entradaSalidaBindingSource.Position = pos;                    
                    }
                }
            }
            flyoutPanel1.HidePopup();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flyoutPanel1.ShowPopup();
            txtBuscar.Focus();
        }

        private void rbContenedor_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void rbFolio_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnBuscar_ItemClick(sender, null);
        }
    }
}