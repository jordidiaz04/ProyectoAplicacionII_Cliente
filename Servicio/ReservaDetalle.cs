//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicio
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReservaDetalle
    {
        public int id { get; set; }
        public Nullable<int> idReserva { get; set; }
        public Nullable<int> idAmbiente { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual Ambiente Ambiente { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
