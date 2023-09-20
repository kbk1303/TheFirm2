using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal abstract class Worker: Employee
    {
        protected string department;

        public override abstract int GetSalary { get; }

        protected string Department
        {
            get { return department; }
        }

        protected Worker(double salary, string department, ESex gender): base(salary, gender) 
        {
            this.department = department;
        }

        public override abstract string Print();

    }
}
