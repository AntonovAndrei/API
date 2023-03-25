using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostgrePersistence;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
    protected readonly DataContext _context;

    public AuthorController(DataContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public virtual async Task<IActionResult> List()
    {
        var entities = await _context.Authors.ToListAsync();

        return Ok(entities);
    }
}