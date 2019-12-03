using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Helpers
{
    public class JsonDateTimeConverter : IsoDateTimeConverter
    {
        public JsonDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
