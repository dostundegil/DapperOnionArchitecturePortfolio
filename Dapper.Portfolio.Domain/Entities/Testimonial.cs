using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialContent { get; set; }
    }
}
