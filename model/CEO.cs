using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal class CEO : Executive
    {
        public CEO(double salary, ESex gender) : base(salary, gender)
        {
        }

        public override int GetSalary => (int) salary;

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
