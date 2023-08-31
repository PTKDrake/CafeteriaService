using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaService.Models;

namespace CafeteriaService.Controllers
{
    public class ItemController
    {
        private readonly CafeteriaDbContext _context;

        public ItemController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public Item SaveItem(string? name, Category? category, decimal? price, string? description, int? inStock,
            string? imagePath, int? id)
        {
            if (id != null)
                return SaveItem((int)id, name, category, price, description, inStock, imagePath);
            if (name != null && category != null && price != null && description != null && inStock != null)
                return SaveItem(name, category, (decimal)price, description, (int)inStock, imagePath);
            throw new Exception("Invalid parameters!");
        }

        public Item SaveItem(int id, string? name = null, Category? category = null, decimal? price = null, string? description = null,
            int? inStock = null, string? imagePath = null)
        {
            Item? item = _context.Items.SingleOrDefault(i => i.Id == id);
            if (item == null) throw new Exception("Item not found!");
            item.Name = name ?? item.Name;
            item.Category = category ?? item.Category;
            item.Price = price ?? item.Price;
            item.Description = description ?? item.Description;
            item.InStock = inStock ?? item.InStock;
            item.ImagePath = imagePath ?? item.ImagePath;
            _context.Items.Update(item);
            _context.SaveChanges();
            return item;
        }

        public Item SaveItem(string name, Category category, decimal price, string description = "", int inStock = 0, string? imagePath = null)
        {
            Item item = new Item
            {
                Name = name,
                Category = category,
                Price = price,
                Description = description,
                InStock = inStock,
                ImagePath = imagePath
            };
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public void RemoveItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
        }

        public Item? GetItem(int id)
        {
            return _context.Items.SingleOrDefault(item => item.Id == id);
        }

        public List<Item> SearchItems(string name)
        {
            return (from item in _context.Items where item.Name.ToLower().StartsWith(name.ToLower()) select item).ToList();
        }
    }
}