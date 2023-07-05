using System;
using System.Collections.Generic;
using System.IO;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JSON_To_CS();

            CS_To_JSON();
           
        }
        static Customer JSON_To_CS() 
        {
            string filePath = @"C:\\Users\\91951\\source\\repos\\JSON\\JSON\\customerEmployee.json";
            if(File.Exists(filePath))
            {
                string justText = File.ReadAllText(filePath);
                Customer c = Newtonsoft.Json.JsonConvert.DeserializeObject<Customer>(justText); 
                return c;
            }
            return null;
        }
        static void CS_To_JSON()
        {
            var c = CreatCustomer_1();

            var jsonFormattedContent = Newtonsoft.Json.JsonConvert.SerializeObject(c);

            string filePath = @"C:\Users\91951\source\repos\JSON\JSON\New.json";
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, jsonFormattedContent);
            }
            else
            {
                File.Delete(filePath);
            }
        }
        static Customer CreatCustomer_1()
        {
            var c = new Customer();
            c.customer_id = "101";
            c.customer_name = "aaaa";
            c.employees = new List<Employee>();

            var a = new Employee();
            a.first_name = "Afirst";
            a.last_name = "Alast";
            a.phone = "9898989898";
            c.employees.Add(a);

            var b = new Employee();
            b.first_name = "Bfirst";
            b.last_name = "Blast";
            b.phone = "9898989888";
            c.employees.Add(b);

            return c;
        }
    }
}
