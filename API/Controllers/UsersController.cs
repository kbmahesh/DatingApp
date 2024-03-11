using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[Controller]")] //api/users
public class UsersController:ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context;
    }

    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.appUsers.ToListAsync();
        return users;
    }

    [HttpGet] //api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.appUsers.FindAsync(id);
    }

}
