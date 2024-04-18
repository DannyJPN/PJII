using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManaging
{
    public class Contact
    {
        public Contact(string name, byte age, string email, double weight, bool isalive)
        {
            Name = name;
            Age = age;
            Email = email;
            Weight = weight;
            IsAlive = isalive;
        }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
        public double Weight { get; set; }
        public bool IsAlive { get; set; }

    }
}
