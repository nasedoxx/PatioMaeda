//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlPatio
{
    using System;
    using System.Collections.ObjectModel;
    using System.Collections.Generic;
    
    public partial class Transporte
    {
        public Transporte()
        {
            this.EntradaSalida = new ObservableCollection<EntradaSalida>();
            this.EntradaSalida1 = new ObservableCollection<EntradaSalida>();
        }
    
        public int TransporteId { get; set; }
        public string TransporteNombre { get; set; }
    
        public virtual ICollection<EntradaSalida> EntradaSalida { get; set; }
        public virtual ICollection<EntradaSalida> EntradaSalida1 { get; set; }
    }
}
