/*
Department has the following properties
1. departmentName,
2. departmentId
3. courses in that department eg engineering has mechanical, electrical, electronics etc(DepartmentCourses)
4. list of students in that department 
*/
using System.ComponentModel;

namespace ASPSTORE.OopsConcept
{
    public class Department(string DepartmentId, List<String> DepartmentCourses, List<Student> DepartmentStudents)
    {
        protected internal string DepartmentId { get; set; } = DepartmentId;
        protected internal List<string> DepartmentCourses { get; set; } = DepartmentCourses;
        protected internal List<Student> DepartmentStudents { get; set; } = DepartmentStudents;
        static Department(){
            Console.WriteLine("this is a static constructor");
        }
    }

}