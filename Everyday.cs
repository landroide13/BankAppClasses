namespace Classes
{
    class Everyday: Account, IAccount
    {
        private double interest = 0;
        public double Interest
        {
            get { return interest; } 
        }
        private bool overdraft = false;
        public bool Overdraft
        {
            get { return overdraft; } 
        }
        private double fees = 0;
        public double Fees
        {
            get { return fees; } 
        }

        public Everyday(double balance, string owner): base(balance, owner){}

        public void withDrawal(double Balance, double money, bool Overdraft){}

        public void deposit(double Balance, double money){}

        public void applyFees(double Balance, double Fees){}

        public void applyInterest(double Balance, double interest){}

    }

}    