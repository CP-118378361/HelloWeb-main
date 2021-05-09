using Castle.Core.Logging;
using GymWebApp.Controllers;
using GymWebApp.Interfaces;
using GymWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Moq;
using Nest;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject
{
    public class GymnastControllerTest
    {
        private Mock<ILogger<GymnastsController>> _logger;
        private Mock<IRepositoryWrapper> mockRepo;
        private GymnastsController gymnastController;
        private IAddGymnast addGymnast;
        private IUpdateGymnast updateGymnast;
        private Gymnast gymnast;
        private List<Gymnast> gymnasts;
        private Mock<IGymnastViewModel> gymnastViewModelMock;
        private List<IGymnastViewModel> gymnastsViewModelMock;
        private Mock<IGymnast> gymnastMock;
        private List<IGymnast> gymnastsMock;
        private Mock<IAddGymnast> addGymnastMock;
        private List<IAddGymnast> addGymnastsMock;
        private Mock<IUpdateGymnast> updateGymnastMock;
        private List<IUpdateGymnast> updateGymnastsMock;
        public GymnastControllerTest()
        {
            gymnastMock = new Mock<IGymnast>();
            gymnastMock = new Mock<IGymnast>(gymnastMock.Object);
            addGymnastMock = new Mock<IAddGymnast>();
            updateGymnastMock = new Mock<IUpdateGymnast>();
            gymnast = new Gymnast();
            gymnasts = new List<Gymnast>();
            gymnastViewModelMock = new Mock<IGymnastViewModel>();
            //gymnastsViewModelMock = new Mock<IGymnastViewModel>();

            addGymnast = new IAddGymnast { Name = "Sunni", Age = 17, AgeSection = (Gymnast.AgeCategory)1, Apparatus = (Gymnast.Piece)1, Nationality = "USA", PictureURL = "" };
            updateGymnast = new IUpdateGymnast { Name = "Sunni", Age = 17, AgeSection = (Gymnast.AgeCategory)1, Apparatus = (Gymnast.Piece)3, Nationality = "USA", PictureURL = "" };
            
        _logger = new Mock<ILogger<GymnastsController>>();
        var judgesMock = new Mock<IJudge>();
        var judgesMock = new List<IJudge>() { judgesMock.Object };
        var judgesMock = new List<IActionResult>();

        mockRepo = new Mock<ILogger<GymnastsController>>();
        var allGymnasts = GetGymnats();
        gymnastController = new GymnastsController(_logger.Object, mockRepo.Object);
             
        
        
    }


        [Fact]
        public void GetAllGymnasts()
        {

        }
    private IEnumerable<Judges> GetJudges()
    {
        return new List<Judges>()
        {
            new Judges { ID =1 , },
            new Judges { ID = 2, }
        };
    }
    private Judges GetJudge()
    {
        return GetJudge();
    }
        private IEnumerable<Gymnast> GetGymnats()
        {
            var gymnats = new List<Gymnast>
            {
              //  new Gymnast = new List<Gymnast> {
               // new Gymnast()(Name = "Sunni", Page = 17, AgeSection = (Gymnast.AgeCategory)1, Apparatus = (Gymnast.Piece)1, Nationality = "USA", PictureURL = ""),
               // new Gymnast()(Name = "Sunni", Age = 17, AgeSection = (Gymnast.AgeCategory)1, Apparatus = (Gymnast.Piece)3, Nationality = "USA", PictureURL = "")
             };
        
        return gymnasts;
        }
    }
    }

