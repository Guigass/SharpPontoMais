using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class Picture
    {
        public string url { get; set; }
        public string medium_url { get; set; }
        public string small_url { get; set; }
    }

    public class TimeCardSource
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public bool active { get; set; }
        public bool admin { get; set; }
        public DateTime confirmed_at { get; set; }
        public Group group { get; set; }
    }

    public class WorkStatus
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class EnableGeolocation
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class EnableOfflineTimeCards
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class FlexibleInterval
    {
        public bool separate_totals { get; set; }
    }

    public class Flexible
    {
        public bool interval_extra_time_enabled { get; set; }
    }

    public class MteAllowance
    {
        public bool cumulative { get; set; }
        public bool compensatory { get; set; }
    }

    public class Factors
    {
    }

    public class CompensatoryTimeOff
    {
        public bool enabled { get; set; }
        public bool allowance { get; set; }
        public string start_date { get; set; }
        public double multiply_factor_50_percent { get; set; }
        public double multiply_factor_100_percent { get; set; }
        public int expiration { get; set; }
        public bool middle_phases_extra_time { get; set; }
        public bool ignore_missing_days_from_time_balance { get; set; }
        public string limit { get; set; }
        public bool cumulative_time_balance { get; set; }
        public Factors factors { get; set; }
    }

    public class CustomExtraTime
    {
        public bool enabled { get; set; }
        public int first_phase_percent { get; set; }
        public int second_phase_percent { get; set; }
    }

    public class Overnight
    {
        public bool enabled { get; set; }
        public bool interval_enabled { get; set; }
        public bool extended { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }

    public class GlobalNotifications
    {
        public bool missing_interval_time { get; set; }
        public string before_time_card_time { get; set; }
        public string missing_rest_time { get; set; }
        public string work_day_extra_time { get; set; }
        public string work_day_summary_dispatch_time { get; set; }
    }

    public class Dsr
    {
        public bool enabled { get; set; }
        public bool miss_holiday { get; set; }
        public bool missing_time_exceeded { get; set; }
        public string missing_time_limit { get; set; }
    }

    public class ClientPreferenceData
    {
        public bool use_qrcode_pin { get; set; }
        public bool geolocation_enabled { get; set; }
        public bool offline_time_cards_enabled { get; set; }
        public bool extra_time_justifications_enabled { get; set; }
        public bool messages_enabled { get; set; }
        public int time_card_allowance { get; set; }
        public bool time_card_allowance_interval_enabled { get; set; }
        public bool solicitation_attachments_enabled { get; set; }
        public bool solicitation_attachments_edit { get; set; }
        public bool dsr_enabled { get; set; }
        public bool time_card_local_time_enabled { get; set; }
        public bool can_team_leader_edit_own_work_day { get; set; }
        public bool team_leader_can_edit_own_subordinates_only { get; set; }
        public bool apply_strong_password_policy { get; set; }
        public int timezone { get; set; }
        public FlexibleInterval flexible_interval { get; set; }
        public Flexible flexible { get; set; }
        public MteAllowance mte_allowance { get; set; }
        public CompensatoryTimeOff compensatory_time_off { get; set; }
        public CustomExtraTime custom_extra_time { get; set; }
        public Overnight overnight { get; set; }
        public GlobalNotifications global_notifications { get; set; }
        public Dsr dsr { get; set; }
    }

    public class FieldOccupation
    {
        public int id { get; set; }
        public string name { get; set; }
        public object deleted_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public object deleted_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object employees_quantity { get; set; }
        public int status { get; set; }
        public string corporate_name { get; set; }
        public string cnpj { get; set; }
        public object state_inscription { get; set; }
        public string phone { get; set; }
        public int address_id { get; set; }
        public string super_logica_reference { get; set; }
        public string time_clocks_token { get; set; }
        public int super_logica_plan { get; set; }
        public string agent_code { get; set; }
        public string plan_signed_at { get; set; }
        public int plan { get; set; }
        public int signup_version { get; set; }
        public object delete_method { get; set; }
        public int trial_extend { get; set; }
        public object employees_limit { get; set; }
        public bool suspended { get; set; }
        public int payment_method { get; set; }
        public object credit_card_banner { get; set; }
        public object credit_card_mask { get; set; }
        public object access_limit { get; set; }
        public FieldOccupation field_occupation { get; set; }
        public object first_plan_signed_at { get; set; }
        public int billing_data_id { get; set; }
        public string billing_agent_code { get; set; }
        public string billing_corporate_name { get; set; }
        public string billing_cnpj { get; set; }
        public string billing_name { get; set; }
        public string billing_phone { get; set; }
        public object billing_state_inscription { get; set; }
        public string billing_email { get; set; }
        public int field_occupation_id { get; set; }
        public object other_field_occupation { get; set; }
        public bool overdue_payment { get; set; }
    }

    public class ClientRootUser
    {
        public string email { get; set; }
    }

    public class Employee
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object registration_number { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nis { get; set; }
        public string cpf { get; set; }
        public object birthdate { get; set; }
        public string email { get; set; }
        public object main_phone_number { get; set; }
        public Picture picture { get; set; }
        public bool is_clt { get; set; }
        public string qrcode { get; set; }
        public bool is_retired { get; set; }
        public bool has_time_cards { get; set; }
        public TimeCardSource time_card_source { get; set; }
        public object gender { get; set; }
        public object race { get; set; }
        public object marital_status { get; set; }
        public object instruction_level { get; set; }
        public object mothers_name { get; set; }
        public object fathers_name { get; set; }
        public object alternative_phone_number { get; set; }
        public object alternative_email { get; set; }
        public object birth_city { get; set; }
        public object birth_state { get; set; }
        public object birth_country { get; set; }
        public bool is_foreign { get; set; }
        public object foreign_arrival_date { get; set; }
        public object foreign_visa_type { get; set; }
        public bool foreign_is_married_brazilian { get; set; }
        public bool foreign_has_brazilian_children { get; set; }
        public bool is_physical_disabled { get; set; }
        public bool is_blind { get; set; }
        public bool is_deaf { get; set; }
        public bool is_mental_disabled { get; set; }
        public bool is_poor_intellectual { get; set; }
        public bool is_rehabilitated { get; set; }
        public object disabilities_observation { get; set; }
        public object observation { get; set; }
        public Team team { get; set; }
        public Department department { get; set; }
        public BusinessUnit business_unit { get; set; }
        public Shift shift { get; set; }
        public JobTitle job_title { get; set; }
        public CostCenter cost_center { get; set; }
        public User user { get; set; }
        public object address { get; set; }
        public object foreign_address { get; set; }
        public WorkStatus work_status { get; set; }
        public object work_status_time_card { get; set; }
        public double time_balance { get; set; }
        public List<object> employee_closings { get; set; }
        public string admission_date { get; set; }
        public object work_hours { get; set; }
        public string pin { get; set; }
        public bool use_qrcode { get; set; }
        public bool use_face_detection { get; set; }
        public int time_offset { get; set; }
        public bool daylight_saving_time { get; set; }
        public int timezone { get; set; }
        public List<object> location_references { get; set; }
        public EnableGeolocation enable_geolocation { get; set; }
        public EnableOfflineTimeCards enable_offline_time_cards { get; set; }
        public bool geolocation_enabled { get; set; }
        public object last_synchronization { get; set; }
        public object face_id { get; set; }
        public ClientPreference client_preference { get; set; }
        public ClientPreferenceData client_preference_data { get; set; }
        public Client client { get; set; }
        public ClientRootUser client_root_user { get; set; }
        public bool active { get; set; }
        public string initial_date { get; set; }
        public bool is_team_leader { get; set; }
    }

    public class Employees
    {
        public Employee employee { get; set; }
        public MetaData meta { get; set; }
    }
}
