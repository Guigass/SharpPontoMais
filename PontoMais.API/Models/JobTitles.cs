using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class JobTitles
    {
        public List<JobTitle> job_titles { get; set; }
        public MetaData meta { get; set; }
    }

    public class JobTitle
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string female_name { get; set; }
        public object cbo { get; set; }
    }
}
