using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaService.Models;
using Image = CafeteriaService.Models.Image;

namespace CafeteriaService.Controllers
{
    public class ItemController
    {
        private readonly CafeteriaDbContext _context;

        public ItemController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public Item SaveItem(string? name, List<Category>? categories, decimal? price, string? description, int? inStock,
            List<Image>? images, int? id)
        {
            if (id != null)
                return SaveItem((int)id, name, categories, price, description, inStock, images);
            if (name != null && categories != null && price != null && description != null && inStock != null)
                return SaveItem(name, categories, (decimal)price, description, (int)inStock, images);
            throw new Exception("Invalid parameters!");
        }

        public Item SaveItem(int id, string? name = null, List<Category>? categories = null, decimal? price = null, string? description = null,
            int? inStock = null, List<Image>? images = null)
        {
            Item? item = _context.Items.SingleOrDefault(i => i.Id == id);
            if (item == null) throw new Exception("Item not found!");
            item.Name = name ?? item.Name;
            item.Categories = categories ?? item.Categories;
            item.Price = price ?? item.Price;
            item.Description = description ?? item.Description;
            item.InStock = inStock ?? item.InStock;
            item.Images = images ?? item.Images;
            _context.SaveChanges();
            return item;
        }

        public Item SaveItem(string name, List<Category> categories, decimal price, string description = "", int inStock = 0,
            List<Image>? images = null)
        {
            Item item = new Item
            {
                Name = name,
                Categories = categories,
                Price = price,
                Description = description,
                InStock = inStock,
                Images = images
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