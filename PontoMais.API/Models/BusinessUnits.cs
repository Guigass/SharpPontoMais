using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class BusinessUnits
    {
        public List<BusinessUnit> business_units { get; set; }
        public MetaData meta { get; set; }
    }

    public class PersonType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class CoopType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class JuridicalNature
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class AddressType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class StreetType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
    }

    public class State
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Country
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Address
    {
        public string street { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string district { get; set; }
        public string zip { get; set; }
        public AddressType address_type { get; set; }
        public StreetType street_type { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
    }

    public class Brand
    {
        public string url { get; set; }
        public string small_url { get; set; }
    }

    public class Timezone
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ClientPreference
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class BusinessUnit
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public object cpf { get; set; }
        public string cnpj { get; set; }
        public string cei { get; set; }
        public string state_inscription { get; set; }
        public string corporate_name { get; set; }
        public bool is_employer { get; set; }
        public bool is_construction { get; set; }
        public PersonType person_type { get; set; }
        public CoopType coop_type { get; set; }
        public object tax_classification { get; set; }
        public JuridicalNature juridical_nature { get; set; }
        public string phone { get; set; }
        public Address address { get; set; }
        public string observation { get; set; }
        public Brand brand { get; set; }
        public Timezone timezone { get; set; }
        public ClientPreference client_preference { get; set; }
        public int employees_count { get; set; }
    }
}
