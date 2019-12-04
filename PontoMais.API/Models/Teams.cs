using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class Teams
    {
        public List<Team> teams { get; set; }
        public MetaData meta { get; set; }
    }

    public class CoverPicture
    {
        public string url { get; set; }
        public string small_url { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public BusinessUnit business_unit { get; set; }
        public Department department { get; set; }
        public string observation { get; set; }
        public CoverPicture cover_picture { get; set; }
        public List<object> leader_ids { get; set; }
        public List<object> leaders { get; set; }
        public ClientPreference client_preference { get; set; }
        public int employees_count { get; set; }
    }
}
