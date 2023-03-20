namespace Classes
{
    class Omni: Account
    {
        private double interest = 0.04;
        private bool overdraft = true;
        private double fees = 10.25;
        public Omni(double balance, string owner): base(balance, owner){}

    }

}   