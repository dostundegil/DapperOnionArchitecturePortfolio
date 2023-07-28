using Dapper.Portfolio.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Services
{
    public interface IInfoAppService
    {
        Task<List<InfoDto>> GetListAsync();

        Task<InfoDto> GetAsync(int id);

        Task CreateAsync(InfoDto dto);

        Task UpdateAsync(InfoDto dto);

        Task DeleteAsync(int id);
    }
}
