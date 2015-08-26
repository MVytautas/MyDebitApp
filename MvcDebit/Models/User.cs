using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDebit.Models
{
    public class User
    {
        public string Name
        {
            get;
            set;
        }

        public User(string user, int Age, string password)
        {
            Name = user;
            pass = password;
            age = Age;
        }

        public string pass
        {
            get;
            set;
        }

        public string email
        {
            get;
            set;
        }

        public string phoneNo
        {
            get;
            set;
        }

        public string address
        {
            get;
            set;
        }

        public string city
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }
    }

}