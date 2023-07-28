using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Dtos
{
    public class SkillDto
    {
        public int SkillID { get; set; }
        [Required]
        [NotNull]
        public string SkillTitle { get; set; }
        [Required]
        [NotNull]
        public int SkillRate { get; set; }
    }
}
