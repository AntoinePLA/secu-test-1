using Microsoft.AspNetCore.Identity.Data;

namespace secu_test_1.Model
{
    public class User
    {
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Login(string email, string password)
        {
            if
        };
    }
}
