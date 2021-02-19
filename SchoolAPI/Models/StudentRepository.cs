using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    public class StudentRepository : IStudent
    {
        

        public StudentRepository()
        {
            
        }
        public IEnumerable<Student> AllStudent => throw new NotImplementedException();

        public Student GetStudentById(int Id)
        {
            

        }
    }
}
