using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class Cleaner:Employee
    {
        int eWorkingHour;
        public int Workinghour { get => eWorkingHour; set => eWorkingHour = value; }
        ~Cleaner()
        {

        }
        public Cleaner()
        {

        }
        public Cleaner(string _Name, int _Age, float _Salary, int _WorkingHour) : base(_Name, _Age, _Salary)
        {
            eWorkingHour = _WorkingHour;
        }
        public override void InputEmployee()
        {
            Console.WriteLine("Input name of Cleaner:");
            eName = Console.ReadLine();
            Console.WriteLine("Input cleaner's Age:");
            eAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input cleaner's  salary");
            eSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Working time:");
            eWorkingHour = int.Parse(Console.ReadLine());
        }
        public override void OutputEmployee()
        {
            Console.WriteLine("Cleaner's name: " + this.Name);
            Console.WriteLine("Cleaner's Age: " + this.Age);
            Console.WriteLine("Cleaner's  salary: " + this.Salary);
        }
        public override float ComputeSalary()
        {
            return Convert.ToInt32(Salary * eWorkingHour);
        }
    }
}
