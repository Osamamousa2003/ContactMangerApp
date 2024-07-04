using System;
using System.Collections.Generic;
using System.Linq;

namespace CONTACTMANGERAPP
{    public class Email
    {  
          public string email{get; set;}
          public  string type{get ; set;}
          public  string description{get  ; set;}
          public void Edit_email(string email_ , string type_ , string description_)
          {
            email=email_;
            type=type_;
            description=description_;

          } 
          public string Get_email()
          {
            return $"{email},{type} , {description}";
          }
        
    }
}