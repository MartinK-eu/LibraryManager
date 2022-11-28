using D0JAQL_HFT_2021222.Models;
using D0JAQL_HFT_2021222.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Logic
{
    public class StudentLogic : IStudentLogic
    {
        IStudentRepository repo;
        public StudentLogic(IStudentRepository studentRepository)
        {
            repo = studentRepository;
        }
        public void Create(Student student)
        {
            if (student.Name == null || student.Name == "")
            {
                throw new ArgumentException("The student has to have a name!");
            }
            else
            {
                repo.Create(student);
            }
        }
        
        public Student Read(int id)
        {
            return repo.Read(id);
        }

        public IQueryable<Student> ReadAll()
        {
            return repo.ReadAll();
        }

        public void Update(Student student)
        {
            repo.Update(student);
        }
        public void Delete(int id)
        {
            repo.Delete(id);
        }

    }
}
