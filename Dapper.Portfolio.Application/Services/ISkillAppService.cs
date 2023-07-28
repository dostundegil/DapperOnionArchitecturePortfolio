using Dapper.Portfolio.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Services
{
    public interface ISkillAppService
    {
        Task<List<SkillDto>> GetListAsync();

        Task<SkillDto> GetAsync(int id);

        Task CreateAsync(SkillDto dto);

        Task UpdateAsync(SkillDto dto);

        Task DeleteAsync(int id);
    }
}
