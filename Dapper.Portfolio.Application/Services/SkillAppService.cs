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
    public class SkillAppService : ISkillAppService
    {
        private readonly ISkillRepository _skillRepository;
        private readonly IMapper _mapper;

        public SkillAppService(ISkillRepository skillRepository, IMapper mapper)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(SkillDto skill)
        {
            var command = $"INSERT INTO TblSkill (SkillTitle,SkillRate) VALUES ('{skill.SkillTitle}','{skill.SkillRate}')";
            await _skillRepository.InsertAsync(command);
        }

        public async Task DeleteAsync(int id)
        {
            var command = $"DELETE FROM TblSkill WHERE SkillID = '{id}'";
            await _skillRepository.DeleteAsync(command);
        }

        public async Task<SkillDto> GetAsync(int id)
        {
            var command = $"SELECT * FROM TblSkill WHERE SkillID = '{id}'";
            var skill = await _skillRepository.GetAsync(command);
            return _mapper.Map<Skill, SkillDto>(skill);
        }

        public async Task<List<SkillDto>> GetListAsync()
        {
            var command = "SELECT * FROM TblSkill";
            var skills = await _skillRepository.GetListAsync(command);

            return _mapper.Map<List<Skill>, List<SkillDto>>(skills);
        }

        public async Task UpdateAsync(SkillDto skill)
        {
            var command = $"UPDATE TblSkill SET SkillTitle= '{skill.SkillTitle}', SkillRate='{skill.SkillRate}' WHERE SkillID = '{skill.SkillID}'";
            await _skillRepository.UpdateAsync(command);
        }
    }
}
