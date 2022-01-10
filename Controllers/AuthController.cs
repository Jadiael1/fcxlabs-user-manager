using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDAPI.Data;

namespace CRUD_API_ASPNET_DOTNET_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        private static Random random = new Random();

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{login}/{password}")]
        public async Task<ActionResult<User>> Auth(string login, string password)
        {
            var user = await _context.Users
                        .Where(u => u.login == login && u.password == password && u.status == true)
                        .FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<User>> ResetCredential(string email)
        {

            var user = _context.Users
                        .Where(u => u.email == email && u.status == true)
                        .FirstOrDefault();

            if (user != null)
            {
                user.password = RandomString(6);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }

            return user;
        }

        [Route("/api/query")]
        [HttpPost]
        public async Task<IEnumerable<User>> UserQuery(UserQueryController uq)
        {
            var users = await _context.Users
                        .Where(u => (Convert.ToUInt32(uq.status) < 2) ? u.status == Convert.ToBoolean(uq.status) : (u.status == true || u.status == false)
                            && (!String.IsNullOrEmpty(uq.user)) ? u.name == uq.user : u.name != ""
                            && (!String.IsNullOrEmpty(uq.login)) ? u.login == uq.login : u.login != ""
                        )
                        .Where(u => u.birth_date > uq.birthDayInitial && u.birth_date < uq.birthDayLast)
                        .Where(u => u.created_at > uq.firstRegistration && u.created_at < uq.lastRegistration)
                        .Where(u => u.updated_at > uq.initialUpdate && u.updated_at < uq.lastUpdate)
                        .Where(u => (uq.ageGroup == 1) ? (DateTime.UtcNow.Year - u.birth_date.Value.Year) > 18 && (DateTime.UtcNow.Year - u.birth_date.Value.Year) < 26 :
                            (uq.ageGroup == 2) ? (DateTime.UtcNow.Year - u.birth_date.Value.Year) > 25 && (DateTime.UtcNow.Year - u.birth_date.Value.Year) < 31 :
                            (uq.ageGroup == 3) ? (DateTime.UtcNow.Year - u.birth_date.Value.Year) > 30 && (DateTime.UtcNow.Year - u.birth_date.Value.Year) < 36 :
                            (uq.ageGroup == 4) ? (DateTime.UtcNow.Year - u.birth_date.Value.Year) > 35 && (DateTime.UtcNow.Year - u.birth_date.Value.Year) < 41 :
                            (uq.ageGroup == 5) ? (DateTime.UtcNow.Year - u.birth_date.Value.Year) > 40 :
                            u.birth_date.Value.Year > DateTime.MinValue.Year
                        )
                        .ToListAsync();
            if (users == null)
            {
                return Enumerable.Empty<User>();
            }
            return users;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }
}