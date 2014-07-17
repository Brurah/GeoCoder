using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GeoCodder.Classes;
using System.ServiceModel.Web;

namespace GeoCodder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGeoLoc" in both code and config file together.
    [ServiceContract]
    public interface IGeoLoc
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/locTotem?endereco={end}")]
        List<RetornoLocalizacaoTotem> GetLocTotemSvc(string end);
    }
}
