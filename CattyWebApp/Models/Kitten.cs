using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CattyWebApp.Models
{
    public class Kitten
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PictureURL { get; set; }
        //public Size Size { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Cat Cat { get; set; }
    }
}

