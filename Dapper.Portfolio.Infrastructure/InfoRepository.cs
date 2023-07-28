using Dapper.Portfolio.Domain.Entities;
using Dapper.Portfolio.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Infrastructure
{
    public class InfoRepository : GenericRepository<Info>, IInfoRepository
    {
    }
}
