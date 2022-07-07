using Microsoft.AspNetCore.Mvc;
using PluginFramework.Models;

namespace PluginFramework.Controllers
{
    public class ImageController : Controller
    {
        private readonly ImageDbContext _context;

        public List<Image> Images = new List<Image>();
        public ImageController(ImageDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            Images = _context.Images.ToList();
            return View(Images);
        }

        public IActionResult OnGetMyOnClick()
        {
            return View();
        }




    }
}
