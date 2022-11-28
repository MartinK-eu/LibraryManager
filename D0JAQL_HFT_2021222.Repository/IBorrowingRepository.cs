using D0JAQL_HFT_2021222.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D0JAQL_HFT_2021222.Repository
{
    public interface IBorrowingRepository
    {
        void Create(Borrowing borrowing);
        Borrowing Read(int id);
        IQueryable<Borrowing> ReadAll();
        void Update(Borrowing borrowing);
        void Delete(int id);
    }
}
