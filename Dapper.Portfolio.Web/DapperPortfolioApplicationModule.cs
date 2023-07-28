using Autofac;
using Dapper.Portfolio.Application.Services;
using Dapper.Portfolio.Domain.Repository;
using Dapper.Portfolio.Infrastructure;

namespace Dapper.Portfolio.Web
{
    public class DapperPortfolioApplicationModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SkillRepository>().As<ISkillRepository>(); //TODO: it must not depend on infrastructure layer?
            builder.RegisterType<SkillAppService>().As<ISkillAppService>();
        }
    }
}
