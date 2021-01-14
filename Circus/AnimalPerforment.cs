using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    class AnimalPerforment:Animal
    {
        int aPerformentTime;
        public int PerformentTime { get => aPerformentTime; set => aPerformentTime = value; }

        ~AnimalPerforment()
        {

        }
        public AnimalPerforment()
        {

        }
        public AnimalPerforment(string _aSpecies, int _aAge, int _aFoodPerDay, int _aPerformentTime) : base(_aSpecies, _aAge, _aFoodPerDay)
        {
            aPerformentTime = _aPerformentTime;
        }
        public override void InputAnimal()
        {
            Console.WriteLine("Input the type of animal:");
            aSpecies = Console.ReadLine();
            Console.WriteLine("Input animal Age:");
            aAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the amout of food for " + this.aSpecies + " per day");
            aFoodPerDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Input performing time of " + this.aSpecies + " :");
            aPerformentTime = int.Parse(Console.ReadLine());
        }
        public override void OutputAnimal()
        {
            Console.WriteLine("Animal's species: " + this.aSpecies);
            Console.WriteLine("Animal's Age: " + this.aAge);
            Console.WriteLine("Animal's performing time: " + this.aPerformentTime);
        }
        public override int FoodWeight()
        {
            return aFoodPerDay + aPerformentTime / 10 * 100;
        }
    }
    
}
