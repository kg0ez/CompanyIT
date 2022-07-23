using System.ComponentModel.DataAnnotations;

namespace Company.Models.DatabaseModels
{
	public class StudentPerformance
	{
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public int Mark { get; set; }
        public int CourseDuration { get; set; }
    }
}

