using EFMVC05.Models;
using System;

namespace EFMVC05.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        EFMVCContext Get();
    }
}
