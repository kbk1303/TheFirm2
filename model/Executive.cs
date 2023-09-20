using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal abstract class Executive : Employee
    {
        protected Officer[] officers = new Officer[2];
        protected Car car = new Car();
        protected double? dividend;
        private HR hr = new HR();
        private Adm adm = new Adm();

        protected double? Dividend
        {
            get { return dividend; }
        }

        protected Executive(double salary, ESex gender) : base(salary, gender)
        {
            officers[0] = new COO(76000, ESex.Male);
            officers[1] = new CFO(87000, ESex.Male);
        }
    }
}
