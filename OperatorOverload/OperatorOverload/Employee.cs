using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Employee
    {
        public List<Employee> Employees { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if ((object)employee1 == null)
                return (object)employee2 == null;
            return employee1.Equals(employee2);
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    if (employee1.Id == employee2.Id)
        //        return employee1.Id == employee2.Id;
        //    else
        //        return employee1.Id != employee2.Id;
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return employee1.Id != employee2.Id;
        //}


        public override bool Equals(Object obj)
        {
            var employee = obj as Employee;

            if (employee == null)
                return false;

            return this.Id.Equals(employee.Id);
        }
    }
}
