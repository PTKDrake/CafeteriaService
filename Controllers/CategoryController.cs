using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaService.Models;

namespace CafeteriaService.Controllers
{
    public class CategoryController
    {
        private readonly CafeteriaDbContext _context;
        public CategoryController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public Category SaveCategory(string name, string description = "", int? id = null)
        {
            Category? category = null;
            if (id != null)
            {
                category = _context.Categories.FirstOrDefault(c => c.Id == id);
                if(category != null)
                {
                    category.Name = name;
                    category.Description = description;
                }
            }
            if(category == null){
                category = new Category
                {
                    Name = name,
                    Description = description
                };
                _context.Categories.Add(category);
            }

            _context.SaveChanges();
            return category;
        }

        public void RemoveCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category? GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> SearchCategories(string name)
        {
            return (from c in _context.Categories where c.Name.ToLower().StartsWith(name.ToLower()) select c).ToList();
        }
    }
}
