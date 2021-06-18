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
            var contacts = new Contacts[]
            {
                new Contacts{FirstName="s",LastName="p",EmailAddress="sp@gmail.com"},
                new Contacts{FirstName="a",LastName="p",EmailAddress="ap@gmail.com"},
                new Contacts{FirstName="m",LastName="p",EmailAddress="mp@gmail.com"}
            };
            foreach (Contacts c in contacts )
            {
                context.contacts.Add(c);
            }
            context.SaveChanges();

            var emailaddress = new EmailAddress[]
          {
                new EmailAddress{email="sp@gmail.com"},
                new EmailAddress{email="ap@gmail.com"},
                new EmailAddress{email="mp@gmail.com"}
          };
            foreach (EmailAddress e in emailaddress)
            {
                context.contacts.Add(e);
            }
            context.SaveChanges();
        }
    }
}
