using CafeteriaService.Models;

namespace CafeteriaService.Controllers
{
    public class UserController
    {
        private readonly CafeteriaDbContext _context;

        public UserController(CafeteriaDbContext context)
        {
            _context = context;

        }

        public string ResetPassword(User user)
        {
            string password = GeneratePassword(20);
            user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(password);
            _context.SaveChanges();
            return password;
        }

        public bool Login(string username, string password)
        {
            User? user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;
            return BCrypt.Net.BCrypt.EnhancedVerify(password, user.Password);
        }

        public User SaveUser(string? username, string? password, Role? role, List<Permission>? permissions, int? id)
        {
            if (id != null)
                return SaveUser((int)id, username, password, role, permissions);
            if (username != null && password != null && role != null)
                return SaveUser(username, password, role, permissions);
            throw new Exception("Invalid parameters!");
        }

        public User SaveUser(int id, string? username = null, string? password = null, Role? role = null, List<Permission>? permissions = null)
        {
            User? user = _context.Users.SingleOrDefault(i => i.Id == id);
            if (user == null) throw new Exception("User not found!");
            user.Username = username ?? user.Username;
            if (password != null) user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(password);
            user.Role = role ?? user.Role;
            user.Permissions = permissions ?? new List<Permission>();
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public User SaveUser(string username, string password, Role role, List<Permission>? permissions = null)
        {
            User user = new User
            {
                Username = username,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(password),
                Role = role,
                Permissions = permissions ?? new List<Permission>()
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void RemoveUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public User? GetUser(string username)
        {
            return _context.Users.SingleOrDefault(item => item.Username == username);
        }

        public User? GetUser(int id)
        {
            return _context.Users.SingleOrDefault(item => item.Id == id);
        }

        private string GeneratePassword(ushort length)
        {
            Random res = new Random();
            String pattern = "abcdefghijklmnopqrstuvwxyz0123456789";
            String password = "";

            for (int i = 0; i < length; i++)
            {
                int x = res.Next(pattern.Length);
                password += pattern[x];
            }
            return password;
        }
    }
}
