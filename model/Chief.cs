using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal abstract class Chief : Employee
    {
        protected List<Manager> managers = new List<Manager>();
        protected double yearlyBonus;

        protected double YearlyBonus;

        protected Chief(double salary, ESex gender) : base(salary, gender)
        {
        }

        public override abstract string Print();

        public void Addmanager(Manager manager)
        {
            managers.Add(manager);
        }
    }
}
