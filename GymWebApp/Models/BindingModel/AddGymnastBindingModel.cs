using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Models.BindingModel
{
    public class AddGymnastBindingModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gymnast.AgeCategory AgeSection { get; set; }
        public string Nationality { get; set; }
        public Gymnast.Piece Apparatus { get; set; }
        public Gymnast.AgeCategory AgeCategory { get; internal set; }
    }
}
