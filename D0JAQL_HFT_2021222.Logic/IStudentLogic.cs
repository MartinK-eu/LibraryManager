using D0JAQL_HFT_2021222.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Logic
{
    public interface IStudentLogic
    {
        void Create(Student student);
        Student Read(int id);
        IQueryable<Student> ReadAll();
        void Update(Student student);
        void Delete(int id);
    }
}
