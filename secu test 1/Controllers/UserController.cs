﻿using secu_test_1.Model;
using secu_test_1.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.Data;

namespace secu_test_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return FakeDB.users;
        }

        [HttpGet("{email}")]
        public IEnumerable<User> Get(string email)
        {
            return FakeDB.users;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id) 
        {
            var user = FakeDB.users[id];
            FakeDB.users.Remove(user);
            return NoContent();
        }

        [HttpPost("Login")]
        public IActionResult Login()
        {
            var user = FakeDB.users;
            return NoContent();
        }

    }
}
