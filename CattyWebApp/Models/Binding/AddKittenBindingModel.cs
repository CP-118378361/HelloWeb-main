using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CattyWebApp.Models.Binding
{
    public class AddKittenBindingModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public Size Size { get; set; }
        public string Color { get; set; }
        public int CatID { get; set; }
    }
}
