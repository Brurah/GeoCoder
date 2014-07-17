using GeoCodder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Artem.Google;
using Artem.Google.Net;
using System.ServiceModel.Activation;

namespace GeoCodder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GeoLoc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GeoLoc.svc or GeoLoc.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GeoLoc : IGeoLoc
    {
        public List<RetornoLocalizacaoTotem> GetLocTotemSvc(string end)
        {
            List<RetornoLocalizacaoTotem> lstRetorno = new List<RetornoLocalizacaoTotem>();

            string[] lstend = end.Split(';');
            foreach (string loc in lstend)
            {
                string[] separador = loc.Split('_');
                string endereco = separador[0];
                string titulo = separador[1];
                string codigo = separador[2];

                GeoRequest request = new GeoRequest(endereco + ", São Paulo");
                GeoResponse response = request.GetResponse();
                foreach (GeoResult item in response.Results)
                {
                    RetornoLocalizacaoTotem local = new RetornoLocalizacaoTotem();
                    GeoLocation location = item.Geometry.Location;

                    local.CodigoNo = codigo;
                    local.Endereco = titulo;
                    local.Latitude = location.Latitude;
                    local.Longitude = location.Longitude;
                    local.EnderecoCompleto = item.FormattedAddress;
                    lstRetorno.Add(local);
                }
            }

            
            


            return lstRetorno;
            
        }
    }
}
