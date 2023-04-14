﻿namespace Day23_AddressBook
{
    class AddressBookMainClass
    {
        Dictionary<string, List<UserContact>> AddressBookDic = new Dictionary<string, List<UserContact>>();
        public void AddDetails()
        {
            List<UserContact> con = new List<UserContact>();
            UserContact newContact = new UserContact();


            Console.WriteLine("Enter First Name: ");
            newContact.firstName = Console.ReadLine();
            //Check for no duplicate Entry
            if (AddressBookDic.ContainsKey(newContact.firstName))
            {
                Console.WriteLine("Duplicate Entries are not possible");
                return;
            }
            Console.WriteLine("Enter Last name: ");
            newContact.lastName = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            newContact.mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            newContact.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            newContact.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            newContact.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            newContact.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            newContact.email = Console.ReadLine();

            con.Add(newContact);
            AddressBookDic.Add(newContact.firstName, con);
        }



        public void DisplayContact()
        {
            foreach (var key in AddressBookDic.Keys)
            {
                Console.WriteLine($"key is {key}");

                Console.WriteLine("The Details you stored in Address Book:");

                List<UserContact> con = AddressBookDic[key];
                foreach (var change in con)
                {

                    Console.WriteLine(change.ToString());
                }

            }
        }
        public static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("!!!!!!Welcome to Updated Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AddressBookMainClass person = new AddressBookMainClass();

            while (flag == true)
            {
                Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Please add new contact details: ");
                            person.AddDetails();
                            person.DisplayContact();
                            flag = true;
                            break;

                        }
                    case 0:
                        {
                            Console.WriteLine("press any key for exit:");
                            flag = false;
                            break;

                        }
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }

        }
    }
}
