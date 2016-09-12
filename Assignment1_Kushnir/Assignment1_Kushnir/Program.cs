/* Mykola Kushnir
 * 2600 section1
 * Assingmnt first
 * 11/09/2016*/
namespace Assignment1_Kushnir
{
    class Program
    {
      static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Customer name: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Enter shipping zip code: ");
            int zip = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter numbers of envelopers: ");
            int env_num = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter numbers of packages: ");
            int pcg_num = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine();
            double env_price = 0.89;
            double pcg_price = 3.55;
            double price = env_num * env_price + pcg_num * pcg_price;
            double tax = price * 0.1;
            double total_p = price  + tax;
            System.Console.WriteLine("Ships to:      " + name);
            System.Console.WriteLine("Shipping zip:  " + zip);
            System.Console.WriteLine("Shiping cost:  {0:C}", price);
            System.Console.WriteLine("Tax            {0:C}", tax);
            System.Console.WriteLine("Shiping total: {0:C}", total_p);
            System.Console.ReadKey();
                
        }
    }
}
