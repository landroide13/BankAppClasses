namespace Classes
{
    class Account
    {
        static int num = 1;
        private int id;
        private string owner;
        public string Owner
        {
            get { return owner; }   
            set { owner = value; }
        }
        public int Id
       {
            get { return id; }   
       }
        private double balance;
        public double Balance
       {
            get { return balance; }   
            set { balance = value; }
       }

        public Account(double balance, string owner)
        {
            num++;
            this.id = num;
            this.balance = balance;
            this.owner = owner;
        }

    }

}    