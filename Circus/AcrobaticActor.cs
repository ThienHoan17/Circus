using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class AcrobaticActor:Employee
    {
        int NumOfAction;
        public int Numofaction { get => NumOfAction; set => NumOfAction = value; }
        ~AcrobaticActor()
        {

        }
        public AcrobaticActor()
        {

        }
        public AcrobaticActor(string _eName, int _eAge, float _eSalary, int _NumOfAction) : base(_eName, _eAge, _eSalary)
        {
            NumOfAction = _NumOfAction;
        }
        public override void InputEmployee()
        {
            Console.WriteLine("Input name of Acrobatic Actor:");
            eName = Console.ReadLine();
            Console.WriteLine("Input Actor's Age:");
            eAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Actor's  salary");
            eSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Number of action Will be present:");
            NumOfAction = int.Parse(Console.ReadLine());
        }
        public override void OutputEmployee()
        {
            Console.WriteLine("Acrobatic Actor's name: " + this.Name);
            Console.WriteLine("Acrobatic Actor's Age: " + this.Age);
            Console.WriteLine("Acrobatic Actor's  salary: " + this.Salary);
        }
        public override float ComputeSalary()
        {
            return Convert.ToInt32(Salary + (NumOfAction / 100) * Salary);
        }
    }
}
