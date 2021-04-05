using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Classes
{
    public class Car
    {
        public string Model { get; set; }

        private int Speed { get; set; }

        public Driver Driver{ get; set; }


        public Car()
        {
            Speed = TopSpeed();
        }

        private int TopSpeed()
        {
            int speed = new Random().Next(100, 200);
            return speed;
        }

        public int CalculateSpeed()
        {
            int result = Driver.Skill * Speed;
            return result;

        }
    }
}
