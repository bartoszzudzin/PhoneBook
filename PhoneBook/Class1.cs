using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("5 delete contact by number");
            Console.WriteLine("x - exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number (min. 9 numbers): ");
                        var number = Console.ReadLine();
                        while (number.Length < 9)
                        {
                            Console.WriteLine("Insert number (min. 9 numbers): ");
                            number = Console.ReadLine();
                        }

                        Console.WriteLine("Insert name (min. 3 chars): ");
                        var name = Console.ReadLine();

                        while (name.Length <= 2)
                        {
                            Console.WriteLine("Insert name (min. 3 chars): ");
                            name = Console.ReadLine();
                        }

                        var newContact = new Contact(name, number);

                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Insert number: ");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);

                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert serach phrase: ");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);

                        break;
                    case "5":
                        Console.WriteLine("Insert number: ");
                        var numberToDelete = Console.ReadLine();
                        phoneBook.DeleteContact(numberToDelete);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }

        }
    }
}
