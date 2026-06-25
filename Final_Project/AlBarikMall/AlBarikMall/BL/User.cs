using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlBarikMall.BL
{
    public class User
    {
        protected string Name;
        protected string Gmail;
        protected string Password;
        protected string Gender;
        protected string Role;
        protected string Cnic;
        public User(string Gmail, string Password)
        {
            this.Gmail = Gmail;
            this.Password = Password;
        }
        public User(string Gmail)
        {
            this.Gmail = Gmail;

        }
        public User(string name, string gmail, string password, string gender, string type, string cnic)
        {
            Name = name;
            Gmail = gmail;
            Password = password;
            Gender = gender;
            Role = type;
            Cnic = cnic;
        }
        public User(string name, string gmail, string password, string gender, string cnic)
        {
            Name = name;
            Gmail = gmail;
            Password = password;
            Gender = gender;
            Cnic = cnic;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetGmail(string gmail)
        {
            Gmail = gmail;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
        public void SetGender(string gender)
        {
            Gender = gender;
        }
        public void SetRole(string type)
        {
            Role = type;
        }
        public void SetCnic(string cnic)
        {
            Cnic = cnic;
        }
        public string GetGmail()
        {
            return Gmail;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public string GetCnic()
        {
            return Cnic;
        }
        public string GetRole()
        {
            return Role;
        }
        public string GetPassword()
        { return Password; }
    }
}
