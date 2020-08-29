using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UOW
{
    public class UnitOfWork: IUnitOfWork
    {
        public MyCompanyContext Context { get; }

        public UnitOfWork(MyCompanyContext context)
        {
            Context = context;
        }
        //private readonly MyCompanyContext _context;
        //public UnitOfWork(MyCompanyContext context) {
        //    _context = context;
        //}
        //public MyCompanyContext Context { get; }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
