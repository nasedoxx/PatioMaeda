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
    public partial class FBsqBuque : DevExpress.XtraEditors.XtraForm
    {
        public static string ClaveBuque;
        public static string NombreBuque;
        public static int IdNaviera;
        public static string NombreNaviera;

        
        public FBsqBuque()
        {
            InitializeComponent();
        }

        private void FBsqBuque_Load(object sender, EventArgs e)
        {
            using (ControlPatioEntities bd = new ControlPatioEntities())
            {
                buqueBindingSource.DataSource = bd.Buque.ToList();
            }
        }

        private void FBsqBuque_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gvBuque.FocusedRowHandle < 0)
            {
                ClaveBuque = string.Empty;
                NombreBuque = string.Empty;
                IdNaviera = 0;
                NombreNaviera = string.Empty;
            }
            else
            {
                ClaveBuque = gvBuque.GetRowCellValue(gvBuque.FocusedRowHandle, "BuqueId").ToString();
                NombreBuque = gvBuque.GetRowCellValue(gvBuque.FocusedRowHandle, "BuqueNombre").ToString();
                IdNaviera = Convert.ToInt32(gvBuque.GetRowCellValue(gvBuque.FocusedRowHandle, "BuqueNavieraId").ToString());

             
                using(ControlPatioEntities bd = new ControlPatioEntities())
	            {
                    var qry = from n in bd.Naviera where n.NavieraId == 1 select n;
                    if (qry.Count() > 0)
                    {
                        NombreNaviera = qry.FirstOrDefault().NavieraNombre;
                    }
	            }                                                         
            }
        }

        private void FBsqBuque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Enter)
                Close();
        }

        private void gcBuque_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}