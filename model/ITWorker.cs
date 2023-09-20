using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal class ITWorker : Worker
    {
        public override int GetSalary => (int)salary;

        internal ITWorker(double salary, string department, ESex gender) : base(salary, department, gender)
        {
        }

        public override string Print()
        {
            return "I am an ITWorker class, yay";
        }

        public double MySalary()
        {
            return Salary; // base.Salary;
        }
    }


}
