using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMWRK
{
    public class User
    {
        private string text;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public override string ToString() => $"{Name}";
        public User(string name, string surname, string email, string phone, DateTime birthD)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            DOB = birthD;
        }


        public void Change(User user)
        {
            Name = user.Name;
            Surname = user.Surname;
            Email = user.Email;
            Phone = user.Phone;
            DOB = user.DOB;
        }

    }
}
