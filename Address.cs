using System;
using System.Collections.Generic;
using System.Linq;
namespace CONTACTMANGERAPP
{
     public class Address
    {
        public string place{get; set;}
        public  string type{get ; set;}
        public  string description{get; set;}
        public void Edit_place(string place_ , string type_ , string description__)
        {
            place=place_;
            type=type_;
            description=description__;
        } 
        public string Get_Address()
        {
            return $"{place},{type} , {description}";
        }
        
    }
}