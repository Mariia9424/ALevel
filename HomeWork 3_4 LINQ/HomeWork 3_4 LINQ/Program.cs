using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_3_4_LINQ
{
    public sealed class Program
    {
        public static void Main()
        {
            List<Contact> contacts = new List<Contact>
            {
            new Contact { Name = "Ivan", Age = 26 },
            new Contact { Name = "Olena", Age = 31 },
            new Contact { Name = "David", Age = 29 },
            new Contact { Name = "Alice", Age = 32 },
            new Contact { Name = "Denis", Age = 23 }
            };
            // FirstOrDefault
            var firstContact = contacts.FirstOrDefault(c => c.Name.StartsWith("A"));
            Console.WriteLine("First contact whose name starts with 'A':");
            Console.WriteLine(firstContact?.Name);
            Console.WriteLine();

            // Where
            var filteredContacts = contacts.Where(c => c.Age > 30);
            Console.WriteLine("Contacts whose age is greater than 30:");
            foreach (var contact in filteredContacts)
            {
                Console.WriteLine(contact.Name);
            }
            Console.WriteLine();

            // Select
            var contactNames = contacts.Select(c => c.Name);
            Console.WriteLine("Contact names:");
            foreach (var name in contactNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // OrderBy
            var sortedContacts = contacts.OrderBy(c => c.Age);
            Console.WriteLine("Contacts sorted by age:");
            foreach (var contact in sortedContacts)
            {
                Console.WriteLine($"{contact.Name} ({contact.Age})");
            }
            Console.WriteLine();

            // Join
            var joinedNames = string.Join(", ", contacts.Select(c => c.Name));
            Console.WriteLine("Joined contact names:");
            Console.WriteLine(joinedNames);
            Console.WriteLine();

            // Any
            var hasYoungContacts = contacts.Any(c => c.Age < 20);
            Console.WriteLine("Are there any contacts with age less than 20?");
            Console.WriteLine(hasYoungContacts);
            Console.WriteLine();

            // Min
            var minAge = contacts.Min(c => c.Age);
            Console.WriteLine("Minimum age among the contacts:");
            Console.WriteLine(minAge);
            Console.WriteLine();

            // Max
            var maxAge = contacts.Max(c => c.Age);
            Console.WriteLine("Maximum age among the contacts:");
            Console.WriteLine(maxAge);
        }
    }
}