using EKStore.Areas.Admin.Services.Interfaces;
using EKStore.GenericModels;
using EKStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EKStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        IAdminCategoryService _categoryService;
        private readonly UploadImage uploadImage;

        public CategoryController(IAdminCategoryService categoryService,UploadImage uploadImage)
        {
            _categoryService = categoryService;
            this.uploadImage = uploadImage;
        }


        // GET: CategoryController
        public async Task<ActionResult> Index()
        {
            var list=await _categoryService.GetAllAsync();
            return View(list);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                var files=HttpContext.Request.Form.Files;
                string image = uploadImage.Image(files, "Category");
                category.Image= image==null?"emptyCategory.jpg":image;

                TempData["Message"] = await _categoryService.AddAsync(category) ? "Category Added Successful" : "";

            }
            


            return View();
            
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
