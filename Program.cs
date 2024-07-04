// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Globalization;



namespace CONTACTMANGERAPP
{
  class Program
  {
  static void Main(string[] args)
    {   
      Contact contact=new Contact();
      int choice; 
       do
        {
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Edit User");
            Console.WriteLine("3. Delete User");
            Console.WriteLine("4. Search User");
            Console.WriteLine("5. Show All Users");
            Console.WriteLine("6. number of  Users");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddUser(contact);
                    break;
                case 2:
                    EditUser(contact);
                    break;
                case 3:
                    DeleteUser(contact);
                    break;
                case 4:
                    SearchUser(contact);
                    break;
                case 5:
                    contact.ShowAllUsers();
                    break;
                case 6:
                    contact.CountUsers();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
        
    }
  } while (choice != 0);
 }
   public static void AddUser(Contact contact)
 {
        User user=new User();
        Console.Write("Enter ID: ");
        user.id = int.Parse(Console.ReadLine());
        Console.Write("Enter First Name: ");
        user.first_name = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        user.last_name = Console.ReadLine();
        Console.Write("Enter Gender: ");
        user.gender = Console.ReadLine();
        Console.Write("Enter City: ");
        user.city = Console.ReadLine();
        user.addedData = DateTime.Now;

        Address address=new Address();
        Console.Write("Enter place: ");
        address.place=Console.ReadLine();
        Console.Write("Enter type: ");
        address.type=Console.ReadLine();
        Console.Write("Enter description: ");
        address.description=Console.ReadLine();
        user.AddAddress(address);

        Phone new_phone=new Phone();
        Console.Write("Enter phone: ");
        new_phone.phone=Console.ReadLine();
        Console.Write("Enter type: ");
        new_phone.type=Console.ReadLine();
        Console.Write("Enter description: ");
        new_phone.description=Console.ReadLine();
        user.AddPhone(new_phone);

        Email new_email=new Email();
        Console.Write("Enter email: ");
        new_email.email=Console.ReadLine();
        Console.Write("Enter type: ");
        new_email.type=Console.ReadLine();
        Console.Write("Enter description: ");
        new_email.description=Console.ReadLine();
        user.AddEmail(new_email);
        
        contact.Add_user(user);
        Console.WriteLine("User added successfully!");
}
    static void EditUser(Contact contact)
{   
        User user = new User();
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter new First Name: ");
        user.first_name = Console.ReadLine();
        Console.Write("Enter  new Last Name: ");
        user.last_name = Console.ReadLine();
        Console.Write("Enter new Gender: ");
        user.gender = Console.ReadLine();
        Console.Write("Enter new City: ");
        user.city = Console.ReadLine();
        user.addedData = DateTime.Now;
        
        
        Console.Write("enter index: ");
        int index_=int.Parse(Console.ReadLine());
        Console.Write("Enter new place: ");
        string place=Console.ReadLine();
        Console.Write("Enter new type: ");
        string type=Console.ReadLine();
        Console.Write("Enter new description: ");
        string description=Console.ReadLine();
        user.editaddress(index_,place,type,description);
        
        
        Phone new_phone=new Phone();
        Console.Write("Enter new phone: ");
        new_phone.phone=Console.ReadLine();
        Console.Write("Enter new type: ");
        new_phone.type=Console.ReadLine();
        Console.Write("Enter new  description: ");
        new_phone.description=Console.ReadLine();
        user.editphone(index_,new_phone);
        
        Console.Write("Enter  new email: ");
        string _email=Console.ReadLine();
        Console.Write("Enter  new type: ");
        string _type=Console.ReadLine();
        Console.Write("Enter new description: ");
        string _description=Console.ReadLine();
        user.editemail(index_,_email,_type,_description);
        contact.Edit_user( id,user);
        
}
    static void DeleteUser(Contact contact)
    {
        Console.Write("Enter User ID to delete: ");
        int id = int.Parse(Console.ReadLine());
        contact.Delet_user(id);
        Console.WriteLine("User deleted successfully!");
    }
    static void SearchUser(Contact contact)
    {
        Console.Write("Enter search keyword: ");
        string keyword = Console.ReadLine();
        var result = contact.SearchUsers(keyword);
        if (result.Count > 0)
        {
            result.ForEach(u => u.show());
        }
        else
        {
            Console.WriteLine("No users found!");
        }
    }
}
}






