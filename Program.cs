namespace Classes
{
    class Program
    {
        static void Main()
        {
            Customer c1 = new Customer("2233-555", "eltro");
            Customer c2 = new Customer("2233-555", "Petra");

            Staff s1 = new Staff("555-56-67", "Bigote");
            Staff s2 = new Staff("555-56-67", "Don");

            Everyday e1 = new Everyday(1000, s1.Name);

            Console.WriteLine("Customer name  " + s1.Name);
            Console.WriteLine("Account Id  " + e1.Id);
            Console.WriteLine("Account Info:  " + e1.ToString());
            Console.WriteLine("Account balance: $" + e1.Balance);
        }
    }
}
