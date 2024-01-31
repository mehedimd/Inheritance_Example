using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    internal class Employee : Person
    {
        int EmployeeId {  get; set; }
        public Employee(int id, string nameBase, int ageBase) : base(nameBase,ageBase)
        {
            this.EmployeeId = id;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}, Age: {Age}, ID: {EmployeeId}");
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(1280692,"Md.Mehedi Hasan",22);
            e.DisplayInfo();

            Console.ReadKey();
        }
    }
}
