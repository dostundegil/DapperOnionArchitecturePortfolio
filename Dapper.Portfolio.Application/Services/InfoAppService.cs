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
    public class InfoAppService : IInfoAppService
    {
        private readonly IInfoRepository _infoRepository;
        private readonly IMapper _mapper;

        public InfoAppService(IInfoRepository infoRepository, IMapper mapper)
        {
            _infoRepository = infoRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(InfoDto dto)
        {
            var command = $"INSERT INTO TblInfo (InfoTitle,InfoJob,InfoDescription,InfoTwitter,InfoInstagram,InfoGithub,InfoLinkedIn) VALUES ('{dto.InfoTitle}','{dto.InfoJob}','{dto.InfoDescription}','{dto.InfoTwitter}','{dto.InfoInstagram}','{dto.InfoGithub}','{dto.InfoLinkedIn}')";
            await _infoRepository.InsertAsync(command);
        }

        public async Task DeleteAsync(int id)
        {
            var command = $"DELETE FROM TblInfo WHERE InfoID = '{id}'";
            await _infoRepository.DeleteAsync(command);
        }

        public async Task<InfoDto> GetAsync(int id)
        {
            var command = $"SELECT * FROM TblInfo WHERE InfoID = '{id}'";
            var info = await _infoRepository.GetAsync(command);
            return _mapper.Map<Info, InfoDto>(info);
        }

        public async Task<List<InfoDto>> GetListAsync()
        {
            var command = "SELECT * FROM TblInfo";
            var info = await _infoRepository.GetListAsync(command);

            return _mapper.Map<List<Info>, List<InfoDto>>(info);
        }

        public async Task UpdateAsync(InfoDto dto)
        {
            var command = $"UPDATE TblInfo SET InfoTitle= '{dto.InfoTitle}', InfoJob='{dto.InfoJob}', InfoDescription='{dto.InfoDescription}', InfoTwitter='{dto.InfoTwitter}', InfoInstagram='{dto.InfoInstagram}', InfoGithub='{dto.InfoGithub}', InfoLinkedIn='{dto.InfoLinkedIn}' WHERE InfoID = '{dto.InfoID}'";

            await _infoRepository.UpdateAsync(command);
        }
    }
}
