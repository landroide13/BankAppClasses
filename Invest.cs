namespace Classes
{
    class Invest: Account
    {
        private decimal interest;
        private bool overdraft;
        private decimal fees;

        public Invest(double balance): base(balance){}

    }

}    