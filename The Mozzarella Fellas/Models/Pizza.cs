using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Mozzarella_Fellas.Models
{
    public class Pizza
    {
        public int Id {get; set; }
        public string Name { get; set; }
        public string[] Toppings { get; set; }
        // String = type eg family, normal ect and int = price
        public Dictionary<string, int> Type { get; set; }


    }
}