using System;
using Task01.Classes;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = Race();
            while (answer == "Y" || answer == "y")
            {
                answer = Race();
            }
            
        }


        public static void AddDriverToCar(string driverName, string carName, List<Car> carList, List<Driver> driverList)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                if (carList[i].Model == carName)
                {
                    for (int j = 0; j < driverList.Count; j++)
                    {
                        if (driverList[j].Name == driverName)
                        {
                            carList[i].Driver = driverList[j];
                        }
                    }
                }
            }
        }

        public static string RaceCars(Car car1, Car car2)
        {
            if(car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                return $"{car1.Model} won with the max speed of {car1.CalculateSpeed()} and {car1.Driver.Name} was driving!";
            }
            else
            {
                return $"{car2.Model} won with the max speed of {car2.CalculateSpeed()} and {car2.Driver.Name} was driving!";
            }
        }

        public static string Race()
        {
            Driver Bob = new Driver("Bob", 3);
            Driver Greg = new Driver("Greg", 2);
            Driver Jill = new Driver("Jill", 1);
            Driver Anne = new Driver("Anne", 3);

            var driverList = new List<Driver>();
            driverList.Add(Bob);
            driverList.Add(Greg);
            driverList.Add(Jill);
            driverList.Add(Anne);

            Car hyundai = new Car();
            hyundai.Model = "Hyundai";
            Car mazda = new Car();
            mazda.Model = "Mazda";
            Car ferrari = new Car();
            ferrari.Model = "Ferrari";
            Car porsche = new Car();
            porsche.Model = "Porsche";

            var carList = new List<Car>();
            carList.Add(hyundai);
            carList.Add(mazda);
            carList.Add(ferrari);
            carList.Add(porsche);


            Console.WriteLine("Write the name of the first car:");
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {carList[i].Model}");
            }
            string carName = Console.ReadLine();
            while (!IfCarExist(carName, carList))
            {
                Console.WriteLine("Write the correct name of the car please!");
                carName = Console.ReadLine();
            }

            //Zacuvuvam koja kola ja odbira
            Car selectedCar1 = new Car();
            for (int i = 0; i < carList.Count; i++)
            {
                if (carName == carList[i].Model)
                {
                    selectedCar1 = carList[i];
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Write the name of the first driver:");
            for (int i = 0; i < driverList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {driverList[i].Name}");
            }
            string driverName = Console.ReadLine();

            while (!IfDriverExist(driverName, driverList))
            {
                Console.WriteLine("Write the correct name of the driver please!");
                driverName = Console.ReadLine();
            }

            //vaka mu go dodeluvam driverot na kolata
            AddDriverToCar(driverName, carName, carList, driverList);

            Console.WriteLine("");

            Car selectedCar2 = new Car();
            Console.WriteLine("Write the name of the second car:");
            for (int i = 0; i < carList.Count; i++)
            {
                if (carName == carList[i].Model)
                {
                    selectedCar2 = carList[i];
                    continue;
                }
                Console.WriteLine($"{i + 1}. {carList[i].Model}");
            }
            carName = Console.ReadLine();

            while (!IfCarExist(carName, carList))
            {
                Console.WriteLine("Write the correct name of the car please!");
                carName = Console.ReadLine();
            }

            Console.WriteLine("");

            Console.WriteLine("Write the name of the second driver:");
            for (int i = 0; i < driverList.Count; i++)
            {
                if (driverName == driverList[i].Name)
                {
                    continue;
                }
                Console.WriteLine($"{i + 1}. {driverList[i].Name}");
            }
            driverName = Console.ReadLine();

            while (!IfDriverExist(driverName, driverList))
            {
                Console.WriteLine("Write the correct name of the driver please!");
                driverName = Console.ReadLine();
            }

            Console.WriteLine("");

            AddDriverToCar(driverName, carName, carList, driverList);

            string result = RaceCars(selectedCar1, selectedCar2);
            Console.WriteLine(result);

            Console.WriteLine();

            Console.Write("Do you want to race again (Y/N): ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            while(answer != "Y" && answer != "y" && answer != "N" && answer != "n")
            {
                Console.Write("Do you want to race again? Please write (Y/N): ");
                answer = Console.ReadLine();
                Console.WriteLine();
            }
            return answer;
        }

        public static bool IfCarExist(string carName, List<Car> carList)
        {
            bool carExist = false;
            for (int i = 0; i < carList.Count; i++)
            {
                if (carName == carList[i].Model)
                {
                    carExist = true;
                }
            }
            return carExist;
        }

        public static bool IfDriverExist(string driverName, List<Driver> driverList)
        {
            bool driverExist = false;
            for (int i = 0; i < driverList.Count; i++)
            {
                if (driverName == driverList[i].Name)
                {
                    driverExist = true;
                }
            }
            return driverExist;
        }
    }
}
