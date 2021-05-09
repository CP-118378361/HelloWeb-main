using GymWebApp.Data;
using GymWebApp.Interfaces;
using GymWebApp.Models;
using GymWebApp.Models.BindingModel;
using GymWebApp.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;


namespace GymWebApp.Controllers
{
    [Route("[Controller]")]
    public class GymnastsController : Controller
    {
        private ILogger<GymnastsController> _logger;
        private IRepositoryWrapper repository;
        public GymnastsController(ILogger<GymnastsController> logger,IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            repository = repositoryWrapper;
        }
        #region Gymnast
        [Route("")]
        public IActionResult Index()
        {
            var allGymnasts = repository.Gymnasts.FindAll();
           // var allGymnasts = dbContext.Gymnasts.ToList();
            return View(allGymnasts);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var gymnastById = repository.Gymnasts.FindByCondition(c => c.ID == id).FirstOrDefault();
           // var gymnastById = dbContext.Gymnasts.FirstOrDefault(c => c.ID == id);
            return View(gymnastById);
        }
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddGymnastBindingModel bindingModel)
        {
            var gymnastToCreate = new Gymnast
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                AgeSection = bindingModel.AgeSection,
                Nationality = bindingModel.Nationality,
                Apparatus = bindingModel.Apparatus,
                PictureURL = "data:image/jpeg;base64,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",
                CreatedAt = DateTime.Now
            };
            repository.Gymnasts.Create(gymnastToCreate);
            //dbContext.Gymnasts.Add(gymnastToCreate);
            repository.Save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {

            var gymnastById = repository.Gymnasts.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var gymnastById = dbContext.Gymnasts.FirstOrDefault(c => c.ID == id);
            return View(gymnastById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Gymnast gymnast, int id)
        {

            var gymnastToUpdate = repository.Gymnasts.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var gymnastToUpdate = dbContext.Gymnasts.FirstOrDefault(c => c.ID == id);
            gymnastToUpdate.Name = gymnast.Name;
            gymnastToUpdate.Age = gymnast.Age;
            gymnastToUpdate.AgeSection = gymnast.AgeSection;
            gymnastToUpdate.PictureURL = gymnast.PictureURL;
            gymnastToUpdate.Nationality = gymnast.Nationality;
            gymnastToUpdate.Apparatus = gymnast.Apparatus;
            repository.Save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        //Delete
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {

            var gymnastToDelete = repository.Gymnasts.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var gymnastToDelete = dbContext.Gymnasts.FirstOrDefault(c => c.ID == id);
            repository.Gymnasts.Delete(gymnastToDelete);
            //dbContext.Gymnasts.Remove(gymnastToDelete);
            repository.Save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        //Judge Section
        //CREATE
        #region Judge
        [Route("addjudge/{gymnastID:int}")]
        public IActionResult Createjudge(int gymnastID)
        {

            var gymnast = repository.Gymnasts.FindByCondition(c => c.ID == gymnastID).FirstOrDefault();
            //var gymnast = dbContext.Gymnasts.FirstOrDefault(c => c.ID == gymnastID);
            ViewBag.GymnastName = gymnast.Name;
            ViewBag.GymnastID = gymnast.ID;
            return View();
        }
        [HttpPost]
        [Route("addjudge/{gymnastID:int}")]
        public IActionResult CreateJudge(AddJudgesBindingModel bindingModel, int gymnastID)
        {
            bindingModel.GymnastID = gymnastID;
            var judgesToCreate = new Judges
            {
                Name = bindingModel.Name,
                //Age = bindingModel.Age,
                AgeSections = bindingModel.AgeSections,
               // Gymnast = dbContext.Gymnasts.FirstOrDefault(c => c.ID == gymnastID),
                Gymnast = repository.Gymnasts.FindByCondition(c => c.ID == gymnastID).FirstOrDefault(),
                Apparatuss= bindingModel.Apparatuss,
                CreatedAt = DateTime.Now
            };
            repository.Judges.Create(judgesToCreate);
            // dbContext.Judges.Add(judgesToCreate);
            repository.Save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/judges")]
        public IActionResult ViewJudges(int id)
        {

           
            var gymnast = repository.Gymnasts.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var gymnast = dbContext.Gymnasts.FirstOrDefault(c => c.ID == id);

            var judges= repository.Gymnasts.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var judges = dbContext.Judges.Where(c => c.Gymnast.ID == id).ToList();
            ViewBag.GymnastName = gymnast.Name;
            return View(judges);
        }
        #endregion

        //Compete Section
    }
}


       