using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly DataContext _context;

        public AccountsController(DataContext context){
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppAccount>> GetAccount(int id) {
            return await _context.Accounts.FindAsync(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppAccount>>> GetAccounts() {
            return await _context.Accounts
                .Include( u => u.Users )
                .ToListAsync();
        }
    }
}