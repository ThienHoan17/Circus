using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class Clown:Employee
    {
        int NumOfAct;
        public int Numofaction { get => NumOfAct; set => NumOfAct = value; }
        ~Clown()
        {

        }
        public Clown()
        {

        }
        public Clown(string _eName, int _eAge, float _eSalary, int _NumOfAct) : base(_eName, _eAge, _eSalary)
        {
            NumOfAct = _NumOfAct;
        }
        public override void InputEmployee()
        {
            Console.WriteLine("Input name of clown:");
            Name = Console.ReadLine();
            Console.WriteLine("Input clown Age:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Input clown's  salary");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Number of act Will be present:");
            NumOfAct = int.Parse(Console.ReadLine());
        }
        public override void OutputEmployee()
        {
            Console.WriteLine("Clown's name: " + this.Name);
            Console.WriteLine("Clown's Age: " + this.Age);
            Console.WriteLine("Clown's  salary: " + this.Salary);
        }
        public override float ComputeSalary()
        {
            return Convert.ToInt32(Salary + (NumOfAct / 100) * Salary);
        }
    }
}
