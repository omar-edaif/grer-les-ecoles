using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_fin_formation
{
   public  class User
    {
        public User()
        {

        }
        //public User(int id, string name,Role role)
        //{
        //    Id = id;
        //    Username = name;
        //    Role = role;
        //}
        public int Id { get; set; }
        public string Username { get; set; }
        public int IdRole { get; set; }
        public string Role { get; set; }
        public List<string> Permissions { get; set; }
    }
    public class Role
    {
        public Role(int id ,string name, List<string> permissions)
        {
            Id = id;
            Name = name;
            Permissions = permissions;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<String> Permissions { get; set;}
    }
}
