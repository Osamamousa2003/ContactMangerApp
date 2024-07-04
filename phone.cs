using System;
using System.Collections.Generic;
using System.Linq;

namespace CONTACTMANGERAPP
{
    public class Phone
    {
        public string phone{get; set;}
        public  string type{get ; set;}
        public  string description{get; set;}
        public void Edit_phone(string phone_ , string type_ , string description__)
        {
            phone=phone_;
            type=type_;
            description=description__;

        } 
        public string Get_phone()
        {
            return $"{phone},{type} , {description}";
        }
        
    }
}