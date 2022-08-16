using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerMyApp.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommintAsync();
        void Commit();
    }
}
