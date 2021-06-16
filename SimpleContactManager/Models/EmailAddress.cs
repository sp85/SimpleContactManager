using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleContactManager.Models
{
    public class EmailAddress
    {
        public bType? bType { get; set; }

        public string email { get; set; }

    }

    public enum bType
    {
        personal,
        business
    }
}
