namespace Ser1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("Numerele prime nu pot fi mai mici sau egale cu 1");
            }
            else if (n == 2)
            {
                Console.WriteLine("Numarul este prim");
            }
            else
            {
                bool estePrim = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {

                    if (n % i == 0)
                    {
                        estePrim = false;
                        Console.WriteLine("Numarul nu este prim");
                        break;
                    }
                }

                if(estePrim)
                {
                    Console.WriteLine("Numarul este prim");
                }
            }                    
        }
    }
}
