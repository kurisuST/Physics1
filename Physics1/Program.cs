using Physics1;

namespace AppClassTest
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
            Console.WriteLine(FinalForce);
        }
    }
}