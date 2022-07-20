using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Services.BaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
        Task SaveChangesAsync();
        ApplicationDbContext GetContext();
    }
}
