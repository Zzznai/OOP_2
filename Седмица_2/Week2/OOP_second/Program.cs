using System;

namespace OOP_second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    enum FuelType
    {
        Petrol,
        Diesel,
        Gasoline,
        Electric,
        Hybrid,
        Hydrogen,
        Nofueltype
    }
    class Vehicle
    {

        private string brand;

        private string model;

        private int year;

        private FuelType fuelType;

        public string Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public int Year
        {
            get { return year; }
            private set { year = value; }
        }

        public FuelType FuelType
        {
            get { return fuelType; }
            private set { fuelType = value; }
        }

        public Vehicle(string brand, string model, int year, FuelType fuelType)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.fuelType = fuelType;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"Driving {brand} {model} ({year}) with {fuelType} fuel.");
        }

    }

    class Car : Vehicle
    {

        public Car(string brand, string model, int year, FuelType fuelType) : base(brand, model, year, fuelType)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"Driving a car: {Brand} {Model} ({Year}) with {FuelType} fuel.");
        }
    }

    class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, int year, FuelType fuelType) : base(brand, model, year, fuelType)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"Driving a motorcycle: {Brand} {Model} ({Year}) with {FuelType} fuel.");
        }
    }

    class Truck : Vehicle
    {
        private double loadCapacity;
        private int numberOfAxles;

        public double LoadCapacity
        {
            get { return LoadCapacity; }
            private set { LoadCapacity = value; }
        }

        public int NumberOfAxles
        {
            get { return numberOfAxles; }
            private set
            {
                numberOfAxles = value;
            }

        }

        public Truck(string brand, string model, int year, FuelType fuelType, double loadCapacity, int numberOfAxles) : base(brand, model, year, fuelType)
        {
            this.loadCapacity = loadCapacity;
            this.numberOfAxles = numberOfAxles;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving a truck: {Brand} {Model} ({Year}) with {FuelType} fuel. Load capacity: {LoadCapacity} tons, Number of axles: {NumberOfAxles}");
        }
    }


    class Bus : Vehicle
    {
        private int numberOfSeats;

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            private set { numberOfSeats = value; }
        }

        public Bus(string brand, string model, int year, FuelType fuelType, int numberOfSeats) : base(brand, model, year, fuelType)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving a bus: {Brand} {Model} ({Year}) with {FuelType} fuel. Number of seats: {NumberOfSeats}");
        }
    }


    class Bicycle : Vehicle 
    {

        public Bicycle(string brand, string model, int year) : base(brand, model, year, fuelType:FuelType.Nofueltype)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"Riding a bicycle: {Brand} {Model} ({Year})");
        }
    }

    class ElectricCar : Vehicle
    { 
       public ElectricCar(string brand, string model, int year) : base(brand, model, year, FuelType.Electric)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"Driving an electric car: {Brand} {Model} ({Year})");
        }
    }



}
