using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleContactManager.Models
{
    public class Contacts
    {
        [Key]
        public int contactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey ("email")]
        public EmailAddress EmailAddress { get; set; }
    }
}
