using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.Application.Interfaces
{
    public interface IMarketingService
    {
        MarketingListViewModel Get();

        MarketingViewModel Get(int id);

        MarketingViewModel Post(MarketingInputModel marketingInputModel);

        MarketingViewModel Put(int id, MarketingInputModel marketingInputModel);

        MarketingViewModel Delete(int id);

        MarketingViewModel CriarMarketing(MarketingInputModel marketingInputModel);
    }
}