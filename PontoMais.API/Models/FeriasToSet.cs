using Newtonsoft.Json;
using PontoMais.API.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class FeriasToSet
    {
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime start_date { get; set; }
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime end_date { get; set; }
        public string observation { get; set; }
    }
}
