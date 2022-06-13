using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class manageContacts
{
    List<contactModel> contactlist = new List<contactModel>();
    contactModel contact;
    Dictionary<string, List<contactModel>> book = new Dictionary<string, List<contactModel>>();
    Dictionary<string, List<contactModel>> bookByState = new Dictionary<string, List<contactModel>>();
    Dictionary<string, List<contactModel>> bookByCity = new Dictionary<string, List<contactModel>>();

    public void inputDetails()
    {
        contact = new contactModel();
        bool status = true;
        while (status)
        {
            Console.WriteLine("Enter First Name");
            contact.firstName = Console.ReadLine();
            if (contactlist.Any(e => (e.firstName.Equals(contact.firstName))))
            {
                Console.WriteLine("First Name Exists");
            }
            else
            {
                status = false;
            }
        }
        Console.WriteLine("Enter Last Name");
        contact.lastName = Console.ReadLine();
        Console.WriteLine("Enter Address");
        contact.address = Console.ReadLine();
        Console.WriteLine("Enter City");
        contact.city = Console.ReadLine();
        Console.WriteLine("Enter State");
        contact.state = Console.ReadLine();
        Console.WriteLine("Enter Zip");
        contact.zip = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Phone Number");
        contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter E-mail");
        contact.email = Console.ReadLine();
        contactlist.Add(contact);
    }
    public void display()
    {
        foreach (var info in contactlist)
        {
            Console.WriteLine();
            Console.WriteLine("First Name : " + info.firstName + "\nLast Name : " + info.lastName +
                    "\nAddress : " + info.address + "\nCity : " + info.city + "\nState : " + info.state
                    + "\nZip : " + info.zip + "\nPhone Number : " + info.phoneNumber + "\nE-mail : " + info.email);
        }
    }
    public void edit()
    {
        Console.WriteLine("Enter First Name to edit");
        string fname = Console.ReadLine();
        contactModel editContact = contactlist.FirstOrDefault(x => x.firstName == fname);
        if (editContact != null)
        {
            Console.WriteLine("Choose Field to edit");
            Console.WriteLine("1 - First Name");
            Console.WriteLine("2 - Last Name");
            Console.WriteLine("3 - Address");
            Console.WriteLine("4 - City");
            Console.WriteLine("6 - Zip");
            Console.WriteLine("5 - State");
            Console.WriteLine("7 - Phone Number");
            Console.WriteLine("8 - E-mail");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    editContact.firstName = Console.ReadLine();
                    break;
                case 2:
                    editContact.lastName = Console.ReadLine();
                    break;
                case 3:
                    editContact.address = Console.ReadLine();
                    break;
                case 4:
                    editContact.city = Console.ReadLine();
                    break;
                case 5:
                    editContact.state = Console.ReadLine();
                    break;
                case 6:
                    editContact.zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case 7:
                    editContact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                    break;
                case 8:
                    editContact.email = Console.ReadLine();
                    break;
            }
            display();
        }
        else
        {
            Console.WriteLine("Name Missmatch");
        }
    }
    public void deleteContact()
    {
        Console.WriteLine("Enter First Name to Delete Contact");
        string fname = Console.ReadLine();
        //contact deleteContact = contactlist.FirstOrDefault(x => x.firstName.ToLower() == fname);
        foreach (var input in contactlist.ToList())
        {
            if (input.firstName == fname)
            {
                contactlist.Remove(input);
            }
        }
        display();
    }
    public void multipleContact()
    {
        Console.WriteLine("Enter Number of Contacts to Create");
        int count = Convert.ToInt32(Console.ReadLine());
        contactlist = new List<contactModel>();
        while (count > 0)
        {
            inputDetails();
            count--;
        }
    }
    public void dictionary()
    {
        Console.WriteLine("Enter Number of Group to Add");
        int groupCount = Convert.ToInt32(Console.ReadLine());
        while (groupCount > 0)
        {
            Console.WriteLine("Enter Group Name");
            string groupName = Console.ReadLine();
            multipleContact();
            book.Add(groupName, contactlist.ToList());
            groupCount--;
        }
        foreach (var gname in book.Keys)
        {
            Console.WriteLine(gname);
            foreach (contactModel name in book[gname])
            {
                Console.WriteLine(name.firstName);
            }
        }
    }
    public void FindContactByCity()
    {
        dictionary();
        Console.WriteLine("Enter City to Find Contact");
        string checkCity = Console.ReadLine();
        foreach (var gname in book)
        {
            Console.WriteLine("Group Name : " + gname.Key);
            foreach (var find in gname.Value.FindAll(e => (e.city.Equals(checkCity))).ToList())
            {
                Console.WriteLine("First Name : " + find.firstName + "\nLast Name : " + find.lastName +
                    "\nAddress : " + find.address + "\nCity : " + find.city + "\nState : " + find.state
                    + "\nZip : " + find.zip + "\nPhone Number : " + find.phoneNumber + "\nE-mail : " + find.email);
            }
        }
    }
    public void FindContactByState()
    {
        dictionary();
        Console.WriteLine("Enter State to Find Contact");
        string checkCity = Console.ReadLine();
        foreach (var gname in book)
        {
            Console.WriteLine("Group Name : " + gname.Key);
            foreach (var find in gname.Value.FindAll(e => (e.state.Equals(checkCity))).ToList())
            {
                Console.WriteLine("First Name : " + find.firstName + "\nLast Name : " + find.lastName +
                    "\nAddress : " + find.address + "\nCity : " + find.city + "\nState : " + find.state
                    + "\nZip : " + find.zip + "\nPhone Number : " + find.phoneNumber + "\nE-mail : " + find.email);
            }
        }
    }
    public void DisplayContactByState()
    {
        dictionary();
        List<string> contacts = new List<string>();

        foreach (var key in book.Keys)
        {
            foreach (var value in book[key])
            {
                if (bookByState.ContainsKey(value.state))
                {
                    bookByState[value.state].Add(value);
                }
                else
                {
                    bookByState.Add(value.state, new List<contactModel>() { value });
                }
            }
        }
        foreach (var key in bookByState.Keys)
        {
            Console.WriteLine("State " + key);

            bookByState[key].ForEach(x => Console.WriteLine(x.firstName));
        }
    }
    public void DisplayContactByCity()
    {
        dictionary();
        List<string> contacts = new List<string>();

        foreach (var key in book.Keys)
        {


            foreach (var value in book[key])
            {

                if (bookByCity.ContainsKey(value.city))
                {
                    bookByCity[value.city].Add(value);
                }
                else
                {
                    bookByCity.Add(value.city, new List<contactModel>() { value });
                }
            }
        }

        foreach (var key in bookByCity.Keys)
        {
            Console.WriteLine("City " + key);

            bookByCity[key].ForEach(x => Console.WriteLine(x.firstName));

        }
    }
    public void FindNumberOfContactsByCity()
    {
        DisplayContactByCity();
        int count = 0;
        foreach (var key in bookByCity.Keys)
        {
            foreach (var values in bookByCity[key])
            {
                count++;
            }
            Console.WriteLine(key + " City Contains " + count + " Contacts");
            count = 0;
        }
    }
    public void FindNumberOfContactsByState()
    {
        DisplayContactByState();
        int count = 0;
        foreach (var key in bookByState.Keys)
        {
            foreach (var values in bookByState[key])
            {
                count++;
            }
            Console.WriteLine(key + " State Contains " + count + " Contacts");
            count = 0;
        }
    }
    public void WriteFile()
    {
        string filePath = @"D:\Bridgelabz\.Net\Address-Book\AaddressBook\AaddressBook\Contacts File.txt";
        dictionary();
        using (StreamWriter write = File.AppendText(filePath))
        {
            foreach (var gname in book.Keys)
            {
                write.WriteLine(gname);
                foreach (contactModel name in book[gname])
                {
                    write.WriteLine("First Name : " + name.firstName + "\nLast Name : " + name.lastName +
                     "\nAddress : " + name.address + "\nCity : " + name.city + "\nState : " + name.state
                     + "\nZip : " + name.zip + "\nPhone Number : " + name.phoneNumber + "\nE-mail : " + name.email);
                    write.WriteLine("===============================");
                }

                write.WriteLine("===============================");
            }
        }
    }
    public void ReadFile()
    {
        string filePath = @"D:\Bridgelabz\.Net\Address-Book\AaddressBook\AaddressBook\Contacts File.txt";
        if (File.Exists(filePath))
        {
            string[] readFile = File.ReadAllLines(filePath);
            foreach (string lines in readFile)
            {
                if (lines != null)
                {
                    Console.WriteLine(lines);
                }
            }
            return;
        }
        Console.WriteLine("File Not Found");
    }
}
    
    

