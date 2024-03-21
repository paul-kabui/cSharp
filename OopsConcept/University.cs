using ASPSTORE.OopsConcept;
namespace OopsConcept
{
    public class University
    {
        // static University()
        // {
        //     string University = "Mount Kenya Unimersity";
        // }
        //convert the fuction to main to run the program
        public static void MainFunc(string[] args){
                //enginnering Students
            List<String> engineeringCourses = ["Mechanical", "Electrical", "Electronic", "BioMed"];
            Student student1 = new("paul", "001", "Electronic");
            Student student2 = new("John", "002", "Mechanical");
            Student student3 = new("Jane", "003", "BioMend");
            List<Student> engineeringStudents = [student1,student2, student3];
            //Information tech student
            List<String> ProgrammingCourses = ["cSharp", "Java", "Python", "Typescript"];
            Student student4 = new("Kabui", "001", "cSharp");
            Student student5 = new("Smith", "002", "Java");
            Student student6 = new("Rose", "003", "Python");
            Student student7 = new("Mary", "004", "Typescript");
            List<Student> ProgrammingStudents = [student4,student5, student6,student7];

            
            
            Department EngineeringDepartment = new("ENG003",engineeringCourses, engineeringStudents );
            Department ProgrammingDepartment = new("PRG003",ProgrammingCourses, ProgrammingStudents);

            Dictionary<string, Department> University = new()
            {
                {"engineering",EngineeringDepartment},
                {"programming", ProgrammingDepartment}

            };
            Console.WriteLine(University["engineering"].DepartmentStudents[0].Name);
            }
        }
    }