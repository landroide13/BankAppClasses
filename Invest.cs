namespace Classes
{
    class Invest: Account
    {
        private double interest = 0.25;
        private bool overdraft = false;
        private double fees = 10.34;
        public Invest(double balance, string owner): base(balance, owner){}

    }

}    