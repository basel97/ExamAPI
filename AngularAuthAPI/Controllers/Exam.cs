using AngularAuthAPI.Context;
using AngularAuthAPI.DTO;
using AngularAuthAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularAuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Exam : ControllerBase
    {
        AppDbContext _db;
        public Exam(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var topics = await _db.Topics.Include(e => e.Questions).ThenInclude(q => q.Options).ToListAsync();
            return Ok(topics);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == null)
                return BadRequest();
            var topic = await _db.Topics.Include(t => t.Questions).ThenInclude(q => q.Options).FirstOrDefaultAsync(t => t.ExamTopicId == id);
            if (topic == null)
                return NotFound(new { Message = "Not Found " });

            return Ok(topic);
        }
        [HttpPost("question")]
        public async Task<IActionResult> AddQuestion([FromBody] ExamQsOptDTO question)
        {

            if (question == null || question.options == null)
                return BadRequest();
            var q = new Question()
            {
                Head = question.Head,
                TopicId = question.TopicId,
            };
            await _db.Questions.AddAsync(q);
            _db.SaveChanges();
            var opts = new List<Option>();
         
            foreach (var opt in question.options)
            {
                var o = new Option()
                {
                    Value = opt.Value,
                    TrueValue = opt.TrueValue,
                    QuestionId = q.QuestionId,
                };
                opts.Add(o);
            }

         
            await _db.Options.AddRangeAsync(opts);
            _db.SaveChanges();

            return CreatedAtAction("AddQuestion", new { Qid = q.QuestionId }, question);
        }
       
    }
   

}
