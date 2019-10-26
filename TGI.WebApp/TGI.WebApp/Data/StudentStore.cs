using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGI.WebApp.Models;

namespace TGI.WebApp.Data
{
    public class StudentStore
    {
        
        private List<Student> Students { get; set; } = new List<Student>();
        public StudentStore()
        {
            Students.Add(new Student
            {
                Id =  Guid.NewGuid(),
                Age = 17,
                Name= "juan",
                lastName = "Perez",
                Nit= "454353"
            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 21,
                Name = "jose",
                lastName = "paz",
                Nit = "4534323"
            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 47,
                Name = "julian",
                lastName = "Perez",
                Nit = "45435323"
            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 21,
                Name = "Andres",
                lastName = "Perez",
                Nit = "4543589893"
            });
        }

        internal void EditStudent(Student student)
        {
            var currentStudent = GetStudentById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.lastName = student.lastName;
            currentStudent.Nit = student.Nit;
            currentStudent.Age = student.Age;

        }

        internal Student GetStudentById(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            return student;
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents() {
            return this.Students;
        }
    }
}
