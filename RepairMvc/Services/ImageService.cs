using Microsoft.AspNetCore.Http;
using RepairMvc.Database;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RepairMvc.Services
{
    public class ImageService : IImageService
    {
        private readonly ApplicationDbContext context;

        public ImageService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void GetImage()
        {

        }

        public bool SaveImage(IFormFile file, string path, int OrderId)
        {
            try
            {
                var image = MapToImage(file, OrderId);
                using(var stream = new FileStream(Path.Combine(path, image.ImageFilePath), FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                context.Images.Add(image);

                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }

        private Image MapToImage(IFormFile file, int OrderId)
        {
            string name = $"{Guid.NewGuid().ToString()}_{file.FileName}";
            string folderPath = $"/images/{name}";
            var image = new Image()
            {
                ImageFilePath = folderPath,
                ImageName = name,
                OrderId = OrderId
            };
            return image;
        }
    }
}
