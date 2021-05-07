using GymWebApp.Data;
using GymWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        ApplicationDbContext _repoContext;
        public RepositoryWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;
        }
        IGymnastRepository _gymnast;

        IJudgeRepository _judge;

        //IAgeCategoryRepository _ageCategory;

        //IPieceRepository _piece;
        public IGymnastRepository Gymnasts
        {
            get
            {
                if( _gymnast == null)
                {
                    _gymnast = new GymnastRepository(_repoContext);
                }
                return _gymnast;
            }
        }
        public IJudgeRepository Judges
        {
            get
            {
                if (_judge== null)
                {
                    _judge = new JudgeRepository(_repoContext);
                }
                return _judge;
            }
        }
        //public IAgeCategoryRepository AgeCategory
        //{
        //    get
        //    {
        //        if (_ageCategory == null)
        //        {
        //            _ageCategory = new AgeCategoryRepository(_repoContext);
        //        }
        //        return _ageCategory;
        //    }
        //}
        void IRepositoryWrapper.Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
