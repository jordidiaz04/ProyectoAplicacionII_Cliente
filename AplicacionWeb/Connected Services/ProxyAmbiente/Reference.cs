﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionWeb.ProxyAmbiente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AmbienteBE", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class AmbienteBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AforoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdentificadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
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
        public int Aforo {
            get {
                return this.AforoField;
            }
            set {
                if ((this.AforoField.Equals(value) != true)) {
                    this.AforoField = value;
                    this.RaisePropertyChanged("Aforo");
                }
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
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyAmbiente.IServiceAmbiente")]
    public interface IServiceAmbiente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorFecha", ReplyAction="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorFechaResponse")]
        AplicacionWeb.ProxyAmbiente.AmbienteBE[] obtenerAmbienteDisponiblePorFecha(System.DateTime fechaInicio, System.DateTime fechaFinal, string idUbigeo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorFecha", ReplyAction="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorFechaResponse")]
        System.Threading.Tasks.Task<AplicacionWeb.ProxyAmbiente.AmbienteBE[]> obtenerAmbienteDisponiblePorFechaAsync(System.DateTime fechaInicio, System.DateTime fechaFinal, string idUbigeo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorRangoDePrecios", ReplyAction="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorRangoDePreciosRes" +
            "ponse")]
        AplicacionWeb.ProxyAmbiente.AmbienteBE[] obtenerAmbienteDisponiblePorRangoDePrecios(System.DateTime fechaInicio, System.DateTime fechaFinal, decimal precioMenor, decimal precioMayor, string idUbigeo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorRangoDePrecios", ReplyAction="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorRangoDePreciosRes" +
            "ponse")]
        System.Threading.Tasks.Task<AplicacionWeb.ProxyAmbiente.AmbienteBE[]> obtenerAmbienteDisponiblePorRangoDePreciosAsync(System.DateTime fechaInicio, System.DateTime fechaFinal, decimal precioMenor, decimal precioMayor, string idUbigeo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorAforo", ReplyAction="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorAforoResponse")]
        AplicacionWeb.ProxyAmbiente.AmbienteBE[] obtenerAmbienteDisponiblePorAforo(System.DateTime fechaInicio, System.DateTime fechaFinal, int aforoMenor, int aforoMayor, string idUbigeo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorAforo", ReplyAction="http://tempuri.org/IServiceAmbiente/obtenerAmbienteDisponiblePorAforoResponse")]
        System.Threading.Tasks.Task<AplicacionWeb.ProxyAmbiente.AmbienteBE[]> obtenerAmbienteDisponiblePorAforoAsync(System.DateTime fechaInicio, System.DateTime fechaFinal, int aforoMenor, int aforoMayor, string idUbigeo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAmbienteChannel : AplicacionWeb.ProxyAmbiente.IServiceAmbiente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAmbienteClient : System.ServiceModel.ClientBase<AplicacionWeb.ProxyAmbiente.IServiceAmbiente>, AplicacionWeb.ProxyAmbiente.IServiceAmbiente {
        
        public ServiceAmbienteClient() {
        }
        
        public ServiceAmbienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAmbienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAmbienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAmbienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AplicacionWeb.ProxyAmbiente.AmbienteBE[] obtenerAmbienteDisponiblePorFecha(System.DateTime fechaInicio, System.DateTime fechaFinal, string idUbigeo) {
            return base.Channel.obtenerAmbienteDisponiblePorFecha(fechaInicio, fechaFinal, idUbigeo);
        }
        
        public System.Threading.Tasks.Task<AplicacionWeb.ProxyAmbiente.AmbienteBE[]> obtenerAmbienteDisponiblePorFechaAsync(System.DateTime fechaInicio, System.DateTime fechaFinal, string idUbigeo) {
            return base.Channel.obtenerAmbienteDisponiblePorFechaAsync(fechaInicio, fechaFinal, idUbigeo);
        }
        
        public AplicacionWeb.ProxyAmbiente.AmbienteBE[] obtenerAmbienteDisponiblePorRangoDePrecios(System.DateTime fechaInicio, System.DateTime fechaFinal, decimal precioMenor, decimal precioMayor, string idUbigeo) {
            return base.Channel.obtenerAmbienteDisponiblePorRangoDePrecios(fechaInicio, fechaFinal, precioMenor, precioMayor, idUbigeo);
        }
        
        public System.Threading.Tasks.Task<AplicacionWeb.ProxyAmbiente.AmbienteBE[]> obtenerAmbienteDisponiblePorRangoDePreciosAsync(System.DateTime fechaInicio, System.DateTime fechaFinal, decimal precioMenor, decimal precioMayor, string idUbigeo) {
            return base.Channel.obtenerAmbienteDisponiblePorRangoDePreciosAsync(fechaInicio, fechaFinal, precioMenor, precioMayor, idUbigeo);
        }
        
        public AplicacionWeb.ProxyAmbiente.AmbienteBE[] obtenerAmbienteDisponiblePorAforo(System.DateTime fechaInicio, System.DateTime fechaFinal, int aforoMenor, int aforoMayor, string idUbigeo) {
            return base.Channel.obtenerAmbienteDisponiblePorAforo(fechaInicio, fechaFinal, aforoMenor, aforoMayor, idUbigeo);
        }
        
        public System.Threading.Tasks.Task<AplicacionWeb.ProxyAmbiente.AmbienteBE[]> obtenerAmbienteDisponiblePorAforoAsync(System.DateTime fechaInicio, System.DateTime fechaFinal, int aforoMenor, int aforoMayor, string idUbigeo) {
            return base.Channel.obtenerAmbienteDisponiblePorAforoAsync(fechaInicio, fechaFinal, aforoMenor, aforoMayor, idUbigeo);
        }
    }
}