using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IService
{
    public interface ITransportService
    {
        List<Transport> GetTransports();
        Transport FindTransportById(string id);
        void AddTransport(Transport a);
        void UpdateTransport(Transport a);
        void DeleteTransport(Transport a);
    }
}
