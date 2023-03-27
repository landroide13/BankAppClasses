namespace Classes
{
    class Omni: Account, IAccount
    {
        private string type = "Omni";
        private double interest = 0.04;
        private bool overdraft = true;
        private double fees = 10.25;
        public Omni(double balance, string owner): base(balance, owner){}

         public override string ToString()
        {
            return $"Account {type} id: {Id}, Balance: ${Balance}, Applied Fees: {fees}, Owner Name: {Owner}";
        }

    }

}   