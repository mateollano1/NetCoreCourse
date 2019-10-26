using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGI.WebApp.Models;

namespace TGI.WebApp.Data
{
    public class StudentStore
    {
        public TGLContext Context { get; set; }
        //private List<Student> Students { get; set; } = new List<Student>();
        public StudentStore(TGLContext context)
        {
            Context = context;
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudentById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.lastName = student.lastName;
            currentStudent.Nit = student.Nit;
            currentStudent.Age = student.Age;
            Context.Student.Update(currentStudent);
            Context.SaveChanges();

        }

        internal Student GetStudentById(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            return student;
        }

        internal void AddStudent(Student student)
        {
            Context.Student.Add(student);
            Context.SaveChanges();
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            Context.Student.Remove(student);
            Context.SaveChanges();
        }

        public List<Student> GetStudents() {
            return Context.Student.ToList();
        }
    }
}
