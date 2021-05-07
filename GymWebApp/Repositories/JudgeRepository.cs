using GymWebApp.Data;
using GymWebApp.Interfaces;
using GymWebApp.Models;
using GymWebApp.Repositories;

public class JudgeRepository : Repositories<Judges>, IJudgeRepository
{
    public JudgeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
//public class PieceRepository : Repositories<Gymnast.Piece>, IPieceRepository
//{
//    public PieceRepository(ApplicationDbContext dbContext) : base(dbContext) { }
//}
//}
//public class AgeCategoryRepository : Repositories<Gymnast.AgeCategory>, IAgeCategoryRepository
//{
//    public AgeCategoryRepository(ApplicationDbContext dbContext) : base(dbContext) { }
//}
//}
