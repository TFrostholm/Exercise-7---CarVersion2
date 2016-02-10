using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line 

            // Here we create a new object of type Car 
            Car myCar = new Car();

            // Print data about my car (BEFORE setting the values) 
            // Note that we call some of the "Get..." methods here 
            Console.WriteLine("Car data BEFORE setting values");
            Console.WriteLine("Car data: brand is {0}, model is {1}, engine effect is {2}",
                myCar.GetBrand(), myCar.GetModelName(), myCar.GetEngineEffectInkW());
            Console.WriteLine("");

            // We now call some of the "Set..." methods: 
            myCar.SetBrand("Volvo");
            myCar.SetModelName("V40");
            myCar.SetHorsePower(145.0);

            // Print data about my car (AFTER setting the values
            // Note that we call some of the "Get..." methods 
            Console.WriteLine("Car data AFTER setting values");
            Console.WriteLine("Car data: brand is {0}, model is {1}, engine effect is {2}",
                myCar.GetBrand(), myCar.GetModelName(), myCar.GetEngineEffectInkW());
            Console.WriteLine("");

            // Now we create an additional Car object, but in a different way... 
            Car yourCar = new Car("BMW", "520i", 220.0);

            // Print data about your car
            // Note that we call some of the "Get..." methods here 
            Console.WriteLine("Car data using alternative constructor");
            Console.WriteLine("Car data: brand is {0}, model is {1}, engine effect is {2}",
                yourCar.GetBrand(), yourCar.GetModelName(), yourCar.GetEngineEffectInkW());
            Console.WriteLine("");

            Car fredsCar = new Car("VW", "Golf", 180);
            Console.WriteLine("Freds car is a {0} {1} with an engine effect of {2}", fredsCar.GetBrand(), fredsCar.GetModelName(), fredsCar.GetEngineEffectInkW());
            fredsCar.SetHorsePower(1001);

            Console.WriteLine("But after a little upgrade his {0} now has {1} BHP!!! meaning it has an engine effect of {2}", fredsCar.GetModelName(), fredsCar.GetHorsePower(), fredsCar.GetEngineEffectInkW());
 

            // The LAST line of code should be ABOVE this line 
        }
    }
}
