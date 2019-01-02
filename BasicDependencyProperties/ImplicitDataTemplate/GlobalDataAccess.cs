using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplicitDataTemplate
{
    public class GlobalDataAccess
    {
        public static List<Employee> GetEmployees(string id=null)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("123-abc","Mirza Ghulam","Rasyid","Developer",DateTime.Now),
                new Employee("123-def","Rara","Anjani","Developer",DateTime.Now),
                new Employee("456-jkl","Beggi","Mammad","Developer",DateTime.Now),
                new Employee("982-iop","Michael","Hawk","Developer",DateTime.Now),
                new Employee("900-rtt","Jason","Statham","Developer",DateTime.Now),
            };
            if (id == null )
                return employees;
            return employees.Where(x => x.Id.ToString().Equals(id.ToString())).ToList();
        }
    }
}
