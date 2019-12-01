using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceTipoPago" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceTipoPago
    {
        [OperationContract]
        List<TipoPagoBE> obtenerTiposPago();
    }
}

[DataContract]
[Serializable]
public class TipoPagoBE
{
    [DataMember]
    public Int32 Id { get; set; }
    [DataMember]
    public String Descripcion { get; set; }
}