class FirstExample
{
    static void Main()
    {
        string firstName = "Mykola";
        string lastName = "Kushnir";
        System.Console.WriteLine("Hello World" + firstName + " " + lastName);
       // 
                                  /*  int a = 10;
                                    int b = 15;
                                    int c;
                                    c = (a + b) * 2;
                                    System.Console.WriteLine("c= {0}", c);
                                   */
        System.Console.WriteLine("Please enter first name: ");
        firstName = System.Console.ReadLine();
        System.Console.WriteLine("Please enter last name: ");
        lastName = System.Console.ReadLine();

        System.Console.WriteLine("Hello " + firstName + lastName);

        System.Console.ReadKey();



    }
}
