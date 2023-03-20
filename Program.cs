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
            


            //Console.WriteLine("Customer name  " + c1.Name);
            //Console.WriteLine("Staff Id  " + s2.Id);
            Console.WriteLine("Account Owner:  " + e1.Owner);
            Console.WriteLine("Account balance: " + e1.Balance);
        }
    }
}
