﻿using Microsoft.EntityFrameworkCore;

namespace AlstromsStatusProject_Backend.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options) { }

        public DbSet<Item>? Items { get; set; }
    }
}
