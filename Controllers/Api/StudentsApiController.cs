using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Models.DTO;

namespace SchoolManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsApiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: api/StudentsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();
            return student;
        }

        // POST: api/StudentsApi
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStudent), new { id = student.StudentId }, student);
        }

        // PUT: api/StudentsApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if (id != student.StudentId) return BadRequest();
            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Students.Any(e => e.StudentId == id)) return NotFound();
                throw;
            }

            return NoContent();
        }

        // DELETE: api/StudentsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DTO Endpoint: api/students/5/courses
        [HttpGet("{id}/courses")]
        public async Task<ActionResult<StudentDTO>> GetCoursesForStudent(int id)
        {
            var student = await _context.Students
                .Include(s => s.Enrollments!)
                    .ThenInclude(e => e.Course)
                .FirstOrDefaultAsync(s => s.StudentId == id);

            if (student == null)
                return NotFound();

            var dto = new StudentDTO
            {
                StudentId = student.StudentId,
                Name = student.Name,
                EnrolledCourses = student.Enrollments?
                    .Select(e => e.Course?.Title)
                    .Where(title => title != null)
                    .Select(title => title!)
                    .ToList()
            };

            return Ok(dto);
        }
    }
}
