namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    //tinfo200:[2021-03-03-presac-dykstra1] - this class holds all the info that a student needs to enroll such as their student ID, course ID,
    //tinfo200:[2021-03-03-presac-dykstra1] - enrollment ID, student identification, and grade
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Student Student { get; set; }
    }
}