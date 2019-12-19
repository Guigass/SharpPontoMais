using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class CostsCenters
    {
        public List<CostCenter> cost_centers { get; set; }
        public MetaData meta { get; set; }
    }

    public class CostCenter
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }
}
