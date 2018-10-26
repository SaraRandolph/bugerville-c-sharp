using System;
using System.Collections.Generic;
using System.Text;

namespace Burgershack.Entities
{
    public class Menu
    {
        public Menu()
        {
            public List<Burger> Burgers { get; set; }
            public List<Drink> Drinks { get; set; }
            public List<Side> Sides { get; set; }
        }
    }
}
