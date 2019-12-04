using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class PontoMaisResponse
    {
        public string success { get; set; }
        public MetaData meta { get; set; }
        public int? id { get; set; }
        public int? status { get; set; }
    }
}
