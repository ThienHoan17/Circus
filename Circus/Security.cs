using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class Security:Employee
    {
        int eWorkingHour;
        public int Workinghour { get => eWorkingHour; set => eWorkingHour = value; }
        ~Security()
        {

        }
        public Security()
        {

        }
        public Security(string _eName, int _eAge, float _eSalary, int _eWorkingHour) : base(_eName, _eAge, _eSalary)
        {
            eWorkingHour = _eWorkingHour;
        }
        public override void InputEmployee()
        {
            Console.WriteLine("Input name of Security:");
            eName = Console.ReadLine();
            Console.WriteLine("Input security's Age:");
            eAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input security's  salary");
            eSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Working time:");
            eWorkingHour = int.Parse(Console.ReadLine());
        }
        public override void OutputEmployee()
        {
            Console.WriteLine("Security's name: " + this.Name);
            Console.WriteLine("Security's Age: " + this.Age);
            Console.WriteLine("Security's  salary: " + this.Salary);
        }
        public override float ComputeSalary()
        {
            return Convert.ToInt32(Salary * eWorkingHour);
        }
    }
}
