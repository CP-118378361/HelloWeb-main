using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebApp.Models.Binding
{
    public class AddCatBindingModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public Size Sizes { get; set; }
        public string Color { get; set; }
        //public Cat.Size Size { get; internal set; }
    }
}
