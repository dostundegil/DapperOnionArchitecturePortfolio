using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Domain.Entities
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string SkillTitle { get; set; }
        public int SkillRate { get; set; }
    }
}
