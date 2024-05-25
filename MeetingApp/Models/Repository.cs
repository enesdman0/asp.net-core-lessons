namespace MeetingApp.Models
{
    public static class Repository
    {
        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Ali", Email = "abc@gmail.com", Phone = "5415555555", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Mehmet", Email = "def@gmail.com", Phone = "5415555555", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Enes", Email = "hij@gmail.com", Phone = "5415555555", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4, Name = "Mustafa", Email = "klm@gmail.com", Phone = "5415555555", WillAttend = false });
        }
        private static List<UserInfo> _users = new();
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }

}
