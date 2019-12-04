using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class Shifts
    {
        public List<Shift> shifts { get; set; }
        public MetaData meta { get; set; }
    }

    public class WeekDay
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Day
    {
        public int id { get; set; }
        public string day_change_time { get; set; }
        public string extra_time_50_percent { get; set; }
        public bool is_holiday { get; set; }
        public WeekDay week_day { get; set; }
        public int week_index { get; set; }
        public List<object> periods { get; set; }
    }

    public class Shift
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public List<Day> days { get; set; }
        public object holiday { get; set; }
        public int shift_type { get; set; }
        public bool without_holidays { get; set; }
        public bool advanced { get; set; }
        public object advanced_preference { get; set; }
        public bool flexible { get; set; }
        public bool flexible_allowance { get; set; }
        public bool flexible_interval { get; set; }
        public int custom_interval_type { get; set; }
        public bool custom_interval_extra_time_enabled { get; set; }
        public object default_dsr { get; set; }
        public bool auto_interval { get; set; }
        public bool cumulative_extra_time { get; set; }
        public object cumulative_preference { get; set; }
        public bool apply_holiday_on_days_off { get; set; }
        public bool count_only_extra_time_on_holidays { get; set; }
        public int limit_type { get; set; }
        public object limit_amount { get; set; }
        public object limit_range { get; set; }
    }
}
