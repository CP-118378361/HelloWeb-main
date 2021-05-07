using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GymWebApp.Models.Gymnast;

namespace GymWebApp.Interfaces
{
    public class IAddGymnast
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public AgeCategory AgeSection { get; set; }
        public string Nationality { get; set; }
        public string PictureURL { get; set; }
        public Piece Apparatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
