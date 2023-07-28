using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Dtos
{
    public class InfoDto
    {
        public int InfoID { get; set; }

        [Required]
        [NotNull]
        public string InfoTitle { get; set; }

        [Required]
        [NotNull]
        public string InfoJob { get; set; }

        [Required]
        [NotNull]
        public string InfoDescription { get; set; }

        [Required]
        [NotNull]
        public string InfoTwitter { get; set; }

        [Required]
        [NotNull]
        public string InfoInstagram { get; set; }

        [Required]
        [NotNull]
        public string InfoGithub { get; set; }

        [Required]
        [NotNull]
        public string InfoLinkedIn { get; set; }
    }
}
