using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgorithm
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPreimium { get; set; }

        public User(string login, string name, bool isPreimium)
        {
            Login = login;
            Name = name;
            IsPreimium = isPreimium;
        }

    }
}
