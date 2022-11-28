using D0JAQL_HFT_2021222.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Logic
{
    public interface IBorrowingLogic
    {
        void Create(Borrowing borrowing);
        Borrowing Read(int id);
        IQueryable<Borrowing> ReadAll();
        void Update(Borrowing borrowing);
        void Delete(int id);
        //non-crud
        Book MostPopularBook();
        Student FirstBorrower();
        Student BiggestBorrower();
        IEnumerable<KeyValuePair<Book, int>> BorrowingPerBook();
        IEnumerable<Book> BooksBorrowedBy(string name);
    }
}
