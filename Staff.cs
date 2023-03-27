namespace Classes
{

    class Staff: User
    {
        double feesDesc = 0.05;
        public double Desc
        {
            get { return feesDesc; } 
        }

        public Staff(string contact, string name): base(contact, name){}

    }

}