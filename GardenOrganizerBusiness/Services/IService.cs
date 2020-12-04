using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IService
    {
        Task<T> Get<T>() where T : class, new();

        Task Post<T>(T Model) where T : class, new();

        Task Put<T>(T Model) where T : class, new();

        Task Delete<T>(T Model) where T : class, new();
    }
}
