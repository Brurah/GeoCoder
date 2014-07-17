using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoCodder.Classes
{
    public class RetornoLocalizacaoTotem
    {
        public string Endereco { get; set; }
        public string EnderecoCompleto { get; set; }
        public string CodigoNo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}