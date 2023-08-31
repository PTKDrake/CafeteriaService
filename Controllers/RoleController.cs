using CafeteriaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Controllers
{
    public class RoleController
    {
        private readonly CafeteriaDbContext _context;

        public RoleController(CafeteriaDbContext context)
        {
            _context = context;

        }

        public Role SaveRole(string? name, List<Permission>? permissions, int? id)
        {
            if (id != null)
                return SaveRole((int)id, name, permissions);
            if (name != null)
                return SaveRole(name, permissions);
            throw new Exception("Invalid parameters!");
        }

        public Role SaveRole(int id, string? name = null, List<Permission>? permissions = null)
        {
            Role? role = _context.Roles.SingleOrDefault(i => i.Id == id);
            if (role == null) throw new Exception("Role not found!");
            role.Name = name ?? role.Name;
            role.Permissions = permissions ?? new List<Permission>();
            _context.Roles.Update(role);
            _context.SaveChanges();
            return role;
        }

        public Role SaveRole(string name, List<Permission>? permissions = null)
        {
            Role role = new Role
            {
                Name = name,
                Permissions = permissions ?? new List<Permission>()
            };
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }

        public void RemoveRole(Role role)
        {
            _context.Roles.Remove(role);
            _context.SaveChanges();
        }

        public Role? GetRole(string name)
        {
            return _context.Roles.SingleOrDefault(item => item.Name == name);
        }

        public Role? GetRole(int id)
        {
            return _context.Roles.SingleOrDefault(item => item.Id == id);
        }
    }
}
