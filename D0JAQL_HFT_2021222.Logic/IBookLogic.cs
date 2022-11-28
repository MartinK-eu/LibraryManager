using D0JAQL_HFT_2021222.Models;
using D0JAQL_HFT_2021222.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Logic
{
    public interface IBookLogic
    {
        void Create(Book book);
        Book Read(int id);
        IQueryable<Book> ReadAll();
        void Update(Book book);
        void Delete(int id);

        //non-crud
    }
}
