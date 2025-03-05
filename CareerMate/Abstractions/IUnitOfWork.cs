using System;
using System.Threading;
using System.Threading.Tasks;

namespace Template.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
