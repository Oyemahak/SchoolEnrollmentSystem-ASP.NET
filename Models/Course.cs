namespace SchoolManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string? Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
