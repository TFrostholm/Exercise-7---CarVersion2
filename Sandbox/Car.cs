using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Sandbox

{
    public class Car
    {
        // instance fields 
        private String brand;
        private String modelName;
        private double horsePower;

        // This constructor creates a Car object where no fields are set 
        public Car()
        {
            brand = "not set";
            modelName = "not set";
            horsePower = 0.0;
        }

        // This constructor creates a Car object where all fields are set, 
        // using the values provided in the parameter list 
        public Car(String brand, String modelName, double horsePower)
        {
            this.brand = brand;
            this.modelName = modelName;
            this.horsePower = horsePower;
        }

        // Sets the value of the "brand" field 
        public void SetBrand(String brand)
        {
            this.brand = brand;
        }

        // Sets the value of the "modelName" field 
        public void SetModelName(String modelName)
        {
            this.modelName = modelName;
        }

        // Sets the value of the "horsePower" field 
        public void SetHorsePower(double horsePower)
        {
            this.horsePower = horsePower;
        }

        // Returns the brand of the Car 
        public String GetBrand()
        {
            return brand;
        }

        // Returns the model name of the Car 
        public String GetModelName()
        {
            return modelName;
        }

        // Returns the horse power value of the Car 
        public double GetHorsePower()
        {
            return horsePower;
        }

        // Calculates the engine effect in kilo-watts (kW), 
        // and returns that value to the caller 
        public double GetEngineEffectInkW()
        {
            double effect = horsePower * 0.745699872; // I Googled it! 
            return effect;
        }
    }
}