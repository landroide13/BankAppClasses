namespace Classes
{
    abstract class User
    {
       static int num = 1;
       private int id;
       public int Id
       {
            get { return id; }   
       }
       private string contactNum;
       public string ContactNum
       {
            get { return contactNum; }   
            set { contactNum = value; }
       }
       private string name = "";
       public string Name
       {
            get { return name; }   
            set { name = value; }
       }
       private int[] accounts;
       public int[] Accounts
       {
            get { return accounts; }   
       }
       public User(string contact, string name)
       {
            num++;
            this.id = num;
            this.contactNum = contact;
            this.name = name;
       }

    }

}