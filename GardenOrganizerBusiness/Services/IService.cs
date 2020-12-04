using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IService
    {
        Task Get();

        Task Post();

        Task Put();

        Task Delete();
    }
}
