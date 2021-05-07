using System;
using GymWebApp.Data;
using GymWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymWebApp.Interfaces;

namespace GymWebApp.Controllers
{
    [Route("[Controller]")]
    public class JudgeController : Controller
    {

        private ILogger<JudgeController> _logger;
        private IRepositoryWrapper repository;
        public JudgeController(ILogger<JudgeController> logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            repository = repositoryWrapper;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var alljudges = repository.Judges.FindAll();
            return View(alljudges);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var judgesById = repository.Judges.FindByCondition(c => c.ID == id).FirstOrDefault();
            return View(judgesById);
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var judgesById = repository.Judges.FindByCondition(c => c.ID == id).FirstOrDefault();
            return View(judgesById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Judges judge, int id)
        {
            var judgeToUpdate = repository.Judges.FindByCondition(c => c.ID == id).FirstOrDefault();
            judgeToUpdate.Name = judge.Name;
            judgeToUpdate.PictureURL = judge.PictureURL;
            judgeToUpdate.AgeSections = judge.AgeSections;
            judgeToUpdate.Apparatuss = judge.Apparatuss;
            repository.Save();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var judgeToDelete = repository.Judges.FindByCondition(c => c.ID == id).FirstOrDefault();
            repository.Judges.Delete(judgeToDelete);
            repository.Save();
            return RedirectToAction("Index");
        }
    }
}
