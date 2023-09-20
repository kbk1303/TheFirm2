using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.model.interfaces
{
    internal interface IEmployee
    {
        string Print();
        int GetSalary { get; }

        ESex GetEmployeeGender();
    }
}
