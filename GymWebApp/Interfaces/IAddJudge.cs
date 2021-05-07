using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GymWebApp.Models.Gymnast;

namespace GymWebApp.Interfaces
{
    public class IAddJudge
    {
        public int ID { get; set; }
            public int Age { get; set; }
            public string PictureURL { get; set; }
            public AgeCategory AgeSections{ get; set; }
            public Piece Apparatuss{ get; set; }
            public DateTime CreatedAt { get; set; }
    }
}
