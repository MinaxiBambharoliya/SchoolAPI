using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    interface IStudent
    {
        IEnumerable<Student> AllStudent { get; }

        Student GetStudentById(int Id);

    }
}
