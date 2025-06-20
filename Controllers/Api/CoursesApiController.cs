using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Models.DTO;

namespace SchoolManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CoursesApiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CoursesApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetAllCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        // GET: api/CoursesApi/1007
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null) return NotFound();
            return course;
        }

        // POST: api/CoursesApi
        [HttpPost]
        public async Task<ActionResult<Course>> CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCourse), new { id = course.CourseId }, course);
        }

        // PUT: api/CoursesApi/1007
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, Course course)
        {
            if (id != course.CourseId) return BadRequest();

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Courses.Any(e => e.CourseId == id)) return NotFound();
                throw;
            }

            return NoContent();
        }

        // DELETE: api/CoursesApi/1007
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null) return NotFound();

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DTO Endpoint: api/courses/1007/students
        [HttpGet("{id}/students")]
        public async Task<ActionResult<CourseDTO>> GetStudentsInCourse(int id)
        {
            var course = await _context.Courses
                .Include(c => c.Enrollments!)
                    .ThenInclude(e => e.Student)
                .FirstOrDefaultAsync(c => c.CourseId == id);

            if (course == null)
                return NotFound();

            var dto = new CourseDTO
            {
                CourseId = course.CourseId,
                Title = course.Title,
                EnrolledStudents = course.Enrollments?
                    .Select(e => e.Student?.Name)
                    .Where(name => name != null)
                    .Select(name => name!)
                    .ToList()
            };

            return Ok(dto);
        }
    }
}
