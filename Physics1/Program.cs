namespace Physics1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write the bullet weight(kg): ");
            int bWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the bullet acceleration(m/s): ");
            int acc = Convert.ToInt32(Console.ReadLine());
            Canyon bulletForce = new Canyon (bWeight, acc);
            int FinalForce = bulletForce.GetFinalValue();
            Console.WriteLine("The bullet force was: "+ FinalForce+ "(N)");
            
        }
    }
}