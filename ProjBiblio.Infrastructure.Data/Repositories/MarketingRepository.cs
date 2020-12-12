using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjBiblio.Domain.Entities;
using ProjBiblio.Domain.Interfaces;
using ProjBiblio.Infrastructure.Data.Context;

namespace ProjBiblio.Infrastructure.Data.Repositories
{
    public class MarketingRepository : Repository<Marketing>, IMarketingRepository
    {
        public MarketingRepository(BibliotecaDbContext context) : base(context)
        {
        }
    }
}