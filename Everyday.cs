namespace Classes
{
    class Everyday: Account
    {
        private decimal interest = 0;
        private bool overdraft = false;
        private decimal fees = 0;
        public Everyday(double balance, string owner): base(balance, owner){}

    }

}    