using CattyWebApp.Data;
using CattyWebApp.Models;
using CattyWebApp.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CattyWebApp.Controllers
{
    [Route("[Controller]")]
    public class CatsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public CatsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allCats = dbContext.Cats.ToList();
            return View(allCats);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            return View(catById);
        }

        //CREATE
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddCatBindingModel bindingModel)
        {
            var catToCreate = new Cat
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                //Size = bindingModel.Size,
                Color = bindingModel.Color,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            dbContext.Cats.Add(catToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //Kitten Section
        //CREATE
        [Route("addkitten/{catID:int}")]
        public IActionResult CreateKitten(int catID)
        {
            var cat = dbContext.Cats.FirstOrDefault(c => c.ID == catID);
            ViewBag.CatName = cat.Name;
            return View();
        }
        [HttpPost]
        [Route("addkitten/{catID:int}")]
        public IActionResult CreateKitten(AddKittenBindingModel bindingModel, int catID)
        {
            bindingModel.CatID = catID;
            var kittenToCreate = new Kitten
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                //Size = bindingModel.Size,
                Cat = dbContext.Cats.FirstOrDefault(c => c.ID == catID),
                Color = bindingModel.Color,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            dbContext.Kittens.Add(kittenToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/kittens")]
        public IActionResult ViewKittens(int id)
        {
            var cat = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            var kittens = dbContext.Kittens.Where(c => c.Cat.ID == id).ToList();
            ViewBag.CatName = cat.Name;
            return View(kittens);
        }
        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            return View(catById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Cat cat, int id)
        {
            var catToUpdate = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            catToUpdate.Name = cat.Name;
            catToUpdate.Age = cat.Age;
            catToUpdate.PictureURL = cat.PictureURL;
            //catToUpdate.Size = cat.Size;
            catToUpdate.Color = cat.Color;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var catToDelete = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            dbContext.Cats.Remove(catToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
