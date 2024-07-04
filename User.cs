using System;
using System.Collections.Generic;
using System.Linq;

namespace CONTACTMANGERAPP
{
    public  class  User
    {
    public long id{get; set;}
    public string first_name{get; set;}
    public string last_name{get; set;}
    public string gender{get; set;}
    public string city{get; set;}
    public DateTime addedData{get; set; }
    
    public List<Address> Addresses { get; set; }=new List<Address>();
    public List<Phone> Phones { get; set; }=new List<Phone>();
    public List<Email> Emails { get; set; }=new List<Email>();
    
      public int Search(string keyword)
    {
        if (Addresses.Any(a => a.Get_Address().Contains(keyword)) ||
            Phones.Any(p => p.Get_phone().Contains(keyword)) ||
            Emails.Any(e => e.Get_email().Contains(keyword)) ||
            first_name.Contains(keyword) ||
            last_name.Contains(keyword) ||
            gender.Contains(keyword) ||
            city.Contains(keyword))
        {
            return 1;
        }

        return 0;
    }

    public void AddPhone(Phone phone) => Phones.Add(phone);
    public void AddEmail(Email email) => Emails.Add(email);
    public void AddAddress(Address address) => Addresses.Add(address);

    public void editphone(int index , Phone phone )
    {
        if(index>=0 && index<Phones.Count)
        {
            Phones[index]=phone;  
        }
    }
    public void editemail(int index , string email , string type , string description )
    {
        if(index>=0 && index<Emails.Count)
        {
            Emails[index].Edit_email(email, type , description);  
        }
    }
    public void editaddress(int index , string place , string type , string description )
    {
        if(index>=0 && index<Addresses.Count)
        {
            Addresses[index].Edit_place(place, type , description);  
        }
    }

    public void DeletePhone(int index)
    {
        if (index >= 0 && index < Phones.Count)
        {
            Phones.RemoveAt(index);
        }
    }

    public void DeleteEmail(int index)
    {
        if(index>=0 && index<Emails.Count)
        {
            Emails.RemoveAt(index);
        }
    }

    public void DeleteAddress(int index)
    {
        if(index>=0 && index<Addresses.Count)
        {
            Addresses.RemoveAt(index);
        }
    }

    public void show()
    {
        Console.WriteLine($"ID: {id}, Name: {first_name} {last_name}, Gender: {gender}, City: {city}, Added: {addedData}");
        Console.WriteLine("Addresses:");
        Addresses.ForEach(a => Console.WriteLine(a.Get_Address()));
        Console.WriteLine("Phones:");
        Phones.ForEach(p => Console.WriteLine(p.Get_phone()));
        Console.WriteLine("Emails:");
        Emails.ForEach(e => Console.WriteLine(e.Get_email()));
    }
    }
}