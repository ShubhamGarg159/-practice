using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UserRegistration.Models
{
    public class UserModel
    {
        [Required]
        public string FirstName 
        { 
            get; 
            set; 
        }
        [Required]
        public string LastName 
        {
            get;
            set;
        }
       [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage=("Invalid EmailID"))]  
        public string EmailID 
        { 
           get;
           set;
        }
        [Required]
        public string Mobile 
        { 
            get; 
            set;
        }
        [Required]
        public string Password 
        { 
            get; 
            set; 
        }
        [Compare("Password")]
        public string  ConfirmPassword 
        { 
            get; 
            set; 
        }
        [Required]
        public DateTime DOB 
        { 
            get; 
            set; 
        }
        [Required]
        public string District 
        { 
            get;
            set; 
        }
    }
}