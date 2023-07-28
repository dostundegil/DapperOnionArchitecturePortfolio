using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Dtos
{
    public class TestimonialDto
    {
        public int TestimonialID { get; set; }

        [Required]
        [NotNull]
        public string TestimonialTitle { get; set; }


        [Required]
        [NotNull]
        public string TestimonialName { get; set; }


        [Required]
        [NotNull]
        public string TestimonialContent { get; set; }
    }
}
