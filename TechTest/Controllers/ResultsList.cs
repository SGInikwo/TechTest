using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechTest.Data;
using TechTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsList : Controller
    {
        private readonly ApplicationDbContext _context;
        public ResultsList(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<NumberList>> Get()
        {
            return await _context.NumberLists.ToListAsync();
        }

    }
}
