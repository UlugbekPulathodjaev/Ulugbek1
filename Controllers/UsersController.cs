using EntityEntry.DataAccess;
using adonetGet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace adonetGet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ApplicationDbContext _context;
        public UsersController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<User> value = await _context.Users.AsNoTracking().ToListAsync();

                if (value is not null)
                {
                    return Ok(value);
                }
                return NotFound("Malumot topilmadi");

            }
            catch (SystemException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
