namespace Lab_4_Ex_1_var_11_Csharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Train train = new Train(12, 3453, 45, "se", "se", "de", 13, 324);
            train.Move();
            Express express = new Express(12, 3453, 45, "se", "se", "de", 13, 324, "fr");
            express.Move();
            Car car = new Car(12, 3453, 45, "se", "se", "de", "hb", "md");
            car.Move();
        }
    }
}