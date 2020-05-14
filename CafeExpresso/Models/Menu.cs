using System;
using System.Collections.Generic;

namespace CafeExpresso.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri Image { get; set; }
        public List<SubMenu> SubMenus { get; set; }
    }

    public class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Image { get; set; }
        public string Price { get; set; }
    }
}
