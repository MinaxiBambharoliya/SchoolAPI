using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    interface ICourse
    {
        IEnumerable<Course> AllCourse { get; }

        Course GetCourseById(int Id);
    }
}
