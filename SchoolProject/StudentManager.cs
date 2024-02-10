using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace SchoolProject
{
    class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void CreateStudent(string name, int age, int id, string subject)
        {
            Student student = new Student
            {
                name = name,
                age = age,
                id = id,
                subject = subject
            };

            students.Add(student);
            Console.WriteLine("Student oprettet med succes!");
        }

        public void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Navn: {student.name}, Alder: {student.age}, ID: {student.id}, Fag: {student.subject}");
            }
        }
    }
}
