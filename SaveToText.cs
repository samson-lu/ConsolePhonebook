using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public class SaveToText
    {

        public static void  WriteToFile(List<PhoneBook> contacts)
        {
            using (StreamWriter sw = new StreamWriter("phoneList.txt"))
            {
                if(sw != null)
               foreach (PhoneBook contact in contacts)
                {
                    sw.WriteLine("{0} {1} {2}", contact.FirstName, contact.Lastname, contact.PhoneNumber);
                }

            }
        }
        
    }
}
