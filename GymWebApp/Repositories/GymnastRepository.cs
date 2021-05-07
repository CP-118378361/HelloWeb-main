using GymWebApp.Data;
using GymWebApp.Interfaces;
using GymWebApp.Models;
using GymWebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GymWebApp.Repositories
{
    public class GymnastRepository:Repositories<Gymnast>, IGymnastRepository
    {
        public GymnastRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
//public class PieceRepository : Repositories<Gymnast.Piece>, IPieceRepository
//{
//    public PieceRepository(ApplicationDbContext dbContext) : base(dbContext) { }
//}
//}
//public class AgeCategoryRepository : Repositories<Gymnast.AgeCategory>, IAgeCategoryRepository
//{
//   public AgeCategoryRepository(ApplicationDbContext dbContext) : base(dbContext) { }
//}
