using System;
using System.Collections.Generic;
using System.Linq;

namespace  CONTACTMANGERAPP
{public class Contact{
    private List<User>users=new List<User>();
    public void Add_user(User user)=>users.Add(user); 
    public void Edit_user(int iD , User newUser)
    {
    var user = users.FirstOrDefault(u => u.id==iD);
        if (user != null)
        {
            user.first_name = newUser.first_name;
            user.last_name = newUser.last_name;
            user.gender = newUser.gender;
            user.city = newUser.city;
            user.addedData = newUser.addedData;
            user.Addresses = newUser.Addresses;
            user.Phones = newUser.Phones;
            user.Emails = newUser.Emails;
        }
    }
    public void Delet_user(int iD)
    {
    var user = users.FirstOrDefault(u => u.id==iD);
        if (user != null)
        {
        users.Remove(user);
        }
    }
    public void CountUsers()
    {
        Console.WriteLine($"the number of user is :{users.Count}" );
    }
    public List<User> SearchUsers(string keyword)
    {
        return users.Where(u => u.Search(keyword) == 1).ToList();
    }
    public void ShowAllUsers()
    {
        users.ForEach(u => u.show());
    }
    
}
}