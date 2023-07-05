using System;
using System.Collections.Generic;
using System.Text;

namespace JSON
{
    public class Customer
    {
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public List<Employee> employees { get; set; }
    }
    public class Employee
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
    }
    
}
