using System;
using GymWebApp.Data;
using GymWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    [Route("[Controller]")]
    public class JudgeController : Controller
    {

        private readonly ApplicationDbContext dbContext;
        public JudgeController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var alljudges = dbContext.Judges.ToList();
            return View(alljudges);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var judgesById = dbContext.Judges.FirstOrDefault(c => c.ID == id);
            return View(judgesById);
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var judgesById = dbContext.Judges.FirstOrDefault(c => c.ID == id);
            return View(judgesById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Judges judge, int id)
        {
            var kittenToUpdate = dbContext.Judges.FirstOrDefault(c => c.ID == id);
            kittenToUpdate.Name = judge.Name;
            kittenToUpdate.Age = judge.Age;
            kittenToUpdate.PictureURL = judge.PictureURL;
            kittenToUpdate.AgeSections = judge.AgeSections;
            kittenToUpdate.Apparatuss = judge.Apparatuss;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var judgeToDelete = dbContext.Judges.FirstOrDefault(c => c.ID == id);
            dbContext.Judges.Remove(judgeToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
