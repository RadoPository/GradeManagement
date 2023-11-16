namespace GradeManagement.Models
{
    public class Course
    {

        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
