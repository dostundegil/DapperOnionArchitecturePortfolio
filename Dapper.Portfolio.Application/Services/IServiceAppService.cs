using Dapper.Portfolio.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Services
{
    public interface IServiceAppService
    {
        Task<List<ServiceDto>> GetListAsync();

        Task<ServiceDto> GetAsync(int id);

        Task CreateAsync(ServiceDto dto);

        Task UpdateAsync(ServiceDto dto);

        Task DeleteAsync(int id);
    }
}
