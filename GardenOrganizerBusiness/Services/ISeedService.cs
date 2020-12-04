using Business.DatabaseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ISeedService : IService
    {
        Task<IList<DbSeed>> GetList();
    }
}
