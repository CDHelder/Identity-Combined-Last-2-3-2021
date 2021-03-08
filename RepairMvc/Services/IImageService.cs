using Microsoft.AspNetCore.Http;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairMvc.Services
{
    public interface IImageService
    {
        public bool SaveImage(IFormFile file, string path, int OrderId);
        public void GetImage();
    }
}
