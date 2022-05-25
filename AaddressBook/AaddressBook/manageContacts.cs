﻿using System;
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
    public void edit()
    {
        Console.WriteLine("Enter First Name to edit");
        string fname = Console.ReadLine();
        contactModel editContact = contactlist.FirstOrDefault(x => x.firstName.ToLower() == fname.ToLower());
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
                    contact.firstName = Console.ReadLine();
                    break;
                case 2:
                    contact.lastName = Console.ReadLine();
                    break;
                case 3:
                    contact.address = Console.ReadLine();
                    break;
                case 4:
                    contact.city = Console.ReadLine();
                    break;
                case 5:
                    contact.state = Console.ReadLine();
                    break;
                case 6:
                    contact.zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case 7:
                    contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                    break;
                case 8:
                    contact.email = Console.ReadLine();
                    break;
            }
            display();
        }
        else
        {
            Console.WriteLine("Name Missmatch");
        }
    }
}
