using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Interfaces
{
    public class IJudgeViewModel
    {
        public IJudge judge { get; set; }
        public IList<IJudge> Judges { get; set; }
    }
}
