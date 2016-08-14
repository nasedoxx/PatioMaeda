using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ControlPatio.Control;
using ControlPatio.Catalogos;

namespace ControlPatio
{
    public partial class FPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FEir frmEir;
        FControlEntrada frmControlEntrada;
        FControlSalida frmControlSalida;

        FCatClientes frmClientes;
        FCatTransportes frmTrasportes;
        FCatAgenteAd frmAgenteAduanal;
        FCatBuques frmBuques;
        FCatCalidad frmCalidad;

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnEIR_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmEir == null)
            {
                frmEir = new FEir();
                frmEir.MdiParent = this;
                frmEir.Disposed += new EventHandler(frmEir_Cerrar);
                frmEir.Show();
            }
        }

        private void frmEir_Cerrar(object sender, EventArgs e)
        {
            frmEir = null;
        }

        private void btnEntradas_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmControlEntrada == null)
            {
                frmControlEntrada = new FControlEntrada();
                frmControlEntrada.MdiParent = this;
                frmControlEntrada.Disposed += new EventHandler(frmControlEntrada_Cerrar);
                frmControlEntrada.Show();
            }
        }

        private void frmControlEntrada_Cerrar(object sender, EventArgs e)
        {
            frmControlEntrada = null;
        }

        private void btnSalidas_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmControlSalida == null)
            {
                frmControlSalida = new FControlSalida();
                frmControlSalida.MdiParent = this;
                frmControlSalida.Disposed += new EventHandler(frmControlSalida_Cerrar);
                frmControlSalida.Show();
            }
        }

        private void frmControlSalida_Cerrar(object sender, EventArgs e)
        {
            frmControlSalida = null;
        }

        private void btnRepEntSal_ItemClick(object sender, ItemClickEventArgs e)
        {
            FRepEntradas frmReporteEntSal = new FRepEntradas();
            frmReporteEntSal.ShowDialog();
        }

        private void btnClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmClientes == null)
            {
                frmClientes = new FCatClientes();
                frmClientes.MdiParent = this;
                frmClientes.Disposed += new EventHandler(frmClientes_Cerrar);
                frmClientes.Show();
            }
        }

        private void frmClientes_Cerrar(object sender, EventArgs e)
        {
            frmClientes = null;
        }

        private void btnTransporte_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmTrasportes == null)
            {
                frmTrasportes = new FCatTransportes();
                frmTrasportes.MdiParent = this;
                frmTrasportes.Disposed += new EventHandler(frmTrasportes_Cerrar);
                frmTrasportes.Show();
            }
        }

        private void frmTrasportes_Cerrar(object sender, EventArgs e)
        {
            frmTrasportes = null;
        }

        private void btnAgente_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmAgenteAduanal == null)
            {
                frmAgenteAduanal = new FCatAgenteAd();
                frmAgenteAduanal.MdiParent = this;
                frmAgenteAduanal.Disposed += new EventHandler(frmAgenteAduanal_Cerrar);
                frmAgenteAduanal.Show();
            }
        }

        private void frmAgenteAduanal_Cerrar(object sender, EventArgs e)
        {
            frmAgenteAduanal = null;
        }

        private void btnBuque_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBuques == null)
            {
                frmBuques = new FCatBuques();
                frmBuques.MdiParent = this;
                frmBuques.Disposed += new EventHandler(frmBuques_Cerrar);
                frmBuques.Show();
            }
        }

        private void frmBuques_Cerrar(object sender, EventArgs e)
        {
            frmBuques = null;
        }

        private void btnCalidad_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCalidad == null)
            {
                frmCalidad = new FCatCalidad();
                frmCalidad.MdiParent = this;
                frmCalidad.Disposed += new EventHandler(frmCalidad_Cerrar);
                frmCalidad.Show();
            }
        }

        private void frmCalidad_Cerrar(object sender, EventArgs e)
        {
            frmCalidad = null;
        }
    }
}