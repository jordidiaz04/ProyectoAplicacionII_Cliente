using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoServicios
{
    public class ServicioHuespedes
    {
        ProxyHuesped.ServiceHuespedClient service = new ProxyHuesped.ServiceHuespedClient();

        public List<ProxyHuesped.HuespedReporteBE> contarHuespedesPorPais(DateTime ini, DateTime fin) {
            return service.contarHuespedesPorPais(ini, fin);
        }

        public Decimal obtenerDineroGastadoPorHuesped(DateTime fechaInicio,
                                                      DateTime fechaFinal,
                                                      String idTipoDoc,
                                                      String numDoc)
        {
            return service.obtenerDineroGastadoPorHuesped(fechaInicio, fechaFinal, idTipoDoc, numDoc);
        }
        public Boolean registrarHuesped(ProxyHuesped.HuespedBE objHuespedBE) {
            return service.registrarHuesped(objHuespedBE);
        }


    }
}
