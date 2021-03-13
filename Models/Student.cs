using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-03-presac-dykstra1] - this class holds all the info that a student needs to enroll such as their student ID, full name,
        //tinfo200:[2021-03-03-presac-dykstra1] - enrollment date, and holds multiple enrollments

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
