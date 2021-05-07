using GymWebApp.Models;
using GymWebApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Utility
{
    public static class JudgeUtility
    {
        public static JudgeViewModel GetViewModel(this Judges judge)
        {
            var judgeVM = new JudgeViewModel()
            {
                Name = judge.Name,
                AgeSections = judge.AgeSections,
                Apparatuss = judge.Apparatuss
            };
            return judgeVM;
        }
        public static List<JudgeViewModel> GetViewModel(this List<Judges> judges)
        {
            var alljudgesVM = new List<JudgeViewModel>();
            foreach (var judge in judges)
            {
                alljudgesVM.Add(new JudgeViewModel()
                {

                    Name = judge.Name,
                    AgeSections = judge.AgeSections,
                    Apparatuss = judge.Apparatuss
                });
            }
            return alljudgesVM;
        }
    }
}
