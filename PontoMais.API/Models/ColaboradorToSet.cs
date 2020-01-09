using Newtonsoft.Json;
using PontoMais.API.Enums;
using PontoMais.API.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class ColaboradorToSet
    {
        public EmployeeToSet employee { get; set; }
    }

    public class EmployeeToSet
    {
        public string registration_number { get; set; }
        public string name { get; set; }
        public string cpf { get; set; }
        public bool is_clt { get; set; }
        public string nis { get; set; }
        public int team_id { get; set; }
        public int cost_center_id { get; set; }
        public int job_title_id { get; set; }
        public int shift_id { get; set; }
        public string email { get; set; }
        public bool has_time_cards { get; set; }
        public int time_card_source { get; set; }
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime admission_date { get; set; }
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime initial_date { get; set; }
        public string picture { get; set; }
        public int group_id { get; set; }
        public string password { get; set; }
    }
}
