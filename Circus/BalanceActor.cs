using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class BalanceActor:Employee
    {
        float eHeighOfRope;
        float eLengthOfRope;
        public float Heigt { get => eHeighOfRope; set => eHeighOfRope = value; }
        public float Length { get => eLengthOfRope; set => eLengthOfRope = value; }
         ~BalanceActor()
        {

        }
        public BalanceActor()
        {

        }
        public BalanceActor(string _eName, int _eAge, float _eSalary, float _eHeightOfRope, float _eLengthhOfRope) : base(_eName, _eAge, _eSalary)
        {
            eHeighOfRope = _eHeightOfRope;
            eLengthOfRope = _eLengthhOfRope;
        }
        public override void InputEmployee()
        {
            Console.WriteLine("Input name of Balance Actor:");
            eName = Console.ReadLine();
            Console.WriteLine("Input Actor's Age:");
            eAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Actor's  salary");
            eSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the height of the rope:");
            eHeighOfRope = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Length of rope:");
            eLengthOfRope = int.Parse(Console.ReadLine());
        }
        public override void OutputEmployee()
        {
            Console.WriteLine("Balance Actor's name: " + this.Name);
            Console.WriteLine("Balance Actor's Age: " + this.Age);
            Console.WriteLine("Balance Actor's  salary: " + this.Salary);
        }
        public override float ComputeSalary()
        {
            return Convert.ToInt32(Salary + (Math.Sqrt((eHeighOfRope * eHeighOfRope) + (eLengthOfRope * eLengthOfRope)) / 100));
        }
    }
}
