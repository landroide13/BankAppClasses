namespace Classes
{
    class Everyday: Account
    {
        private decimal interest;
        private bool overdraft;
        private decimal fees;

        public Everyday(double balance): base(balance){}

    }

}    