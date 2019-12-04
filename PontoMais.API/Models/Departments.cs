using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class Departments
    {
        public List<Department> departments { get; set; }
        public MetaData meta { get; set; }
    }

    public class Department
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string observation { get; set; }
        public BusinessUnit business_unit { get; set; }
        public int employees_count { get; set; }
    }
}
