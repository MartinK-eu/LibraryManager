using D0JAQL_HFT_2021222.Data;
using D0JAQL_HFT_2021222.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Repository
{
    public class StudentRepository : IStudentRepository
    {
        LibraryDbContext db;

        public StudentRepository(LibraryDbContext db)
        {
            this.db = db;
        }

        public void Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public Student Read(int id)
        {
            return db.Students.FirstOrDefault(x => x.StudentID == id);
        }

        public IQueryable<Student> ReadAll()
        {
            return db.Students;
        }

        public void Update(Student student)
        {
            var oldStudent = Read(student.StudentID);
            oldStudent.StudentClass = student.StudentClass;
            oldStudent.Name = student.Name;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            db.Remove(Read(id));
            db.SaveChanges();
        }

        
    }
}
