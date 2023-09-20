using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal class ITManager : Manager
    {

        internal ITManager(double salary, List<Worker>? workers, ESex gender) : base(salary, workers, gender)
        {
        }

        protected override double MonthlyBonus
        {
            get { return base.MonthlyBonus; }
            set {base.MonthlyBonus = 30.000; }
        }

        public override string Print()
        {
            return "I'm an ITManager class, yay!";
        }

        public List<Worker>? MyITWorkers()
        {
            return  workers?.Where(w => w is ITWorker).ToList();
        }
    }

}
