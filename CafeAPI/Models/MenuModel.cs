using System;
using System.Collections.Generic;

namespace CafeAPI.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<SubMenuModel> SubMenus { get; set; }

        public MenuModel()
        {
        }
    }
}
