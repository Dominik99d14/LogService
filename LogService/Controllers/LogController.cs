using LogService.Data;
using Microsoft.AspNetCore.Mvc;

namespace LogService.Controllers
{
    [ApiController]
    [Route("api/logs")]
    public class LogController : ControllerBase
    {
        private readonly LogDbContext _context;

        public LogController(LogDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> LogMessage([FromBody] LogEntry logEntry)
        {
            _context.LogEntries.Add(logEntry);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetLogs()
        {
            var logs = await _context.LogEntries.OrderByDescending(l => l.Timestamp).ToListAsync();
            return Ok(logs);
        }
    }

}
