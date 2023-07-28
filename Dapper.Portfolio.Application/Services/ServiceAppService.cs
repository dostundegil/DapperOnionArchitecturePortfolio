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
    public class ServiceAppService:IServiceAppService
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public ServiceAppService(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ServiceDto dto)
        {
            var command = $"INSERT INTO TblService (ServiceTitle, ServiceIcon, ServiceDescription) VALUES ('{dto.ServiceTitle}', '{dto.ServiceIcon}', '{dto.ServiceDescription}')";
            await _serviceRepository.InsertAsync(command);
        }

        public async Task DeleteAsync(int id)
        {
            var command = $"DELETE FROM TblService WHERE ServiceID = '{id}'";
            await _serviceRepository.DeleteAsync(command);
        }

        public async Task<ServiceDto> GetAsync(int id)
        {
            var command = $"SELECT * FROM TblService WHERE ServiceID = '{id}'";
            var service = await _serviceRepository.GetAsync(command);
            return _mapper.Map<Service, ServiceDto>(service);
        }

        public async Task<List<ServiceDto>> GetListAsync()
        {
            var command = "SELECT * FROM TblService";
            var services = await _serviceRepository.GetListAsync(command);

            return _mapper.Map<List<Service>, List<ServiceDto>>(services);
        }

        public async Task UpdateAsync(ServiceDto dto)
        {
            var command = $"UPDATE TblService SET ServiceTitle= '{dto.ServiceTitle}', ServiceIcon='{dto.ServiceIcon}', ServiceDescription='{dto.ServiceDescription}' WHERE ServiceID = '{dto.ServiceID}'";
            await _serviceRepository.UpdateAsync(command);
        }

    }
}
