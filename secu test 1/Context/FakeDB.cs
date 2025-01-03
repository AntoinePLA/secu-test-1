using secu_test_1.Model;

namespace secu_test_1.Context
{
    public class FakeDB
    {
        public static List<User> users = new List<User>
        {
            new User(1, "Antoine", "Atp@gmail.com", "atp123456"),
            new User(2, "Armand", "Arm@gmail.com", "Arm123456"),
            new User(3, "Eric", "Erc@gmail.com", "Erc123456")
        };
    }
}
