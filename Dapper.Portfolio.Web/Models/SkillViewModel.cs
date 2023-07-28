using Dapper.Portfolio.Application.Dtos;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Dapper.Portfolio.Web.Models
{
    public class SkillViewModel
    {
        public List<SkillDto> Skills { get; set; }
    }
}
