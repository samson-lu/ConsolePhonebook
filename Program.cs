namespace ConsolePhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            int phone;

            List<PhoneBook> contacts = new List<PhoneBook>();

            while (true)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("This is a console phonebook");
                Console.WriteLine("Please follow the prompt and enter your details");
                Console.WriteLine("================================================");
                Console.WriteLine();
                Console.WriteLine("Please enter your first name: ");
                firstname = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter your last name: ");
                lastname = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter your phone number: ");
                phone = (int)Convert.ToInt64(Console.ReadLine());
                Console.WriteLine();

                PhoneBook ph = new PhoneBook(firstname, lastname, phone);

                Console.WriteLine("{0} {1} {2}", firstname, lastname, phone);
                Console.WriteLine();

                contacts.Add(ph);

                Console.WriteLine("To see if the list is working:");
                Console.WriteLine();

                SaveToText.WriteToFile(contacts);


                
            }


            
        }
    }
}