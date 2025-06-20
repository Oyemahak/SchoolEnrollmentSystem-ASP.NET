namespace SchoolManagementSystem.Models.DTO
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public List<string>? EnrolledStudents { get; set; }
    }
}