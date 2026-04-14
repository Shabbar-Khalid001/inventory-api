using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    private readonly AppDbContext _context;

    public InventoryController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult Get(int page = 1, int pageSize = 50, string? search = null)
    {
        var query = _context.Inventories.AsQueryable();

        // 🔍 GLOBAL SEARCH (full DB)
        if (!string.IsNullOrEmpty(search))
        {
            var keyword = search.ToLower();

            query = query.Where(x =>
                x.ITEMS_DESCRIPTIONS.ToLower().Contains(keyword) ||
                x.Code.ToLower().Contains(keyword)
            );
        }

        // 📊 TOTAL COUNT
        var totalRecords = query.Count();

        // 📄 PAGINATION
        var data = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        // 📦 RESPONSE OBJECT
        return Ok(new
        {
            totalRecords,
            page,
            pageSize,
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize),
            data
        });
    }

}