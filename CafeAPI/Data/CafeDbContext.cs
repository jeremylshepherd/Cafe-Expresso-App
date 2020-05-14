using System;
using CafeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeAPI.Data
{
    public class CafeDbContext : DbContext
    {
        public CafeDbContext(DbContextOptions<CafeDbContext> options) : base(options)
        {

        }

        public DbSet<MenuModel> Menus { get; set; }
        public DbSet<SubMenuModel> SubMenus { get; set; }
        public DbSet<ReservationModel> Reservations { get; set; }
    }
}