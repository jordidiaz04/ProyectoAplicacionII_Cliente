﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionWeb.ProxyReserva {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservaBE", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class ReservaBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaInicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaSalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AplicacionWeb.ProxyReserva.HuespedBE HuespedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTipoPagoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdentificadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MontoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoPagoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distrito {
            get {
                return this.DistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.DistritoField, value) != true)) {
                    this.DistritoField = value;
                    this.RaisePropertyChanged("Distrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dni {
            get {
                return this.DniField;
            }
            set {
                if ((object.ReferenceEquals(this.DniField, value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaInicio {
            get {
                return this.FechaInicioField;
            }
            set {
                if ((this.FechaInicioField.Equals(value) != true)) {
                    this.FechaInicioField = value;
                    this.RaisePropertyChanged("FechaInicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaSalida {
            get {
                return this.FechaSalidaField;
            }
            set {
                if ((this.FechaSalidaField.Equals(value) != true)) {
                    this.FechaSalidaField = value;
                    this.RaisePropertyChanged("FechaSalida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AplicacionWeb.ProxyReserva.HuespedBE Huesped {
            get {
                return this.HuespedField;
            }
            set {
                if ((object.ReferenceEquals(this.HuespedField, value) != true)) {
                    this.HuespedField = value;
                    this.RaisePropertyChanged("Huesped");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTipoPago {
            get {
                return this.IdTipoPagoField;
            }
            set {
                if ((this.IdTipoPagoField.Equals(value) != true)) {
                    this.IdTipoPagoField = value;
                    this.RaisePropertyChanged("IdTipoPago");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identificador {
            get {
                return this.IdentificadorField;
            }
            set {
                if ((object.ReferenceEquals(this.IdentificadorField, value) != true)) {
                    this.IdentificadorField = value;
                    this.RaisePropertyChanged("Identificador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Monto {
            get {
                return this.MontoField;
            }
            set {
                if ((this.MontoField.Equals(value) != true)) {
                    this.MontoField = value;
                    this.RaisePropertyChanged("Monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Piso {
            get {
                return this.PisoField;
            }
            set {
                if ((this.PisoField.Equals(value) != true)) {
                    this.PisoField = value;
                    this.RaisePropertyChanged("Piso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoPago {
            get {
                return this.TipoPagoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoPagoField, value) != true)) {
                    this.TipoPagoField = value;
                    this.RaisePropertyChanged("TipoPago");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HuespedBE", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class HuespedBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdPaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdTipoDocField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumDocField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDocField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPais {
            get {
                return this.IdPaisField;
            }
            set {
                if ((object.ReferenceEquals(this.IdPaisField, value) != true)) {
                    this.IdPaisField = value;
                    this.RaisePropertyChanged("IdPais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdTipoDoc {
            get {
                return this.IdTipoDocField;
            }
            set {
                if ((object.ReferenceEquals(this.IdTipoDocField, value) != true)) {
                    this.IdTipoDocField = value;
                    this.RaisePropertyChanged("IdTipoDoc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumDoc {
            get {
                return this.NumDocField;
            }
            set {
                if ((object.ReferenceEquals(this.NumDocField, value) != true)) {
                    this.NumDocField = value;
                    this.RaisePropertyChanged("NumDoc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDoc {
            get {
                return this.TipoDocField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocField, value) != true)) {
                    this.TipoDocField = value;
                    this.RaisePropertyChanged("TipoDoc");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyReserva.IServiceReserva")]
    public interface IServiceReserva {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceReserva/listarReservasPorHuesped", ReplyAction="http://tempuri.org/IServiceReserva/listarReservasPorHuespedResponse")]
        AplicacionWeb.ProxyReserva.ReservaBE[] listarReservasPorHuesped(string idTipoDoc, string numDoc, System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceReserva/listarReservasPorHuesped", ReplyAction="http://tempuri.org/IServiceReserva/listarReservasPorHuespedResponse")]
        System.Threading.Tasks.Task<AplicacionWeb.ProxyReserva.ReservaBE[]> listarReservasPorHuespedAsync(string idTipoDoc, string numDoc, System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceReserva/listarReservasPorFecha", ReplyAction="http://tempuri.org/IServiceReserva/listarReservasPorFechaResponse")]
        AplicacionWeb.ProxyReserva.ReservaBE[] listarReservasPorFecha(System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceReserva/listarReservasPorFecha", ReplyAction="http://tempuri.org/IServiceReserva/listarReservasPorFechaResponse")]
        System.Threading.Tasks.Task<AplicacionWeb.ProxyReserva.ReservaBE[]> listarReservasPorFechaAsync(System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceReserva/registrarReserva", ReplyAction="http://tempuri.org/IServiceReserva/registrarReservaResponse")]
        bool registrarReserva(System.DateTime fechaIngreso, System.DateTime fechaSalida, int idTipoPago, decimal monto, int[] lstIdsAmbiente, int[] lstIdsHuesped);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceReserva/registrarReserva", ReplyAction="http://tempuri.org/IServiceReserva/registrarReservaResponse")]
        System.Threading.Tasks.Task<bool> registrarReservaAsync(System.DateTime fechaIngreso, System.DateTime fechaSalida, int idTipoPago, decimal monto, int[] lstIdsAmbiente, int[] lstIdsHuesped);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceReservaChannel : AplicacionWeb.ProxyReserva.IServiceReserva, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceReservaClient : System.ServiceModel.ClientBase<AplicacionWeb.ProxyReserva.IServiceReserva>, AplicacionWeb.ProxyReserva.IServiceReserva {
        
        public ServiceReservaClient() {
        }
        
        public ServiceReservaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceReservaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceReservaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceReservaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AplicacionWeb.ProxyReserva.ReservaBE[] listarReservasPorHuesped(string idTipoDoc, string numDoc, System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.listarReservasPorHuesped(idTipoDoc, numDoc, fechaInicio, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<AplicacionWeb.ProxyReserva.ReservaBE[]> listarReservasPorHuespedAsync(string idTipoDoc, string numDoc, System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.listarReservasPorHuespedAsync(idTipoDoc, numDoc, fechaInicio, fechaFinal);
        }
        
        public AplicacionWeb.ProxyReserva.ReservaBE[] listarReservasPorFecha(System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.listarReservasPorFecha(fechaInicio, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<AplicacionWeb.ProxyReserva.ReservaBE[]> listarReservasPorFechaAsync(System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.listarReservasPorFechaAsync(fechaInicio, fechaFinal);
        }
        
        public bool registrarReserva(System.DateTime fechaIngreso, System.DateTime fechaSalida, int idTipoPago, decimal monto, int[] lstIdsAmbiente, int[] lstIdsHuesped) {
            return base.Channel.registrarReserva(fechaIngreso, fechaSalida, idTipoPago, monto, lstIdsAmbiente, lstIdsHuesped);
        }
        
        public System.Threading.Tasks.Task<bool> registrarReservaAsync(System.DateTime fechaIngreso, System.DateTime fechaSalida, int idTipoPago, decimal monto, int[] lstIdsAmbiente, int[] lstIdsHuesped) {
            return base.Channel.registrarReservaAsync(fechaIngreso, fechaSalida, idTipoPago, monto, lstIdsAmbiente, lstIdsHuesped);
        }
    }
}
