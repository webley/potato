using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potato
{
    /// <summary>
    /// Represents a potato-user.  One who uses potatoes.
    /// </summary>
    public class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PotatoScore { get; set; }
    }
}
