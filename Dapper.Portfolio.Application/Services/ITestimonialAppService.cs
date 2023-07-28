using Dapper.Portfolio.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Services
{
    public interface ITestimonialAppService
    {
        Task<List<TestimonialDto>> GetListAsync();

        Task<TestimonialDto> GetAsync(int id);

        Task CreateAsync(TestimonialDto dto);

        Task UpdateAsync(TestimonialDto dto);

        Task DeleteAsync(int id);
    }
}
