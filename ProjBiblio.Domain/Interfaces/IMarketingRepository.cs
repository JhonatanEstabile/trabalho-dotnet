using System.Collections.Generic;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Domain.Interfaces
{
    public interface IMarketingRepository  : IRepository<Marketing>
    {
        Marketing GetMarketingInclude(int marketingId);
    }
}