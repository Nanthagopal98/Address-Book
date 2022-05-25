using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class manageContacts
    {
    List<contactModel> contactlist = new List<contactModel>();
    contactModel contact;
    public void inputDetails()
    {
        contact = new contactModel();
        Console.WriteLine("Enter First Name");
        contact.firstName = Console.ReadLine();
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
}

