// See https://aka.ms/new-console-template for more information
manageContacts manage = new manageContacts();
Console.WriteLine("Enter 1 To Create Contact");
Console.WriteLine("Enter 2 To Create Contact & Edit");
Console.WriteLine("Enter 3 To Create, Edit & Delete Contact");
Console.WriteLine("Enter 4 To Create Multiple Contact then Edit & Delete Contact");
Console.WriteLine("Enter 5 To Create a Contact group then creat, Edit & Delete Contact");
Console.WriteLine("Enter 6 Search Contact");
Console.WriteLine("Enter 7 To Display Contact By State");
Console.WriteLine("Enter 8 To Display Contact By City");
Console.WriteLine("Enter 9 To Display Contact By City");
Console.WriteLine("Enter 10 To Read And Write using txt file");
Console.WriteLine("Enter 11 To Read And Write using CSV file");
int select =Convert.ToInt32(Console.ReadLine());

switch (select)
{
    case 1:
        manage.inputDetails();
        manage.display();
        break;
    case 2:
        manage.inputDetails();
        manage.edit();
        break;
    case 3:
        manage.inputDetails();
        manage.edit();
        manage.deleteContact();
        break;
    case 4:
        manage.multipleContact();
        manage.display();
        break;
    case 5:
        manage.dictionary();
        manage.FindContactByCity();
        manage.edit();
        manage.deleteContact();
        break;
    case 6:
        Console.WriteLine("Enter 1 To Find Contact By City");
        Console.WriteLine("Enter 2 To Find Contact By State");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                manage.FindContactByCity();
                break;
            case 2:
                manage.FindContactByState();
                break;
        }
        break;
    case 7:
        manage.DisplayContactByState();
        break;
    case 8:
        manage.DisplayContactByCity();
        break;
    case 9:
        Console.WriteLine("Enter 1 To Find Number of Contact By City");
        Console.WriteLine("Enter 2 To Find Number of Contact By State");
        int option1 = Convert.ToInt32(Console.ReadLine());
        switch (option1)
        {
            case 1:
                manage.FindNumberOfContactsByCity();
                break;
            case 2:
                manage.FindNumberOfContactsByState();
                break;
        }
        break;
    case 10:
        manage.WriteFile();
        manage.ReadFile();
        break;
    case 11:
        manage.WriteCSVFile();
        manage.ReadCSVFile();
        break;
        


}
