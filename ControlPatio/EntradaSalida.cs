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
    
    public partial class EntradaSalida
    {
        public EntradaSalida()
        {
            this.Eir = new ObservableCollection<Eir>();
        }
    
        public int EntSalId { get; set; }
        public int EntSalNavieraId { get; set; }
        public Nullable<System.DateTime> EntSalFechaIngreso { get; set; }
        public string EntSalContenedor { get; set; }
        public int EntSalTamId { get; set; }
        public int EntSalAgenteId { get; set; }
        public Nullable<int> EntSalAgenteIdSalida { get; set; }
        public int EntSalClienteId { get; set; }
        public int EntSalTransporteId { get; set; }
        public string EntSalEconomico { get; set; }
        public string EntSalPlacas { get; set; }
        public string EntSalOperador { get; set; }
        public int EntSalBuqueId { get; set; }
        public int EntSalCalidadId { get; set; }
        public Nullable<byte> EntSalTipoMan { get; set; }
        public string EntSalTipoManDesc { get; set; }
        public string EntSalBL { get; set; }
        public string EntSalObservaciones { get; set; }
        public string EntSalObservacionesSalida { get; set; }
        public Nullable<int> EntSalFolioEirEntrada { get; set; }
        public Nullable<System.DateTime> EntSalFechaSalida { get; set; }
        public Nullable<int> EntSalClienteIdSalida { get; set; }
        public Nullable<int> EntSalTransporteIdSalida { get; set; }
        public string EntSalEconomicoSalida { get; set; }
        public string EntSalPlacasSalida { get; set; }
        public string EntSalOperadorSalida { get; set; }
        public Nullable<int> EntSalBuqueIdSalida { get; set; }
        public Nullable<int> EntSalCalidadIdSalida { get; set; }
        public Nullable<byte> EntSalTipoManSalida { get; set; }
        public string EntSalTipoManDescSalida { get; set; }
        public string EntSalBooking { get; set; }
        public string EntSalSello { get; set; }
        public Nullable<int> EntSalFolioEirSalida { get; set; }
        public string EntSalStatus { get; set; }
        public string EntSalStatusSalida { get; set; }
    
        public virtual AgenteAduanal AgenteAduanal { get; set; }
        public virtual AgenteAduanal AgenteAduanal1 { get; set; }
        public virtual Buque Buque { get; set; }
        public virtual Buque Buque1 { get; set; }
        public virtual Calidad Calidad { get; set; }
        public virtual Calidad Calidad1 { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Cliente1 { get; set; }
        public virtual ICollection<Eir> Eir { get; set; }
        public virtual Naviera Naviera { get; set; }
        public virtual TipoContenedor TipoContenedor { get; set; }
        public virtual Transporte Transporte { get; set; }
        public virtual Transporte Transporte1 { get; set; }
    }
}
