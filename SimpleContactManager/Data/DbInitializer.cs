using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleContactManager.Models;

namespace SimpleContactManager.Data
{
    public static class DbInitializer
    {

        public static void Initializer (ContactContext context)
        {
            context.Database.EnsureCreated();

            if (context.contacts.Any())
            {
                return;
            }
           // EmailAddress e1 = new EmailAddress("sp@gmail.com");
            var contacts = new Contacts[]
            {
                new Contacts{FirstName="s",LastName="p"},
                new Contacts{FirstName="a",LastName="p"},
                new Contacts{FirstName="m",LastName="p"}
            };
            foreach (Contacts c in contacts )
            {
                context.contacts.Add(c);
            }
            context.SaveChanges();

            var emailaddress = new EmailAddress[]
          {
                new EmailAddress("sp@gmail.com"),
                new EmailAddress("ap@gmail.com"),
                new EmailAddress("mp@gmail.com")
          };
            foreach (EmailAddress e in emailaddress)
            {
                context.EmailAddresses.Add(e);
            }
            context.SaveChanges();
        }
    }
}
