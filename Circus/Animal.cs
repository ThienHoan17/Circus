using System;
using System.Collections.Generic;
using System.Text;

namespace Circus
{
    abstract class Animal
    {
        protected string aSpecies;
        protected int aAge;
        protected int aFoodPerDay;
        protected int aPerformentTime;
        
        public string Species { get => aSpecies; set => aSpecies = value; }
        public int Age { get => aAge; set => aAge = value; }
        public int Foodperday { get => aFoodPerDay; set => aFoodPerDay = value; }

        ~Animal()
        {

        }
        public Animal()
        {

        }
        public Animal(string _aSpecies, int _aAge, int _aFoodPerDay)
        {
            aSpecies = _aSpecies;
            aAge = _aAge;
            aFoodPerDay = _aFoodPerDay;
        }
        public abstract void InputAnimal();
        public abstract void OutputAnimal();
        public abstract int FoodWeight();
        public static Animal operator +(Animal Ani, int AddFood)
        {
            Ani.aFoodPerDay += AddFood;
            return Ani;
        }
        public static Animal operator -(Animal Ani, int MinusFood)
        {
            Ani.aFoodPerDay -= MinusFood;
            return Ani;
        }
        public static Animal operator *(Animal Ani, int MultiFood)
        {
            Ani.aFoodPerDay *= MultiFood;
            return Ani;
        }
        public static Animal operator /(Animal Ani, int DevideFood)
        {
            Ani.aFoodPerDay /= DevideFood;
            return Ani;
        }
        public static bool operator ==(Animal Ani1, Animal Ani2)
        {
            return Ani1.aFoodPerDay == Ani2.aFoodPerDay;
        }
        public static bool operator !=(Animal Ani1, Animal Ani2)
        {
            return Ani1.aFoodPerDay != Ani2.aFoodPerDay;
        }
        public static bool operator >(Animal Ani1, Animal Ani2)
        {
            return Ani1.aFoodPerDay > Ani2.aFoodPerDay;
        }
        public static bool operator <(Animal Ani1, Animal Ani2)
        {
            return Ani1.aFoodPerDay < Ani2.aFoodPerDay;
        }
        public static Animal operator ++(Animal Ani)
        {
            Ani.aFoodPerDay += 100;
            return Ani;
        }
        public static Animal operator --(Animal Ani)
        {
            Ani.aFoodPerDay -= 100;
            if (Ani.aFoodPerDay < 0) Ani.aFoodPerDay = 0;
            return Ani;
        }
    }
}
