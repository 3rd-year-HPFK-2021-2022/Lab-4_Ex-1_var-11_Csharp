using System;

namespace Lab_4_Ex_1_var_11_Csharp
{
    public interface IMovable
    {
        void Move();
    }

    public interface ICountSpeed
    {
        double CountSpeed();
    }
    
    public abstract class Vehicle : IMovable, ICountSpeed
    {
        protected double Mass;
        protected int PassengerSeatCount;
        protected string Name;
        protected string EngineName;
        protected string EngineType;

        public Vehicle(double mass, int passengerSeatCount, string name, string engineName, string engineType)
        {
            this.Mass = mass;
            this.PassengerSeatCount = passengerSeatCount;
            this.Name = name;
            this.EngineName = engineName;
            this.EngineType = engineType;
        }

        public abstract void Move();
        public double CountSpeed()
        {
            return (Mass + PassengerSeatCount * 50) * 8;
        }
    }

    public class Car : Vehicle
    {
        private string bodyType;
        private string motorPosition;

        public Car(double speed, double mass, int passengerSeatCount, string name, string engineName, string engineType,
            string bodyType, string motorPosition) :
            base(mass, passengerSeatCount, name, engineName, engineType)
        {
            this.bodyType = bodyType;
            this.motorPosition = motorPosition;
        }


        public override void Move()
        {
            Console.WriteLine("Машина їде по дорозі\n");
        }
    }

    public class Train : Vehicle
    {
        protected double ticketCost;
        protected int carloadCount;

        public Train(double speed, double mass, int passengerSeatCount, string name, string engineName,
            string engineType,
            double ticketCost, int carloadCount) :
            base(mass, passengerSeatCount, name, engineName, engineType)
        {
            this.ticketCost = ticketCost;
            this.carloadCount = carloadCount;
        }
        
        public override void Move()
        {
            Console.WriteLine("Поїзд їде по рельсам\n");
        }
    }

    public class Express : Train
    {
        private string artificialIntelligenceNumber;

        public Express(double speed, double mass, int passengerSeatCount, string name, string engineName,
            string engineType, double ticketCost, int carloadCount,
            string artificialIntelligenceNumber) :
            base(speed, mass, passengerSeatCount, name, engineName, engineType, ticketCost, carloadCount)
        {
            this.artificialIntelligenceNumber = artificialIntelligenceNumber;
        }
    }
}