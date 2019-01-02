using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Sitecore.Support
{
  public class SupportChecklistFilterConfigurator: IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddTransient<Sitecore.XA.Feature.Search.Repositories.IChecklistFilterRepository, Sitecore.Support.XA.Feature.Search.Repositories.ChecklistFilterRepository>();
    }
  }
}