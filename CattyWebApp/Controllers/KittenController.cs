using CattyWebApp.Data;
using CattyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kittentyWebApp.Controllers
{
    [Route("[Controller]/[Action]")]
    public class KittensController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public KittensController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allkittens = dbContext.Kittens.ToList();
            return View(allkittens);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var kittenById = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            return View(kittenById);
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var kittenById = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            return View(kittenById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Kitten kitten, int id)
        {
            var kittenToUpdate = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            kittenToUpdate.Name = kitten.Name;
            kittenToUpdate.Age = kitten.Age;
            kittenToUpdate.PictureURL = kitten.PictureURL;
            //kittenToUpdate.Size = kitten.Size;
            kittenToUpdate.Color = kitten.Color;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var kittenToDelete = dbContext.Kittens.FirstOrDefault(c => c.ID == id);
            dbContext.Kittens.Remove(kittenToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

