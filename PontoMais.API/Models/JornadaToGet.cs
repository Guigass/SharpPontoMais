using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class JornadaToGet
    {
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string group_by { get; set; } = "employee";
        public string row_filters { get; set; } = "has_time_cards";
        public string columns { get; set; } = "date,shift_name,shift_appointments,time_cards,summary,extra_time,total_time,shift_time,custom_interval_time,overnight_time,registration_number,time_balance,motive, employee_id";
        public string format { get; set; }
        public int business_unit_id { get; set; }
        public int team_id { get; set; }
        public int employee_id { get; set; }
        public int cost_center_id { get; set; }
        public int status_id { get; set; }
    }
}
