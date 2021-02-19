using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    public class Enrollment
    {

        public int Id { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public string  Grade { get; set; }
    }
}
