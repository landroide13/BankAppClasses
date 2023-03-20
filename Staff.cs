namespace Classes
{

    class Staff: User
    {
        double fees = 0.5;
        public double Fees
        {
            get { return fees; } 
        }

        public Staff(string contact, string name): base(contact, name){}

    }

}