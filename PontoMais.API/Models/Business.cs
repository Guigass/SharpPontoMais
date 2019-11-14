using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class Business
    {
        public int person_type { get; set; }
        public string code { get; set; }
        public string observation { get; set; }
        public string name { get; set; }
        public string cnpj { get; set; }
        public string state_inscription { get; set; }
        public string corporate_name { get; set; }
        public bool is_construction { get; set; }
        public bool is_employer { get; set; }
        public string phone { get; set; }
    }
}
