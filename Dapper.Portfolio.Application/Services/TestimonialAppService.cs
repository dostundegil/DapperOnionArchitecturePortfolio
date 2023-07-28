using AutoMapper;
using Dapper.Portfolio.Application.Dtos;
using Dapper.Portfolio.Domain.Entities;
using Dapper.Portfolio.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Services
{
    public class TestimonialAppService: ITestimonialAppService
    {
        private readonly ITestimonailRepository _testimonailRepository;
        private readonly IMapper _mapper;

        public TestimonialAppService(ITestimonailRepository testimonailRepository, IMapper mapper)
        {
            _testimonailRepository = testimonailRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(TestimonialDto dto)
        {
            var command = $"INSERT INTO TblTestimonial (TestimonialTitle, TestimonialName, TestimonialContent) VALUES ('{dto.TestimonialTitle}', '{dto.TestimonialName}', '{dto.TestimonialContent}')";

            await _testimonailRepository.InsertAsync(command);
        }

        public async Task DeleteAsync(int id)
        {
            var command = $"DELETE FROM TblTestimonial WHERE TestimonialID = '{id}'";
            await _testimonailRepository.DeleteAsync(command);
        }

        public async Task<TestimonialDto> GetAsync(int id)
        {
            var command = $"SELECT * FROM TblTestimonial WHERE TestimonialID = '{id}'";
            var service = await _testimonailRepository.GetAsync(command);
            return _mapper.Map<Testimonial, TestimonialDto>(service);
        }

        public async Task<List<TestimonialDto>> GetListAsync()
        {
            var command = "SELECT * FROM TblTestimonial";
            var services = await _testimonailRepository.GetListAsync(command);

            return _mapper.Map<List<Testimonial>, List<TestimonialDto>>(services);
        }

        public async Task UpdateAsync(TestimonialDto dto)
        {
            var command = $"UPDATE TblTestimonial SET TestimonialTitle= '{dto.TestimonialTitle}', TestimonialName='{dto.TestimonialName}', TestimonialContent='{dto.TestimonialContent}' WHERE TestimonialID = '{dto.TestimonialID}'";
            await _testimonailRepository.UpdateAsync(command);
        }
    }
}
