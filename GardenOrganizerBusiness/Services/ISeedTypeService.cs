using Business.DatabaseModels;
using Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ISeedTypeService
    {
        Task<IList<SeedType>> GetList();

        Task<SeedType> Get(int id);

        Task<int> Post(SeedType seedType);

        Task<int> Put(SeedType seedType);

        Task<int> Delete(SeedType seedType);
    }
}
