// See https://aka.ms/new-console-template for more information
manageContacts manage = new manageContacts();
Console.WriteLine("Enter 1 To Create Contact");
Console.WriteLine("Enter 2 To Create Contact & Edit");
Console.WriteLine("Enter 3 To Create, Edit & Delete Contact");
Console.WriteLine("Enter 4 To Create Multiple Contact then Edit & Delete Contact");
Console.WriteLine("Enter 5 To Create, Edit & Delete Contact");
int select =Convert.ToInt32(Console.ReadLine());

switch (select)
{
    case 1:
        manage.inputDetails();
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
        manage.edit();
        manage.deleteContact();
        break;
    case 5:
        manage.dictionary();
        manage.edit();
        manage.deleteContact();
        break;
}
