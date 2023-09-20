using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal class CFO : Officer
    {
        internal CFO(double salary, ESex gender) : base(salary, gender)
        {
        }

        public override int GetSalary => (int) salary;

        public override string Print()
        {
            return $"I am CFO, Obey!";
        }
    }

}
