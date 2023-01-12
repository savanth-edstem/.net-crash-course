string firstName = string.Empty;
string lastName = string.Empty;
string email = string.Empty;
string phone = string.Empty;

List<Contact> cachedContacts = new List<Contact>();
AddressBook addressBook = new AddressBook();



void ContactEntry()
{
    string run = string.Empty;

    Console.WriteLine("      Enter new contact ");

    
    Console.Write("Please enter your first name : ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name : ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your email : ");
    email = Console.ReadLine();

    Console.Write("Please enter your phone number : ");
    phone = Console.ReadLine();

    Contact contact = new Contact(firstName, lastName, email, phone);
    addressBook.AddContact(contact);
    cachedContacts.Add(contact);

    Console.WriteLine();
 }

void Menu()
{
    string run = string.Empty;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Enter 1 to add new contact");
        Console.WriteLine("Enter 2 to delete contacts");
        Console.WriteLine("Enter 3 to view all contacts");
        Console.WriteLine("Enter 4 to sort all contacts");
        Console.WriteLine("Enter 5 to exit Address Book");
        
        int menuOption = Convert.ToInt32(Console.ReadLine());
        switch (menuOption)
        {
            case 1:
                ContactEntry();
                break;
            case 2:
                DeleteContact();
                break;
            case 3:
                addressBook.PrintContact();               
                break;
            case 4:
                addressBook.SortContact();
                addressBook.PrintContact();
                break;
            case 5:
                run = "q";
                break;
            default:
                UnknownMenu();
                break;

        }
    } while (!run.Equals("q"));

}
void DeleteContact()
{
    int index = 1;
    int cnt = 0;
    foreach (var item in cachedContacts)
    {
        Console.WriteLine($"{index}.name: {item.FirstName}");
        index++;
    }
    Console.WriteLine("select the contact to delete");
    cnt = Convert.ToInt32(Console.ReadLine());
    addressBook.RemoveContact(cachedContacts[cnt - 1]);
    cachedContacts.Remove(cachedContacts[cnt - 1]);
}
void UnknownMenu()
{
    Console.WriteLine("Incorrect entry or no option selected");
    Console.WriteLine("Try again");
}
try
{
    Menu();
}
catch (Exception)
{

    throw;
}
finally
{
    Console.WriteLine("   Thank You");
}