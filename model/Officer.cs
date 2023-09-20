using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model
{
    internal abstract class Officer : Employee
    {

        protected List<Chief> chiefList = new List<Chief>();
        protected Car? car;

        protected Car? Car
        {
            get { return car; }
        }

        protected Officer(double salary, ESex gender) : base(salary, gender)
        {
        }
    }
}
