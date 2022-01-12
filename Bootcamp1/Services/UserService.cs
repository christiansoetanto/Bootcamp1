﻿using Bootcamp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bootcamp1.Services
{
    public class UserService : Controller
    {

        private readonly BootcampDBContext _dbContext;
        public UserService(BootcampDBContext dBContext)
        {
            this._dbContext = dBContext;
        }

        public List<UserModel> GetUsers()
        {

            var users = _dbContext.User.FromSqlInterpolated($"EXECUTE GetUsers").ToList();
            return users;

        }

    }
}
