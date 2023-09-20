using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm2.model.interfaces;

namespace TheFirm2.model
{
    internal abstract class Employee : IEmployee
    {
        protected double salary;
        protected ESex gender;

        protected double Salary
        {
            get {  return salary; } 
        }

        public abstract int GetSalary { get; }

        protected Employee(double salary, ESex gender) 
        {
            this.salary = salary;
            this.gender = gender;
        }

        public abstract string Print();

        public ESex GetEmployeeGender()
        {
            return gender;
        }

        //public abstract string Print();
    }
}
