using Business.DatabaseModels;
using Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ISeedService
    {
        Task<IList<Seed>> GetList();

        Task<IList<Seed>> GetList(string type);

        Task<Seed> Get(int id);

        Task<int> Post(Seed seedType);

        Task<int> Put(Seed seedType);

        Task<int> Delete(Seed seedType);
    }
}
