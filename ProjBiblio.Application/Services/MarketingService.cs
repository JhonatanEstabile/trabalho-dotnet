using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;
using ProjBiblio.Domain.Entities;
using ProjBiblio.Domain.Interfaces;

namespace ProjBiblio.Application.Services
{
    public class MarketingService : IMarketingService
    {
        public IUnitOfWork _uow;
        public IMapper _mapper;

        public MarketingService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public MarketingListViewModel Get()
        {
            var marketings = this._uow.MarketingRepository.Get();

            return new MarketingListViewModel()
            {
                Marketings =  _mapper.Map<IEnumerable<MarketingViewModel>>(marketings)
            };
        }

        public MarketingViewModel Get(int id)
        {
            var marketing = this._uow.MarketingRepository.GetById(a => a.MarketingID == id);

            return _mapper.Map<MarketingViewModel>(marketing);
        }

        public MarketingViewModel Post(MarketingInputModel marketingInputModel)
        {
            var marketing = _mapper.Map<Marketing>(marketingInputModel);

            _uow.MarketingRepository.Add(marketing);
            _uow.Commit();

            return _mapper.Map<MarketingViewModel>(marketing);
        }

        public MarketingViewModel Put(int id, MarketingInputModel marketingInputModel)
        {
            var marketing = _mapper.Map<Marketing>(marketingInputModel);

            _uow.MarketingRepository.Update(marketing);
            _uow.Commit();

            return _mapper.Map<MarketingViewModel>(marketing);
        }

        public MarketingViewModel Delete(int id)
        {
            var marketing = this._uow.MarketingRepository.GetById(a => a.MarketingID == id);

            if (marketing == null)
            {
                return null;
            }

            _uow.MarketingRepository.Delete(marketing);
            _uow.Commit();

            return _mapper.Map<MarketingViewModel>(marketing);
        }

        public MarketingViewModel CriarMarketing(MarketingInputModel marketingInputModel)
        {
            var livro = this._uow.LivroRepository.GetById(a => a.LivroID == marketingInputModel.LivroID);

            var marketing = new Marketing()
            {
                DataInicio = marketingInputModel.DataInicio,
                DataFim = marketingInputModel.DataFim,
                Descricao = marketingInputModel.Descricao,
                PercentualDesconto = marketingInputModel.PercentualDesconto,
            };

            marketing.LivMarketing.Add(new LivroMarketing() { LivroID = livro.LivroID });

            this._uow.MarketingRepository.Add(marketing);
            this._uow.Commit();

            return _mapper.Map<MarketingViewModel>(marketing);
        }
    }
}