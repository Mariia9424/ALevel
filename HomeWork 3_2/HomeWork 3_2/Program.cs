namespace HomeWork_3_2
{
    class Program
    {
        static void Main()
        {
            ContactsCollection contactCollection = new ContactsCollection();

            contactCollection.AddContact("Mila Kofan", "44-236-714-9305");
            contactCollection.AddContact("Анна Курiнь", "096-576-0023", "Ukrainian");
            contactCollection.AddContact("Brad Olifer", "44-748-026-6671");
            contactCollection.AddContact("Влад Мельник", "095-359-4729", "Ukrainian");
            contactCollection.AddContact("Avan Volf", "44-267-595-4895");
            contactCollection.AddContact("John Fores", "44-261-716-0549");
            contactCollection.AddContact("Таня Тимофiїв", "098-674-3028", "Ukrainian");
            contactCollection.AddContact("888", "0999121888");
            contactCollection.AddContact("Hanna Lut", "44-259-975-4923");
            contactCollection.AddContact("Богдан Середа", "096-690-7261", "Ukrainian");
            contactCollection.AddContact("Руслан Цiпан", "093-349-5873", "Ukrainian");
            contactCollection.AddContact("Lui Rapitor", "44-156-110-9764");
            contactCollection.AddContact("Юлiя Клiпчар", "095-967-4418", "Ukrainian");
            contactCollection.AddContact("$$", "0800-502-050", "#");

            List<Contact> englishContacts = contactCollection.GetContacts("English");
            List<Contact> ukrainianContacts = contactCollection.GetContacts("Ukrainian");
            List<Contact> numberContacts = contactCollection.GetContacts("Number");
            List<Contact> otherContacts = contactCollection.GetContacts("#");

            Console.WriteLine("English Contacts:");
            DisplayContacts(englishContacts);

            Console.WriteLine("\nUkrainian Contacts:");
            DisplayContacts(ukrainianContacts);

            Console.WriteLine("\nNumber Contacts:");
            DisplayContacts(numberContacts);

            Console.WriteLine("\nOther Contacts:");
            DisplayContacts(otherContacts);
        }
        static void DisplayContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Name} - {contact.PhoneNumber}");
            }
        }
    }
}