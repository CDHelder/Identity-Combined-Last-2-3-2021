using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepairMvc.Database;
using RepairMvc.Domain.Models;
using RepairMvc.Services;

namespace RepairMvc.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IImageService imageService;

        public CreateModel(ApplicationDbContext context,
            IWebHostEnvironment webHostEnvironment,
            IImageService imageService)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
            this.imageService = imageService;
        }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (Photo != null)
            //{
            //    if (Order.PhotoPath != null)
            //    {
            //        string filePath = Path.Combine(webHostEnvironment.WebRootPath,
            //            "images", Order.PhotoPath);
            //        System.IO.File.Delete(filePath);
            //    }

            //    Order.PhotoPath = ProcessUploadedFile();
            //}

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Photo.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
