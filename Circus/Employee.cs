using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    abstract class Employee
    {
        protected string eName;
        protected int eAge;
        protected float eSalary;

        public string Name { get => eName; set => eName = value; }
        public int Age { get => eAge; set => eAge = value; }
        public float Salary { get => eSalary; set => eSalary = value; }

        ~Employee()
        {

        }

        public Employee()
        {

        }
        public Employee(string _eName, int _eAge, float _eSalary)
        {
            eName = _eName;
            eAge = _eAge;
            eSalary = _eSalary;
        }
        public abstract void InputEmployee();
        public abstract void OutputEmployee();
        public abstract float ComputeSalary();

        public static Employee operator +(Employee Emp, int AddSalary)
        {
            Emp.eSalary += AddSalary;
            return Emp;
        }
        public static Employee operator -(Employee Emp, int MinusSalary)
        {
            Emp.eSalary -= MinusSalary;
            return Emp;
        }
        public static Employee operator *(Employee Emp, int MultiSalary)
        {
            Emp.eSalary *= MultiSalary;
            return Emp;
        }
        public static Employee operator /(Employee Emp, int DevideSalary)
        {
            Emp.eSalary /= DevideSalary;
            return Emp;
        }
        public static bool operator ==(Employee Emp1, Employee Emp2)
        {
            return Emp1.eSalary == Emp2.eSalary;
        }
        public static bool operator !=(Employee Emp1, Employee Emp2)
        {
            return Emp1.eSalary != Emp2.eSalary;
        }
        public static bool operator >(Employee Emp1, Employee Emp2)
        {
            return Emp1.eSalary > Emp2.eSalary;
        }
        public static bool operator <(Employee Emp1, Employee Emp2)
        {
            return Emp1.eSalary < Emp2.eSalary;
        }
        public static Employee operator ++(Employee Emp)
        {
            Emp.eSalary += 5 / 100 * Emp.eSalary;
            return Emp;
        }
        public static Employee operator --(Employee Emp)
        {
            Emp.eSalary -= 5 / 100 * Emp.eSalary;
            if (Emp.eSalary < 0) Emp.eSalary = 0;
            return Emp;
        }
    }
}
