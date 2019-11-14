using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class Address
    {
        public string street { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string district { get; set; }
        public string zip { get; set; }
        public int street_type { get; set; }
        public int city_id { get; set; }
    }
}
