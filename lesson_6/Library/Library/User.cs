using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class User
    {
        public string User_Name;
        public string Password;
    }

    public User(string user_name, string password)
    {
        User_Name = user_name;
        Password = password;
        
    }

    public void info(string user_name, string password)
    {
        var d = new Dictionary<string, string>();
        d.Add(user_name, password);       
    }


    public override string ToString()
    {
        

    }
}
