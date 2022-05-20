﻿using System;
using Microsoft.EntityFrameworkCore;

namespace lab3last.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
