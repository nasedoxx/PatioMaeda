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
    
    public partial class Naviera
    {
        public Naviera()
        {
            this.Buque = new ObservableCollection<Buque>();
            this.EntradaSalida = new ObservableCollection<EntradaSalida>();
        }
    
        public int NavieraId { get; set; }
        public string NavieraNombre { get; set; }
    
        public virtual ICollection<Buque> Buque { get; set; }
        public virtual ICollection<EntradaSalida> EntradaSalida { get; set; }
    }
}