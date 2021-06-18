using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleContactManager.Models
{
    public class EmailAddress
    {
        
        //public EmailAddress (string name)
        //{
        //    email = name;

        //}
        
        [Key]
        public int emailID  { get; set; }
        public bType? bType { get; set; }
    
        public string email { get; set; }

    }

    public enum bType
    {
        personal,
        business
    }
}
