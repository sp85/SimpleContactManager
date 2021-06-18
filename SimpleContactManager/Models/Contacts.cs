using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleContactManager.Models
{
    public class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("EmailAddress")]
        public string EmailAddress { get; set; }
    }
}
