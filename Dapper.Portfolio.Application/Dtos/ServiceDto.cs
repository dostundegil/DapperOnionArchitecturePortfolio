using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Dtos
{
    public class ServiceDto
    {
        public int ServiceID { get; set; }

        [Required]
        [NotNull]
        public string ServiceTitle { get; set; }

        [Required]
        [NotNull]
        public string ServiceIcon { get; set; }

        [Required]
        [NotNull]
        public string ServiceDescription { get; set; }
    }
}
