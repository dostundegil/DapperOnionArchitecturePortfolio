using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Domain.Entities
{
    public class Info
    {
        public int InfoID { get; set; }
        public string InfoTitle { get; set; }
        public string InfoJob { get; set; }
        public string InfoDescription { get; set; }
        public string InfoTwitter { get; set; }
        public string InfoInstagram { get; set; }
        public string InfoGithub { get; set; }
        public string InfoLinkedIn { get; set; }
    }
}
