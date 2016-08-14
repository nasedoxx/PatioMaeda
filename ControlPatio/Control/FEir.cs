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
using System.Drawing.Imaging;
using ControlPatio.Reportes;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Shape;
using ControlPatio.Catalogos;

namespace ControlPatio.Control
{
    public partial class FEir : DevExpress.XtraEditors.XtraForm
    {
        private Bitmap bmp;
        int vista = 1;
        bool nuevo;
        DateTime FechaHora;
        string AgAd;
        //int iBack, iFront, iVacio;

        string naviera, transporte, operador, fechaEir, status, bk;


        ControlPatioEntities dbcontext;

        
        public FEir()
        {
            InitializeComponent();
            pbPuntos.Controls.Add(pbOk);
        }

        private void VaciarTablas()
        {
            tbBack.Clear();
            tbFront.Clear();
            tbVacio.Clear();
            tbBack.Columns["Id"].AutoIncrementStep = -1;
            tbBack.Columns["Id"].AutoIncrementSeed = -1;
            tbBack.Columns["Id"].AutoIncrementStep = 1;
            tbBack.Columns["Id"].AutoIncrementSeed = 1;
            tbFront.Columns["Id"].AutoIncrementStep = -1;
            tbFront.Columns["Id"].AutoIncrementSeed = -1;
            tbFront.Columns["Id"].AutoIncrementStep = 1;
            tbFront.Columns["Id"].AutoIncrementSeed = 1;                  
            tbVacio.Columns["Id"].AutoIncrementStep = -1;
            tbVacio.Columns["Id"].AutoIncrementSeed = -1;
            tbVacio.Columns["Id"].AutoIncrementStep = 1;
            tbVacio.Columns["Id"].AutoIncrementSeed = 1;
        }

        private void Limpiar()
        {
            txtContenedor.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtBuque.Text = string.Empty;            
            txtBL.Text = string.Empty;
            txtDim.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtFolioEir.Text = string.Empty;
            memObservaciones.Text = string.Empty;
            txtIdEntradaSalida.Text = string.Empty;
            txtClienteSalida.Text = string.Empty;
            txtBuqueSalida.Text = string.Empty;

           // pbOk.Image = null;
            pbOk.Visible = false;
            rbOrigen.Checked = true;
            nuevo = true;
            naviera = string.Empty;
            transporte = string.Empty;
            operador = string.Empty;
            fechaEir = string.Empty;
            AgAd = string.Empty;

            VaciarTablas();
        }

        private void Habilita(bool opc)
        {
            txtContenedor.Enabled = opc;
            memObservaciones.Enabled = opc;
            gbTipoDaño.Enabled = opc;
            gcCodigos.Enabled = opc;
            gcLista.Enabled = opc;

            btnNuevo.Enabled = !opc;
            btnImprimir.Enabled = !opc;
            btnGuardar.Enabled = opc;
            btnDeshacer.Enabled = opc;
            btnEditar.Enabled = !opc;
            btnEliminar.Enabled = !opc;
            btnBuscar.Enabled = !opc;
            btnDel.Enabled = opc;
            btnVaciar.Enabled = opc;
            pbPuntos.Enabled = opc;
        }

        private int iifRb()
        {
            int valor = 0;
            if (rbOrigen.Checked)
                valor = 0;
            if (rbUso.Checked)
                valor = 1;
            if (rbReciente.Checked)
                valor = 2;

            return valor;
        }

        private void FEir_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(@"C:\Resources\Container_front.png");
            vista = 1;

            pbPuntos.Image = (Image)bmp;
            Graphics g = Graphics.FromImage(bmp);
            Font fuente = new Font("Tahoma", 4);
            //g.DrawString("1", fuente, System.Drawing.Brushes.Blue, new PointF(290, 189));
          
            dbcontext = new ControlPatioEntities();
            codigoDañoBindingSource.DataSource = dbcontext.CodigoDaño.ToList();

            txtIdEntradaSalida.Visible = false;
            Limpiar();
            Habilita(false);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
         //   if (bmp == null)
         //       bmp = new Bitmap(@"./Container_front.png");                

          //  pictureBox1.Image = (Image)bmp;
        //    Graphics g = Graphics.FromImage(bmp);
        //    Font fuente = new Font("Arial", 4);
       //     c += 1;
        //    g.DrawString("1", fuente, System.Drawing.Brushes.Blue, new PointF(290, 189));
            //g.DrawString("1", fuente, System.Drawing.Brushes.Blue, new PointF(313, 37));
            //g.DrawString("1", fuente, System.Drawing.Brushes.Blue, new PointF(165, 308));

        }

