using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Interfaces
{
    public class IGymnastViewModel
    {
        public IGymnast gymnast { get; set; }
        public IList<IGymnast> Gymnasts { get; set; }
    }
}
