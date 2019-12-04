using Newtonsoft.Json;
using PontoMais.API.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public partial class Reports
    {
        public Heading heading { get; set; }
        public List<List<ReportsDatum>> data { get; set; }
        public MetaData meta { get; set; }
    }

    public partial class ReportsDatum
    {
        public Dictionary<string, Header> header { get; set; }
        public List<DatumDatum> data { get; set; }
        public object footer { get; set; }
        public List<Total> totals { get; set; }
    }

    public partial class DatumDatum
    {
        public string employee_name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string pis { get; set; }
        public double? registration_number { get; set; }
        public string job_title_name { get; set; }
        public string team_name { get; set; }
        public string shift_name { get; set; }
        public string source { get; set; }
        public string original_address { get; set; }
        public string edited_address { get; set; }
        public string manually_changed { get; set; }
        public string motive { get; set; }
        public string updated_by { get; set; }
        public string image { get; set; }
        public string ip { get; set; }
        public string time_card_index { get; set; }
        public string software_method { get; set; }
        public string local_date_time { get; set; }
        public double? accuracy { get; set; }
        public string geolocation { get; set; }
        public string original_geolocation { get; set; }
    }

    public partial class Header
    {
        public string title { get; set; }
    }

    public partial class Total
    {
        public string title { get; set; }
        public long total { get; set; }
    }

    public partial class Heading
    {
        public string title { get; set; }
        public string created_by_name { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string today { get; set; }
    }
}
