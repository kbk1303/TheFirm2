using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal class Manager : Employee
    {
        protected List<Worker>? workers;

        protected List<Worker>? Workers
        {
            get { return workers; }
            set { workers = value; }
        }

        protected virtual double MonthlyBonus
        {
            get; set;
        }

        public override int GetSalary => (int)salary;

        internal Manager(double salary, List<Worker>? workers, ESex gender) : base(salary, gender)
        {
            this.workers = workers ?? new List<Worker>();
        }

        public override string Print()
        {
            return "I'm just an Manager class";
        }
    }
}
