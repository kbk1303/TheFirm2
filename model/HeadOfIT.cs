using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal class HeadOfIT : Chief
    {
        public override int GetSalary => (int) salary;

        internal HeadOfIT(double salary, ESex gender) : base(salary, gender)
        {
            managers.Add(new ITManager(25000, new List<Worker> { new ITWorker(19876, "IT", ESex.Male) }, ESex.Female));
            YearlyBonus = 100000;
        }


        public List<Manager> MyITManagers()
        {
            return managers.Where(m => m is ITManager).ToList();
        }

        public override string Print()
        {
            return $"I am Head of IT, yes!";
        }
    }
}
