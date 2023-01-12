class AddressBook 
{
    //field
    private readonly List<Contact> _contacts;

    //properties
    public AddressBook()
    {
        _contacts = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }

    public void RemoveContact(Contact contact)
    {
        _contacts.Remove(contact);
    }

    public void SortContact()
    {
        _contacts.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
    }
    public void PrintContact()
    {
        foreach (var item in _contacts)
        {
            Console.WriteLine(item);
        }
    }

}