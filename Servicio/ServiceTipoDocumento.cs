﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceTipoDocumento" en el código y en el archivo de configuración a la vez.
    public class ServiceTipoDocumento : IServiceTipoDocumento
    {
        public List<TipoDocumentoBE> listarTiposDocumento()
        {
            using (HospedajeEntities entity = new HospedajeEntities())
            {
                try
                {
                    List<TipoDocumentoBE> lstTipoDocumentoBE = new List<TipoDocumentoBE>();
                    var lista = (from item in entity.TipoDocumento
                                 select item).ToList();

                    foreach (var item in lista)
                    {
                        TipoDocumentoBE objTipoDocumentoBE = new TipoDocumentoBE()
                        {
                            Id = item.id,
                            Descripcion = item.descripcion
                        };
                        lstTipoDocumentoBE.Add(objTipoDocumentoBE);
                    }

                    return lstTipoDocumentoBE;
                }
                catch (Exception ex)
                {
                    return null;
                    throw ex;
                }
            }
        }
    }
}
