using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public List<string> Employees { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        /////
        ///// OPERATOR OVERLOAD
        /////
        ///One way
        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    if ((object)employee1 == null)
        //        return (object)employee2 == null;
        //    return employee1.Equals(employee2);
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return !(employee1 == employee2);
        //}

        //public override bool Equals(Object obj)
        //{
        //    var employee = obj as Employee;

        //    if (employee == null)
        //        return false;

        //    return this.Id.Equals(employee.Id);
        //}

        ///Another way
        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    return (employee1.Id == employee2.Id)
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return (employee1.Id != employee2.Id);
        //}




        /////
        ///// /OPERATOR OVERLOAD
        /////
    }
}
