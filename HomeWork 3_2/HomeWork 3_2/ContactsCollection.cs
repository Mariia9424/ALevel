namespace HomeWork_3_2
{
    public sealed class ContactsCollection
    {
        private Dictionary<string, List<Contact>> _contactsDictionary;
        public ContactsCollection()
        {
            _contactsDictionary = new Dictionary<string, List<Contact>>();
            InitializeAlphabets();
        }
        private void InitializeAlphabets()
        {
            AddAlphabetToDictionary("English");
            AddAlphabetToDictionary("Ukrainian");
            AddAlphabetToDictionary("Number", "0-9");
            AddAlphabetToDictionary("#");
        }
        private void AddAlphabetToDictionary(string key, string alphabet = "")
        {
            _contactsDictionary[key] = new List<Contact>();
            foreach (char letter in alphabet)
            {
                _contactsDictionary[key].Add(new Contact(letter.ToString(), ""));
            }
        }
        public void AddContact(string name, string phoneNumber, string language = "English")
        {
            char firstChar = name.ToUpper()[0];
            string key = GetAlphabetKey(firstChar, language);

            _contactsDictionary[key].Add(new Contact(name, phoneNumber));
        }
        public List<Contact> GetContacts(string language = "English")
        {
            string key = GetAlphabetKey('A', language); 
            return _contactsDictionary.ContainsKey(key) ? _contactsDictionary[key] : new List<Contact>();
        }
        private string GetAlphabetKey(char firstChar, string language)
        {
            if (char.IsDigit(firstChar))
            {
                return "Number";
            }

            if (language.Equals("Ukrainian", StringComparison.OrdinalIgnoreCase))
            {
                return "Ukrainian";
            }

            if (language.Equals("English", StringComparison.OrdinalIgnoreCase))
            {
                return "English";
            }

            return "#";
        }
    }
}