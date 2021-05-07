using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Models.BindingModel
{
    public class AddJudgesBindingModel
    {
        

        public string Name { get; set; }
        public int Age { get; set; }
        public Gymnast.AgeCategory AgeSections { get; set; }
        public Gymnast.Piece Apparatuss { get; set; }
        public int GymnastID { get; set; }
    }
}

  

