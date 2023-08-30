using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaService.Models;
using Image = CafeteriaService.Models.Image;

namespace CafeteriaService.Controllers
{
    public class ImageController
    {
        private readonly CafeteriaDbContext _context;

        public ImageController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public Image CreateImage(string mimeType, byte[] data)
        {
            Image image = new Image
            {
                MimeType = mimeType,
                Data = data
            };
            _context.Images.Add(image);
            _context.SaveChanges();
            return image;
        }

        public void DeleteImage(Image image)
        {
            _context.Images.Remove(image);
            _context.SaveChanges();
        }

        public Image? GetImageById(int id)
        {
            return _context.Images.FirstOrDefault(x => x.Id == id);
        }
    }
}
