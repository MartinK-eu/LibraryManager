using D0JAQL_HFT_2021222.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Repository
{
    public interface IBookRepository
    {
        void Create(Book book);
        Book Read(int id);
        IQueryable<Book> ReadAll();
        void Update(Book book);
        void Delete(int id);
    }
}
