using Microsoft.AspNetCore.Mvc;
using Task_PurpleBuzz.DAL;
using Task_PurpleBuzz.Models;
using Task_PurpleBuzz.ViewModels.WorkCategory;

namespace Task_PurpleBuzz.Controllers
{
	public class WorkCategoryController : Controller
	{
        private readonly AppDbContext _context;

        public WorkCategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Create(WorkCategoryCreateVM model)
        {
            if (!ModelState.IsValid) return View();

            var workCategory = _context.WorkCategories.FirstOrDefault(wc => wc.Name.ToLower() == model.Name.ToLower());
            if(workCategory is not null)
            {
                ModelState.AddModelError("Name", "There exists category with this name");
                return View();
            }

            workCategory = new WorkCategory
            {
                Name = model.Name,
                Desc = model.Desc,
            };

            _context.WorkCategories.Add(workCategory);
            _context.SaveChanges();

			return Ok(workCategory);
        }
    }
}
