
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee>  GetAllEmployees() 
        {
            List<Employee> employees = new List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "mike";
            employees1.Name = "麥克";
            employees1.Age = 100;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "andy";
            employees2.Name = "安迪";
            employees2.Age = 10;
            employees.Add(employees2);

            return  employees;
        
        }

        public Employee GetEmployeeById(string id) 
        {
            Employee employees = new Employee();
            employees.Id = "andy";
            employees.Name = "安迪";
            employees.Age = 10;

            return employees;
        }
    }
}
