using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Interfaces
{
    public interface IRepositoryWrapper
    {
        IGymnastRepository Gymnasts { get;}
        IJudgeRepository Judges { get; }
       // IAgeCategoryRepository ageCategory { get; }
       // IPieceRepository Piece { get; }

        void Save();
    }
}
