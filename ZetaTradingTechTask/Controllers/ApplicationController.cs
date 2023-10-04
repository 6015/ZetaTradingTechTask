using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZetaTradingTechTask.Models;

namespace ZetaTradingTechTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
	{

        private readonly ApplicationDbContext _context;

        public ApplicationController(ApplicationDbContext context)
		{
            _context = context;
		}

        [HttpGet]
        public async Task<ActionResult<List<JournalRecord>>> Get()
        {
            return Ok(await _context.JournalRecords.ToListAsync());
        }

        [HttpPost("{node}")]
        public async Task<ActionResult<Node>> AddNode(Node node)
        {
            JournalRecord exception;
            if (node.Name == "test")
            {
                exception = new SecureException("You have to delete all children nodes first");
            }
            else
            {
                exception = new JournalRecord("Test");
                await _context.JournalRecords.AddAsync(exception);
                _context.SaveChanges();
            }

            return Ok(exception);
        }


    }
}

