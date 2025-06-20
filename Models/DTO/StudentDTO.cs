namespace SchoolManagementSystem.Models.DTO
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public List<string>? EnrolledCourses { get; set; }
    }
}
