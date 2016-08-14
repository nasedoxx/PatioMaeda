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
    public partial class FRepEntradas : DevExpress.XtraEditors.XtraForm
    {
        public FRepEntradas()
        {
            InitializeComponent();
        }

        public void InventarioEntrada()
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                var qryEntrada = from ent in bd.EntradaSalida where ent.EntSalFolioEirEntrada != null && 
                                 ent.EntSalFolioEirSalida == null && 
                                 (ent.EntSalFechaIngreso >= dtFec1.DateTime && ent.EntSalFechaIngreso <= dtFec2.DateTime)
                                 select ent;
                if (qryEntrada.Count() > 0)
                {
                    foreach (var item in qryEntrada)
                    {
                        //agregar a tabla.
                    }
                }
            }
        }

        public void InvetarioResumen()
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                int IdNaviera = Convert.ToInt32(txtNavieraId.Text);
                var qryEntrada = from ent in bd.EntradaSalida
                                 where ent.EntSalFolioEirEntrada != null &&
                                     ent.EntSalFolioEirSalida == null &&
                                     (ent.EntSalFechaIngreso >= dtFec1.DateTime && ent.EntSalFechaIngreso <= dtFec2.DateTime) &&
                                     (ent.EntSalNavieraId == IdNaviera)
                                 select ent;

                var tam = from t in bd.TipoContenedor select t;
                var calidad = from c in bd.Calidad select c;



                if (qryEntrada.Count() > 0)
                {
                    tbResumen.Clear();
                    foreach (var i in tam)
                    {                        
                        foreach (var c in calidad)
                        {
                            foreach (var item in qryEntrada)
                            {
                                if (item.EntSalNavieraId == Convert.ToInt32(txtNavieraId.Text) && item.EntSalTamId == i.TamId && item.EntSalCalidadId == c.CalidadId)
                                {
                                    DataRow[] encontrada = tbResumen.Select("CveCalidad = " + item.EntSalCalidadId.ToString() + " AND CveContenedor = " + item.EntSalTamId.ToString());

                                    if (encontrada.Length > 0)
                                        encontrada[0]["Total"] = (Convert.ToInt32(encontrada[0]["Total"].ToString()) + 1).ToString();                                        
                                    else
                                    {
                                        DataRow fila = tbResumen.NewRow();
                                        fila["CveCalidad"] = c.CalidadId.ToString();
                                        fila["CveContenedor"] = item.EntSalTamId.ToString();
                                        fila["Dim"] = i.TamDimension;
                                        fila["Tam"] = i.TamTipo;
                                        fila["Total"] = 1;
                                        tbResumen.Rows.Add(fila);
                                    }                                    
                                }
                            }                               
                        }
                    }
                    gridControl1.DataSource = tbResumen;
                }
            }
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            InvetarioResumen();
        }

        private void FRepEntradas_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                foreach (var item in bd.Calidad)
                {
                    DataRow fila = tbResumen.NewRow();


                    tbResumen.Rows.Add(fila);
                }
            }
        }
    }
}