        private void pbPuntos_Click(object sender, EventArgs e)
        {
            //label_x.Text = (pictureBox1.PointToClient(Cursor.Position).X).ToString();
            //label_y.Text = (pictureBox1.PointToClient(Cursor.Position).Y).ToString();
            if (!pbOk.Visible)
            {
                pbPuntos.Image = (Image)bmp;
                Graphics g = Graphics.FromImage(pbPuntos.Image);
                Font fuente = new Font("Tahoma", 4);
                SolidBrush brush = new SolidBrush(Color.Black);
                PointF punto = new PointF(pbPuntos.PointToClient(Cursor.Position).X - 5, pbPuntos.PointToClient(Cursor.Position).Y - 5);

                switch (vista)
                {
                    case 0:
                        {
                            // iBack += 1;                        
                            gcLista.DataSource = tbBack;

                            DataRow fila = tbBack.NewRow();
                            fila["IdDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoId").ToString();
                            fila["CveDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString();
                            fila["TipoDaño"] = iifRb();
                            fila["X"] = pbPuntos.PointToClient(Cursor.Position).X - 5;
                            fila["Y"] = pbPuntos.PointToClient(Cursor.Position).Y - 5;
                            if (iifRb() == 0)
                                fila["O"] = "X";
                            if (iifRb() == 1)
                                fila["U"] = "X";
                            if (iifRb() == 2)
                                fila["R"] = "X";
                            tbBack.Rows.Add(fila);

                            g.DrawString(tbBack.Rows.Count.ToString(), fuente, System.Drawing.Brushes.Blue, punto);

                            break;
                        }
                    case 1:
                        {
                            //                        iFront += 1;
                            gcLista.DataSource = tbFront;

                            DataRow fila = tbFront.NewRow();
                            fila["IdDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoId").ToString();
                            fila["CveDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString();
                            fila["TipoDaño"] = iifRb();
                            fila["X"] = pbPuntos.PointToClient(Cursor.Position).X - 5;
                            fila["Y"] = pbPuntos.PointToClient(Cursor.Position).Y - 5;
                            if (iifRb() == 0)
                                fila["O"] = "X";
                            if (iifRb() == 1)
                                fila["U"] = "X";
                            if (iifRb() == 2)
                                fila["R"] = "X";
                            tbFront.Rows.Add(fila);

                            g.DrawString(tbFront.Rows.Count.ToString(), fuente, System.Drawing.Brushes.Blue, punto);
                            break;
                        }
                    case 2:
                        {
                            //                        iVacio += 1;
                            gcLista.DataSource = tbVacio;

                            DataRow fila = tbVacio.NewRow();
                            fila["IdDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoId").ToString();
                            fila["CveDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString();
                            fila["TipoDaño"] = iifRb();
                            fila["X"] = pbPuntos.PointToClient(Cursor.Position).X - 5;
                            fila["Y"] = pbPuntos.PointToClient(Cursor.Position).Y - 5;
                            if (iifRb() == 0)
                                fila["O"] = "X";
                            if (iifRb() == 1)
                                fila["U"] = "X";
                            if (iifRb() == 2)
                                fila["R"] = "X";
                            tbVacio.Rows.Add(fila);

                            g.DrawString(tbVacio.Rows.Count.ToString(), fuente, System.Drawing.Brushes.Blue, punto);

                            break;
                        }
                }
            }
            else
            {
                if (pbOk.Visible && gvLista.RowCount < 1)
                {
                    gcLista.DataSource = tbBack;
                    DataRow filaB = tbBack.NewRow();
                    filaB["IdDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoId").ToString();
                    filaB["CveDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString();
                    filaB["TipoDaño"] = 0;
                    filaB["X"] = 0;
                    filaB["Y"] = 0;
                    tbBack.Rows.Add(filaB);

                    gcLista.DataSource = tbFront;
                    DataRow filaF = tbFront.NewRow();
                    filaF["IdDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoId").ToString();
                    filaF["CveDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString();
                    filaF["TipoDaño"] = 0;
                    filaF["X"] = 0;
                    filaF["Y"] = 0;
                    tbFront.Rows.Add(filaF);

                    gcLista.DataSource = tbVacio;
                    DataRow filaV = tbVacio.NewRow();
                    filaV["IdDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoId").ToString();
                    filaV["CveDaño"] = gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString();
                    filaV["TipoDaño"] = 0;
                    filaV["X"] = 0;
                    filaV["Y"] = 0;
                    tbVacio.Rows.Add(filaV);   
                }
            }    
        }

        private void FEir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FEir_Shown(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(@"C:\Resources\Container_back.png");
            pbPuntos.Image = (Image)bmp;
            vista = 0;
            gcLista.DataSource = tbBack;

            if (!pbOk.Visible)
            {                
                Graphics g = Graphics.FromImage(bmp);
                Font fuente = new Font("Tahoma", 4);
                
                if (tbBack.Rows.Count > 0)
                {
                    foreach (DataRow item in tbBack.Rows)
                    {
                        float X = Convert.ToInt32(item["X"].ToString());
                        float Y = Convert.ToInt32(item["Y"].ToString());
                        g.DrawString(item["Id"].ToString(), fuente, System.Drawing.Brushes.Blue, new PointF(X, Y));
                    }
                }
            }
        }

        private void pbFront_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(@"C:\Resources\Container_front.png");
            pbPuntos.Image = (Image)bmp;
            vista = 1;
            gcLista.DataSource = tbFront;

            if (!pbOk.Visible)
            {
                Graphics g = Graphics.FromImage(bmp);
                Font fuente = new Font("Tahoma", 4);
                
                if (tbFront.Rows.Count > 0)
                {
                    foreach (DataRow item in tbFront.Rows)
                    {
                        float X = Convert.ToInt32(item["X"].ToString());
                        float Y = Convert.ToInt32(item["Y"].ToString());
                        g.DrawString(item["Id"].ToString(), fuente, System.Drawing.Brushes.Blue, new PointF(X, Y));
                    }
                }
            }
        }

        private void pbVacio_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(@"C:\Resources\cont_vacio.png");
            pbPuntos.Image = (Image)bmp;
            vista = 2;
            gcLista.DataSource = tbVacio;

            if (!pbOk.Visible)
            {                
                Graphics g = Graphics.FromImage(bmp);
                Font fuente = new Font("Tahoma", 4);
                
                if (tbVacio.Rows.Count > 0)
                {
                    foreach (DataRow item in tbVacio.Rows)
                    {
                        float X = Convert.ToInt32(item["X"].ToString());
                        float Y = Convert.ToInt32(item["Y"].ToString());
                        g.DrawString(item["Id"].ToString(), fuente, System.Drawing.Brushes.Blue, new PointF(X, Y));
                    }
                }
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            switch (vista)
            {
                case 0:
                    {                        
                        tbBack.Clear();
                        tbBack.Columns["Id"].AutoIncrementStep = -1;
                        tbBack.Columns["Id"].AutoIncrementSeed = -1;
                        tbBack.Columns["Id"].AutoIncrementStep = 1;
                        tbBack.Columns["Id"].AutoIncrementSeed = 1;
                        pbBack_Click(sender, null);
                        break;
                    }
                case 1:
                    {                        
                        tbFront.Clear();
                        tbFront.Columns["Id"].AutoIncrementStep = -1;
                        tbFront.Columns["Id"].AutoIncrementSeed = -1;
                        tbFront.Columns["Id"].AutoIncrementStep = 1;
                        tbFront.Columns["Id"].AutoIncrementSeed = 1;
                        pbFront_Click(sender, null);
                        break;
                    }
                case 2:
                    {                        
                        tbVacio.Clear();
                        tbVacio.Columns["Id"].AutoIncrementStep = -1;
                        tbVacio.Columns["Id"].AutoIncrementSeed = -1;
                        tbVacio.Columns["Id"].AutoIncrementStep = 1;
                        tbVacio.Columns["Id"].AutoIncrementSeed = 1;
                        pbVacio_Click(sender, null);
                        break;
                    }
            }
            if (pbOk.Visible)
                pbOk.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (pbOk.Visible)
                btnVaciar_Click(sender, null);
            else
            {
                switch (vista)
                {
                    case 0:
                        {
                            if (tbBack.Rows.Count > 0)
                            {
                                gvLista.UpdateCurrentRow();
                                tbBack.Rows[gvLista.FocusedRowHandle].Delete();
                            }

                            pbBack_Click(sender, null);
                            break;
                        }
                    case 1:
                        {
                            if (tbFront.Rows.Count > 0)
                            {
                                gvLista.UpdateCurrentRow();
                                tbFront.Rows[gvLista.FocusedRowHandle].Delete();
                            }

                            pbFront_Click(sender, null);
                            break;
                        }
                    case 2:
                        {
                            if (tbVacio.Rows.Count > 0)
                            {
                                gvLista.UpdateCurrentRow();
                                tbVacio.Rows[gvLista.FocusedRowHandle].Delete();
                            }

                            pbVacio_Click(sender, null);
                            break;
                        }
                }
            }            
        }

        private void gcCodigos_DoubleClick(object sender, EventArgs e)
        {
            if (gvCodigos.GetRowCellValue(gvCodigos.FocusedRowHandle, "DañoClave").ToString() == "OK")
            {
                if (!pbOk.Visible)
                {
                    pbOk.Visible = true;
                    pbPuntos_Click(sender, null);
                }
            }
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar();
            Habilita(true);
            txtContenedor.Focus();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flyoutPanel1.ShowPopup();
            txtBuscar.Focus();
        }

        private void btnDeshacer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FEir_Load(sender, null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nuevo)
            {
                Eir eir = new Eir()
                {
                    EirContenedor = txtContenedor.Text,
                    EirFechaElabora = DateTime.Now,
                    EirOperacion = Convert.ToByte(cbOperacion.SelectedIndex),
                    EirIdEntradaSalida = Convert.ToInt32(txtIdEntradaSalida.Text)
                };
                dbcontext.Eir.Add(eir);
                dbcontext.SaveChanges();

                int IdEnt = Convert.ToInt32(txtIdEntradaSalida.Text);
                int FolioEir = 0;
                int Op;

                if (cbOperacion.SelectedIndex == 0)
                    Op = 0;
                else
                    Op = 1;

                var qryBsq = from b in dbcontext.Eir where b.EirIdEntradaSalida == IdEnt && b.EirOperacion == Op select b;
                if (qryBsq.Count() > 0)
                    FolioEir = qryBsq.FirstOrDefault().EirFolio;

                txtFolioEir.Text = FolioEir.ToString();

                //Actualizamos el folio de entrada o de salida            
                var qry = from ent in dbcontext.EntradaSalida where ent.EntSalId == IdEnt select ent;
                if (qry.Count() > 0)
                {
                    if (cbOperacion.SelectedIndex == 0)  //Entrada
                        qry.FirstOrDefault().EntSalFolioEirEntrada = Convert.ToInt32(txtFolioEir.Text);
                    else
                        if (cbOperacion.SelectedIndex == 1) //Salida
                            qry.FirstOrDefault().EntSalFolioEirSalida = Convert.ToInt32(txtFolioEir.Text);
                    dbcontext.SaveChanges();
                }

                //Guardamos los puntos de cada vista
                if (tbFront.Rows.Count > 0)
                {
                    foreach (DataRow item in tbFront.Rows)
                    {
                        PuntosF puntosFront = new PuntosF()
                        {
                            PuntosFEirId = FolioEir,
                            PuntosFDañoId = Convert.ToInt32(item["IdDaño"].ToString()),
                            PuntosFTipoDaño = item["TipoDaño"].ToString(),
                            PuntosFOrden = Convert.ToInt32(item["Id"].ToString()),
                            PuntosF_X = Convert.ToInt32(item["X"].ToString()),
                            PuntosF_Y = Convert.ToInt32(item["Y"].ToString())
                        };
                        dbcontext.PuntosF.Add(puntosFront);
                    }
                    dbcontext.SaveChanges();
                }

                if (tbBack.Rows.Count > 0)
                {
                    foreach (DataRow item in tbBack.Rows)
                    {
                        PuntosB puntosBack = new PuntosB()
                        {
                            PuntosBEirId = FolioEir,
                            PuntosBDañoId = Convert.ToInt32(item["IdDaño"].ToString()),
                            PuntosBTipoDaño = item["TipoDaño"].ToString(),
                            PuntosBOrden = Convert.ToInt32(item["Id"].ToString()),
                            PuntosB_X = Convert.ToInt32(item["X"].ToString()),
                            PuntosB_Y = Convert.ToInt32(item["Y"].ToString())
                        };
                        dbcontext.PuntosB.Add(puntosBack);
                    }
                    dbcontext.SaveChanges();
                }

                if (tbVacio.Rows.Count > 0)
                {
                    foreach (DataRow item in tbVacio.Rows)
                    {
                        PuntosV puntosVacio = new PuntosV()
                        {
                            PuntosVEirId = FolioEir,
                            PuntosVDañoId = Convert.ToInt32(item["IdDaño"].ToString()),
                            PuntosVTipoDaño = item["TipoDaño"].ToString(),
                            PuntosVOrden = Convert.ToInt32(item["Id"].ToString()),
                            PuntosV_X = Convert.ToInt32(item["X"].ToString()),
                            PuntosV_Y = Convert.ToInt32(item["Y"].ToString())
                        };
                        dbcontext.PuntosV.Add(puntosVacio);
                    }
                    dbcontext.SaveChanges();
                }
            }
            else
            {
                int FolioEir = Convert.ToInt32(txtFolioEir.Text);

                var qryDelB = from p in dbcontext.PuntosB where p.PuntosBEirId == FolioEir select p;
                if (qryDelB.Count() > 0)
                    dbcontext.PuntosB.RemoveRange(qryDelB.ToList());

                var qryDelF = from p in dbcontext.PuntosF where p.PuntosFEirId == FolioEir select p;
                if (qryDelF.Count() > 0)
                    dbcontext.PuntosF.RemoveRange(qryDelF.ToList());

                var qryDelV = from p in dbcontext.PuntosV where p.PuntosVEirId == FolioEir select p;
                if (qryDelV.Count() > 0)
                    dbcontext.PuntosV.RemoveRange(qryDelV.ToList());

                dbcontext.SaveChanges();

                //Guardamos los puntos de cada vista
                if (tbFront.Rows.Count > 0)
                {
                    foreach (DataRow item in tbFront.Rows)
                    {
                        PuntosF puntosFront = new PuntosF()
                        {
                            PuntosFEirId = FolioEir,
                            PuntosFDañoId = Convert.ToInt32(item["IdDaño"].ToString()),
                            PuntosFTipoDaño = item["TipoDaño"].ToString(),
                            PuntosFOrden = Convert.ToInt32(item["Id"].ToString()),
                            PuntosF_X = Convert.ToInt32(item["X"].ToString()),
                            PuntosF_Y = Convert.ToInt32(item["Y"].ToString())
                        };
                        dbcontext.PuntosF.Add(puntosFront);
                    }
                    dbcontext.SaveChanges();
                }

                if (tbBack.Rows.Count > 0)
                {
                    foreach (DataRow item in tbBack.Rows)
                    {
                        PuntosB puntosBack = new PuntosB()
                        {
                            PuntosBEirId = FolioEir,
                            PuntosBDañoId = Convert.ToInt32(item["IdDaño"].ToString()),
                            PuntosBTipoDaño = item["TipoDaño"].ToString(),
                            PuntosBOrden = Convert.ToInt32(item["Id"].ToString()),
                            PuntosB_X = Convert.ToInt32(item["X"].ToString()),
                            PuntosB_Y = Convert.ToInt32(item["Y"].ToString())
                        };
                        dbcontext.PuntosB.Add(puntosBack);
                    }
                    dbcontext.SaveChanges();
                }

                if (tbVacio.Rows.Count > 0)
                {
                    foreach (DataRow item in tbVacio.Rows)
                    {
                        PuntosV puntosVacio = new PuntosV()
                        {
                            PuntosVEirId = FolioEir,
                            PuntosVDañoId = Convert.ToInt32(item["IdDaño"].ToString()),
                            PuntosVTipoDaño = item["TipoDaño"].ToString(),
                            PuntosVOrden = Convert.ToInt32(item["Id"].ToString()),
                            PuntosV_X = Convert.ToInt32(item["X"].ToString()),
                            PuntosV_Y = Convert.ToInt32(item["Y"].ToString())
                        };
                        dbcontext.PuntosV.Add(puntosVacio);
                    }
                    dbcontext.SaveChanges();
                }
            }
            Habilita(false);
        }

        private void txtContenedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var qry = from ent in dbcontext.EntradaSalida 
                          where ent.EntSalContenedor == txtContenedor.Text &&
                          (ent.EntSalFolioEirEntrada == null || ent.EntSalFolioEirSalida == null)
                          select ent;
                if (qry.Count() == 1)
                {
                    txtIdEntradaSalida.Text = qry.FirstOrDefault().EntSalId.ToString();
                    txtDim.Text = qry.FirstOrDefault().TipoContenedor.TamDimension;
                    txtTipo.Text = qry.FirstOrDefault().TipoContenedor.TamTipo;
                    naviera = qry.FirstOrDefault().Naviera.NavieraNombre;
                    AgAd = qry.FirstOrDefault().AgenteAduanal.AgenteNombre;
                    bk = qry.FirstOrDefault().EntSalBL;
                    
                    memObservaciones.Text = qry.FirstOrDefault().EntSalObservaciones;                    

                    if (string.IsNullOrEmpty(qry.FirstOrDefault().EntSalFolioEirEntrada.ToString()))  //no tiene EIR de entrada
                    {
                        cbOperacion.SelectedIndex = 0;
                        txtCliente.Text = qry.FirstOrDefault().Cliente.ClienteNombre;
                        txtBuque.Text = qry.FirstOrDefault().Buque.BuqueNombre;
                        FechaHora = qry.FirstOrDefault().EntSalFechaIngreso.Value;
                        transporte = qry.FirstOrDefault().Transporte.TransporteNombre;
                        operador = qry.FirstOrDefault().EntSalOperador;
                        status = qry.FirstOrDefault().EntSalStatus;
                    }
                    else
                        if (!string.IsNullOrEmpty(qry.FirstOrDefault().EntSalFolioEirEntrada.ToString()) && string.IsNullOrEmpty(qry.FirstOrDefault().EntSalFolioEirSalida.ToString()))  //no tiene EIR de Salida pero si de Entrada
                        {
                            if (string.IsNullOrEmpty(qry.FirstOrDefault().EntSalClienteIdSalida.ToString())){
                                MessageBox.Show("Este contenedor no cuenta con registro de salida", "Sin registro de salida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Limpiar();
                                Habilita(false);
                            }                                
                            else
                            {
                                cbOperacion.SelectedIndex = 1;
                                txtClienteSalida.Text = qry.FirstOrDefault().Cliente1.ClienteNombre;
                                txtBuqueSalida.Text = qry.FirstOrDefault().Buque1.BuqueNombre;
                                FechaHora = qry.FirstOrDefault().EntSalFechaSalida.Value;
                                transporte = qry.FirstOrDefault().Transporte1.TransporteNombre;
                                operador = qry.FirstOrDefault().EntSalOperadorSalida;
                                status = qry.FirstOrDefault().EntSalStatusSalida;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este contenedor ya tiene ambos EIR de Entrada y Salida", "Ya existen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            Habilita(false);
                        }                            
                }
                else
                    MessageBox.Show("Este contenedor no tiene registro de entrada / salida", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOperacion.SelectedIndex == 0)
            {
                txtCliente.Visible = true;
                txtClienteSalida.Visible = false;
                txtBuque.Visible = true;
                txtBuqueSalida.Visible = false;
            }

            if (cbOperacion.SelectedIndex == 1)
            {
                txtClienteSalida.Visible = true;
                txtCliente.Visible = false;
                txtBuque.Visible = false;
                txtBuqueSalida.Visible = true;
            }
        }

        private void btnBuscarF_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBuscar.Text))
            {
                byte chk = 0;
                if (chkEntrada.Checked)
                    chk = 0;
                if (chkSalida.Checked)
                    chk = 1;

                if (rbContenedor.Checked)
                {
                    var qryBsq = from eir in dbcontext.Eir 
                                 where eir.EirContenedor.Contains(txtBuscar.Text) && 
                                 eir.EirOperacion == chk 
                                 select eir;
                    if (qryBsq.Count() > 0)
                    {
                        if (qryBsq.Count() > 1)
                        {                         
                            flyoutPanel1.HidePopup();
                            gcCont.DataSource = qryBsq.ToList();
                            pnlContenedores.Visible = true;
                        }
                        else
                        {
                            txtContenedor.Text = qryBsq.SingleOrDefault().EirContenedor;
                            txtFolioEir.Text = qryBsq.SingleOrDefault().EirFolio.ToString();
                            txtIdEntradaSalida.Text = qryBsq.FirstOrDefault().EirIdEntradaSalida.ToString();
                            txtDim.Text = qryBsq.FirstOrDefault().EntradaSalida.TipoContenedor.TamDimension;
                            txtTipo.Text = qryBsq.FirstOrDefault().EntradaSalida.TipoContenedor.TamTipo;
                            AgAd = qryBsq.FirstOrDefault().EntradaSalida.AgenteAduanal.AgenteNombre;
                            bk = qryBsq.FirstOrDefault().EntradaSalida.EntSalBL;
                            
                            memObservaciones.Text = qryBsq.FirstOrDefault().EntradaSalida.EntSalObservaciones;

                            if (chk == 0)
                            {
                                cbOperacion.SelectedIndex = 0;
                                txtCliente.Text = qryBsq.FirstOrDefault().EntradaSalida.Cliente.ClienteNombre;
                                txtBuque.Text = qryBsq.FirstOrDefault().EntradaSalida.Buque.BuqueNombre;
                                FechaHora = qryBsq.FirstOrDefault().EntradaSalida.EntSalFechaIngreso.Value;
                                transporte = qryBsq.FirstOrDefault().EntradaSalida.Transporte.TransporteNombre;
                                operador = qryBsq.FirstOrDefault().EntradaSalida.EntSalOperador;
                                status = qryBsq.FirstOrDefault().EntradaSalida.EntSalStatus;
                            }
                            else
                            {
                                cbOperacion.SelectedIndex = 1;
                                txtClienteSalida.Text = qryBsq.FirstOrDefault().EntradaSalida.Cliente1.ClienteNombre;
                                txtBuqueSalida.Text = qryBsq.FirstOrDefault().EntradaSalida.Buque1.BuqueNombre;
                                FechaHora = qryBsq.FirstOrDefault().EntradaSalida.EntSalFechaSalida.Value;
                                transporte = qryBsq.FirstOrDefault().EntradaSalida.Transporte1.TransporteNombre;
                                operador = qryBsq.FirstOrDefault().EntradaSalida.EntSalOperadorSalida;
                                status = qryBsq.FirstOrDefault().EntradaSalida.EntSalStatusSalida;
                            }

                            naviera = qryBsq.FirstOrDefault().EntradaSalida.Buque.Naviera.NavieraNombre;
                            VaciarTablas();

                            foreach (var item in qryBsq.FirstOrDefault().PuntosB)
                            {
                                if (item.CodigoDaño.DañoClave == "OK")
                                    pbOk.Visible = true;
                                DataRow fila = tbBack.NewRow();
                                fila["CveDaño"] = item.CodigoDaño.DañoClave;
                                fila["TipoDaño"] = item.PuntosBTipoDaño;
                                fila["IdDaño"] = item.PuntosBDañoId;
                                fila["X"] = item.PuntosB_X;
                                fila["Y"] = item.PuntosB_Y;
                                if (item.PuntosBTipoDaño == "0")
                                    fila["O"] = "X";
                                if (item.PuntosBTipoDaño == "1")
                                    fila["U"] = "X";
                                if (item.PuntosBTipoDaño == "2")
                                    fila["R"] = "X";
                                tbBack.Rows.Add(fila);
                            }

                            foreach (var item in qryBsq.FirstOrDefault().PuntosF)
                            {
                                if (item.CodigoDaño.DañoClave == "OK")
                                    pbOk.Visible = true;

                                DataRow fila = tbFront.NewRow();
                                fila["CveDaño"] = item.CodigoDaño.DañoClave;
                                fila["TipoDaño"] = item.PuntosFTipoDaño;
                                fila["IdDaño"] = item.PuntosFDañoId;
                                fila["X"] = item.PuntosF_X;
                                fila["Y"] = item.PuntosF_Y;
                                if (item.PuntosFTipoDaño == "0")
                                    fila["O"] = "X";
                                if (item.PuntosFTipoDaño == "1")
                                    fila["U"] = "X";
                                if (item.PuntosFTipoDaño == "2")
                                    fila["R"] = "X";
                                tbFront.Rows.Add(fila);
                            }

                            foreach (var item in qryBsq.FirstOrDefault().PuntosV)
                            {
                                if (item.CodigoDaño.DañoClave == "OK")
                                    pbOk.Visible = true;

                                DataRow fila = tbVacio.NewRow();
                                fila["CveDaño"] = item.CodigoDaño.DañoClave;
                                fila["TipoDaño"] = item.PuntosVTipoDaño;
                                fila["IdDaño"] = item.PuntosVDañoId;
                                fila["X"] = item.PuntosV_X;
                                fila["Y"] = item.PuntosV_Y;
                                if (item.PuntosVTipoDaño == "0")
                                    fila["O"] = "X";
                                if (item.PuntosVTipoDaño == "1")
                                    fila["U"] = "X";
                                if (item.PuntosVTipoDaño == "2")
                                    fila["R"] = "X";
                                tbVacio.Rows.Add(fila);
                            }
                            pbFront_Click(sender, null);
                            flyoutPanel1.HidePopup();
                        }
                    }
                    else
                        MessageBox.Show("No existe el contenedor para el criterio seleccionado", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int folio = Convert.ToInt32(txtBuscar.Text);
                    var qryBsq = from eir in dbcontext.Eir where eir.EirFolio == folio select eir;
                    if (qryBsq.Count() > 0)
                    {
                        txtContenedor.Text = qryBsq.SingleOrDefault().EirContenedor;
                        txtFolioEir.Text = qryBsq.SingleOrDefault().EirFolio.ToString();
                        txtIdEntradaSalida.Text = qryBsq.FirstOrDefault().EirIdEntradaSalida.ToString();
                        txtDim.Text = qryBsq.FirstOrDefault().EntradaSalida.TipoContenedor.TamDimension;
                        txtTipo.Text = qryBsq.FirstOrDefault().EntradaSalida.TipoContenedor.TamTipo;
                        AgAd = qryBsq.FirstOrDefault().EntradaSalida.AgenteAduanal.AgenteNombre;
                        memObservaciones.Text = qryBsq.FirstOrDefault().EntradaSalida.EntSalObservaciones;
                        bk = qryBsq.FirstOrDefault().EntradaSalida.EntSalBL;

                        if (qryBsq.FirstOrDefault().EirOperacion == 0)
                        {
                            cbOperacion.SelectedIndex = 0;
                            txtCliente.Text = qryBsq.FirstOrDefault().EntradaSalida.Cliente.ClienteNombre;
                            txtBuque.Text = qryBsq.FirstOrDefault().EntradaSalida.Buque.BuqueNombre;
                            FechaHora = qryBsq.FirstOrDefault().EntradaSalida.EntSalFechaIngreso.Value;
                            transporte = qryBsq.FirstOrDefault().EntradaSalida.Transporte.TransporteNombre;
                            operador = qryBsq.FirstOrDefault().EntradaSalida.EntSalOperador;
                            status = qryBsq.FirstOrDefault().EntradaSalida.EntSalStatus;
                        }
                        else
                        {
                            cbOperacion.SelectedIndex = 1;
                            txtClienteSalida.Text = qryBsq.FirstOrDefault().EntradaSalida.Cliente1.ClienteNombre;
                            txtBuqueSalida.Text = qryBsq.FirstOrDefault().EntradaSalida.Buque1.BuqueNombre;
                            FechaHora = qryBsq.FirstOrDefault().EntradaSalida.EntSalFechaSalida.Value;
                            transporte = qryBsq.FirstOrDefault().EntradaSalida.Transporte1.TransporteNombre;
                            operador = qryBsq.FirstOrDefault().EntradaSalida.EntSalOperadorSalida;
                            status = qryBsq.FirstOrDefault().EntradaSalida.EntSalStatusSalida;
                        }

                        naviera = qryBsq.FirstOrDefault().EntradaSalida.Buque.Naviera.NavieraNombre;
                        VaciarTablas();

                        foreach (var item in qryBsq.FirstOrDefault().PuntosB)
                        {
                            if (item.CodigoDaño.DañoClave == "OK")
                                pbOk.Visible = true;
                            DataRow fila = tbBack.NewRow();
                            fila["CveDaño"] = item.CodigoDaño.DañoClave;
                            fila["TipoDaño"] = item.PuntosBTipoDaño;
                            fila["IdDaño"] = item.PuntosBDañoId;
                            fila["X"] = item.PuntosB_X;
                            fila["Y"] = item.PuntosB_Y;
                            if (item.PuntosBTipoDaño == "0")
                                fila["O"] = "X";
                            if (item.PuntosBTipoDaño == "1")
                                fila["U"] = "X";
                            if (item.PuntosBTipoDaño == "2")
                                fila["R"] = "X";
                            tbBack.Rows.Add(fila);
                        }

                        foreach (var item in qryBsq.FirstOrDefault().PuntosF)
                        {
                            if (item.CodigoDaño.DañoClave == "OK")
                                pbOk.Visible = true;

                            DataRow fila = tbFront.NewRow();
                            fila["CveDaño"] = item.CodigoDaño.DañoClave;
                            fila["TipoDaño"] = item.PuntosFTipoDaño;
                            fila["IdDaño"] = item.PuntosFDañoId;
                            fila["X"] = item.PuntosF_X;
                            fila["Y"] = item.PuntosF_Y;
                            if (item.PuntosFTipoDaño == "0")
                                fila["O"] = "X";
                            if (item.PuntosFTipoDaño == "1")
                                fila["U"] = "X";
                            if (item.PuntosFTipoDaño == "2")
                                fila["R"] = "X";
                            tbFront.Rows.Add(fila);
                        }

                        foreach (var item in qryBsq.FirstOrDefault().PuntosV)
                        {
                            if (item.CodigoDaño.DañoClave == "OK")
                                pbOk.Visible = true;

                            DataRow fila = tbVacio.NewRow();
                            fila["CveDaño"] = item.CodigoDaño.DañoClave;
                            fila["TipoDaño"] = item.PuntosVTipoDaño;
                            fila["IdDaño"] = item.PuntosVDañoId;
                            fila["X"] = item.PuntosV_X;
                            fila["Y"] = item.PuntosV_Y;
                            if (item.PuntosVTipoDaño == "0")
                                fila["O"] = "X";
                            if (item.PuntosVTipoDaño == "1")
                                fila["U"] = "X";
                            if (item.PuntosVTipoDaño == "2")
                                fila["R"] = "X";
                            tbVacio.Rows.Add(fila);
                        }
                        pbFront_Click(sender, null);
                        flyoutPanel1.HidePopup();
                    }
                    else
                        MessageBox.Show("No existe el contenedor para el criterio seleccionado", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnBuscarF_Click(sender, null);
        }

        private void chkEntrada_CheckedChanged(object sender, EventArgs e)
        {
            chkSalida.Checked = !chkEntrada.Checked;
        }

        private void chkSalida_CheckedChanged(object sender, EventArgs e)
        {
            chkEntrada.Checked = !chkSalida.Checked;
        }

        private void flyoutPanel1_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            txtBuscar.Text = string.Empty;
            rbContenedor.Checked = true;
            chkEntrada.Checked = true;
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdEntradaSalida.Text))
            {
                nuevo = false;
                Habilita(true);
                txtContenedor.Enabled = false;
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flyoutPanel2.ShowPopup();
            btnPrint.Focus();                       
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFolioEir.Text))
            {
                if (MessageBox.Show("Desea realmente eliminar el registro!?", "Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    int FolioEir = Convert.ToInt32(txtFolioEir.Text);
                    var qryDel = from f in dbcontext.Eir where f.EirFolio == FolioEir select f;
                    if (qryDel.Count() > 0)
                    {
                        dbcontext.Eir.Remove(qryDel.Single());
                        dbcontext.SaveChanges();
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ImpresionEir repEir = new ImpresionEir();
            subFront subfront = new subFront();
            subBack subback = new subBack();
            subVacio subvacio = new subVacio();

            pbBack_Click(sender, null);
            repEir.pbFrente.Image = pbPuntos.Image;
            pbFront_Click(sender, null);
            repEir.pbPosterior.Image = pbPuntos.Image;
            pbVacio_Click(sender, null);
            repEir.pbInterior.Image = pbPuntos.Image;
            repEir.lblNaviera.Text = naviera;

            repEir.pbOkB.Visible = pbOk.Visible;
            repEir.pbOkF.Visible = pbOk.Visible;
            repEir.pbOkV.Visible = pbOk.Visible;

            repEir.lblContenedor.Text = txtContenedor.Text;
            repEir.lblCap.Text = txtDim.Text;
            repEir.lblTipo.Text = txtTipo.Text;
            repEir.lblFolio.Text = txtFolioEir.Text;
            repEir.lblFecIngSal.Text = FechaHora.ToString();
            repEir.lblAA.Text = AgAd;

            if (cbOperacion.SelectedIndex == 0)
            {
                repEir.lblFecha.Text = "F.Ingreso";
                repEir.lblCliente.Text = txtCliente.Text;
                repEir.lblBuque.Text = txtBuque.Text;
                repEir.lblObserva.Text = "Entrada " + txtCliente.Text + "  " + FechaHora.ToString() + "  " + transporte + "  " + operador;
                repEir.lblStatus.Text = status;
            }
            else
            {
                repEir.lblFecha.Text = "F.Salida";
                repEir.lblCliente.Text = txtClienteSalida.Text;
                repEir.lblBuque.Text = txtBuqueSalida.Text;
                repEir.lblObserva.Text = "Salida " + txtCliente.Text + "  " + FechaHora.ToString() + "  " + transporte + "  " + operador + " BL: "+bk;
                repEir.lblStatus.Text = status;
            }

            if (!pbOk.Visible)
            {
                using (DSGeneral ds = new DSGeneral())
                {
                    foreach (DataRow item in tbFront.Rows)
                    {
                        DataRow fila = ds.tbFront.NewRow();
                        fila["Id"] = item["Id"];
                        fila["CveDaño"] = item["CveDaño"];
                        fila["O"] = item["O"];
                        fila["U"] = item["U"];
                        fila["R"] = item["R"];
                        ds.tbFront.Rows.Add(fila);
                    }

                    foreach (DataRow item in tbBack.Rows)
                    {
                        DataRow fila = ds.tbBack.NewRow();
                        fila["Id"] = item["Id"];
                        fila["CveDaño"] = item["CveDaño"];
                        fila["O"] = item["O"];
                        fila["U"] = item["U"];
                        fila["R"] = item["R"];
                        ds.tbBack.Rows.Add(fila);
                    }

                    foreach (DataRow item in tbVacio.Rows)
                    {
                        DataRow fila = ds.tbVacios.NewRow();
                        fila["Id"] = item["Id"];
                        fila["CveDaño"] = item["CveDaño"];
                        fila["O"] = item["O"];
                        fila["U"] = item["U"];
                        fila["R"] = item["R"];
                        ds.tbVacios.Rows.Add(fila);
                    }

                    subfront.DataSource = ds;
                    subfront.DataMember = "tbBack";
                    subback.DataSource = ds;
                    subback.DataMember = "tbFront";
                    subvacio.DataSource = ds;
                    subvacio.DataMember = "tbVacios";

                    repEir.xSubFront.ReportSource = subfront;
                    repEir.xSubFront.ReportSource.DataSource = ds;
                    repEir.xSubFront.ReportSource.DataMember = "tbBack";
                    repEir.xSubBack.ReportSource = subback;
                    repEir.xSubBack.ReportSource.DataSource = ds;
                    repEir.xSubBack.ReportSource.DataMember = "tbFront";
                    repEir.xSubVacio.ReportSource = subvacio;
                    repEir.xSubVacio.ReportSource.DataSource = ds;
                    repEir.xSubVacio.ReportSource.DataMember = "tbVacios";
                }
            }

            using (ReportPrintTool printTool = new ReportPrintTool(repEir))
            {
                if (chkPrevio.Checked)
                    printTool.ShowPreviewDialog();
                else
                {
                    printTool.PrintDialog();
                }
            }
        }

        private void chkPrevio_CheckedChanged(object sender, EventArgs e)
        {
            chkImprimir.Checked = !chkPrevio.Checked;
        }

        private void chkImprimir_CheckedChanged(object sender, EventArgs e)
        {
            chkPrevio.Checked = !chkImprimir.Checked;
        }

        private void txtContenedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FBsqEntradas frmEntradas = new FBsqEntradas();
            frmEntradas.ShowDialog();
            KeyPressEventArgs k = null;
            txtContenedor.Text = FBsqEntradas.contenedor;
        }

        private void txtContenedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F1)
                txtContenedor_ButtonClick(sender, null);
        }

        private void gcCont_DoubleClick(object sender, EventArgs e)
        {
            int chk = 0;
            bool consulta = true;
            
            if (gvCont.FocusedRowHandle > 0)
            {
                if (chkEntrada2.Checked)
                    chk = 0;
                if (chkSalida2.Checked)
                    chk = 1;

                if (chk == 0 && (gvCont.GetRowCellValue(gvCont.FocusedRowHandle, "EntradaSalida.EntSalFolioEirEntrada") == null))
                    consulta = false;
                if (chk == 1 && (gvCont.GetRowCellValue(gvCont.FocusedRowHandle, "EntradaSalida.EntSalFolioEirSalida") == null) )
                    consulta = false;

                if (consulta)
                {
                    Limpiar();                
                    int fol = Convert.ToInt32(gvCont.GetRowCellValue(gvCont.FocusedRowHandle, "EirIdEntradaSalida").ToString());
                    var qryBsq = from eir in dbcontext.Eir
                                 where eir.EirIdEntradaSalida == fol &&
                                 eir.EirOperacion == chk
                                 select eir;

                    txtContenedor.Text = qryBsq.SingleOrDefault().EirContenedor;
                    txtFolioEir.Text = qryBsq.SingleOrDefault().EirFolio.ToString();
                    txtIdEntradaSalida.Text = qryBsq.FirstOrDefault().EirIdEntradaSalida.ToString();
                    txtDim.Text = qryBsq.FirstOrDefault().EntradaSalida.TipoContenedor.TamDimension;
                    txtTipo.Text = qryBsq.FirstOrDefault().EntradaSalida.TipoContenedor.TamTipo;
                    AgAd = qryBsq.FirstOrDefault().EntradaSalida.AgenteAduanal.AgenteNombre;
                    memObservaciones.Text = qryBsq.FirstOrDefault().EntradaSalida.EntSalObservaciones;

                    if (qryBsq.FirstOrDefault().EirOperacion == 0)
                    {
                        cbOperacion.SelectedIndex = 0;
                        txtCliente.Text = qryBsq.FirstOrDefault().EntradaSalida.Cliente.ClienteNombre;
                        txtBuque.Text = qryBsq.FirstOrDefault().EntradaSalida.Buque.BuqueNombre;
                        FechaHora = qryBsq.FirstOrDefault().EntradaSalida.EntSalFechaIngreso.Value;
                        transporte = qryBsq.FirstOrDefault().EntradaSalida.Transporte.TransporteNombre;
                        operador = qryBsq.FirstOrDefault().EntradaSalida.EntSalOperador;
                    }
                    else
                    {
                        cbOperacion.SelectedIndex = 1;
                        txtClienteSalida.Text = qryBsq.FirstOrDefault().EntradaSalida.Cliente1.ClienteNombre;
                        txtBuqueSalida.Text = qryBsq.FirstOrDefault().EntradaSalida.Buque1.BuqueNombre;
                        FechaHora = qryBsq.FirstOrDefault().EntradaSalida.EntSalFechaSalida.Value;
                        transporte = qryBsq.FirstOrDefault().EntradaSalida.Transporte1.TransporteNombre;
                        operador = qryBsq.FirstOrDefault().EntradaSalida.EntSalOperadorSalida;
                    }

                    naviera = qryBsq.FirstOrDefault().EntradaSalida.Buque.Naviera.NavieraNombre;
                    VaciarTablas();

                    foreach (var item in qryBsq.FirstOrDefault().PuntosB)
                    {
                        if (item.CodigoDaño.DañoClave == "OK")
                            pbOk.Visible = true;
                        DataRow fila = tbBack.NewRow();
                        fila["CveDaño"] = item.CodigoDaño.DañoClave;
                        fila["TipoDaño"] = item.PuntosBTipoDaño;
                        fila["IdDaño"] = item.PuntosBDañoId;
                        fila["X"] = item.PuntosB_X;
                        fila["Y"] = item.PuntosB_Y;
                        if (item.PuntosBTipoDaño == "0")
                            fila["O"] = "X";
                        if (item.PuntosBTipoDaño == "1")
                            fila["U"] = "X";
                        if (item.PuntosBTipoDaño == "2")
                            fila["R"] = "X";
                        tbBack.Rows.Add(fila);
                    }

                    foreach (var item in qryBsq.FirstOrDefault().PuntosF)
                    {
                        if (item.CodigoDaño.DañoClave == "OK")
                            pbOk.Visible = true;

                        DataRow fila = tbFront.NewRow();
                        fila["CveDaño"] = item.CodigoDaño.DañoClave;
                        fila["TipoDaño"] = item.PuntosFTipoDaño;
                        fila["IdDaño"] = item.PuntosFDañoId;
                        fila["X"] = item.PuntosF_X;
                        fila["Y"] = item.PuntosF_Y;
                        if (item.PuntosFTipoDaño == "0")
                            fila["O"] = "X";
                        if (item.PuntosFTipoDaño == "1")
                            fila["U"] = "X";
                        if (item.PuntosFTipoDaño == "2")
                            fila["R"] = "X";
                        tbFront.Rows.Add(fila);
                    }

                    foreach (var item in qryBsq.FirstOrDefault().PuntosV)
                    {
                        if (item.CodigoDaño.DañoClave == "OK")
                            pbOk.Visible = true;

                        DataRow fila = tbVacio.NewRow();
                        fila["CveDaño"] = item.CodigoDaño.DañoClave;
                        fila["TipoDaño"] = item.PuntosVTipoDaño;
                        fila["IdDaño"] = item.PuntosVDañoId;
                        fila["X"] = item.PuntosV_X;
                        fila["Y"] = item.PuntosV_Y;
                        if (item.PuntosVTipoDaño == "0")
                            fila["O"] = "X";
                        if (item.PuntosVTipoDaño == "1")
                            fila["U"] = "X";
                        if (item.PuntosVTipoDaño == "2")
                            fila["R"] = "X";
                        tbVacio.Rows.Add(fila);
                    }
                    pbFront_Click(sender, null);
                    pnlContenedores.Visible = false;
                }
            }
        }

        private void chkEntrada2_CheckedChanged(object sender, EventArgs e)
        {
            chkSalida2.Checked = !chkEntrada2.Checked;
        }

        private void chkSalida2_CheckedChanged(object sender, EventArgs e)
        {
            chkEntrada2.Checked = !chkSalida2.Checked;
        }

    }
}