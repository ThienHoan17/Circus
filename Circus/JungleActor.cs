using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class JungleActor:Employee
    {
        int NumOfObject;
        public int NumofObject { get => NumOfObject; set => NumOfObject = value; }
        ~JungleActor()
        {

        }
        public JungleActor()
        {

        }
        public JungleActor(string _eName, int _eAge, float _eSalary, int _NumOfObject) : base(_eName, _eAge, _eSalary)
        {
            NumOfObject = _NumOfObject;
        }
        public override void InputEmployee()
        {
            Console.WriteLine("Input name of Jungle Actor:");
            eName = Console.ReadLine();
            Console.WriteLine("Input Actor's Age:");
            eAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Actor's  salary");
            eSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Number of object Will be present:");
            NumOfObject = int.Parse(Console.ReadLine());
        }
        public override void OutputEmployee()
        {
            Console.WriteLine("Jungle Actor's name: " + this.Name);
            Console.WriteLine("Jungle Actor's Age: " + this.Age);
            Console.WriteLine("Jungle Actor's  salary: " + this.Salary);
        }
        public override float ComputeSalary()
        {
            return Convert.ToInt32(Salary + (NumOfObject / 100) * Salary);
        }
    }
}
