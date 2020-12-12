using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjBiblio.Application.DTOs;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MarketingsController  : ControllerBase
    {
        private IMarketingService _marketingService;

        public MarketingsController(IMarketingService marketingService)
        {
            this._marketingService = marketingService;
        }

        [HttpGet]
        public MarketingListViewModel Get()
        {
            return _marketingService.Get();
        }

        [HttpGet("{id}", Name="GetMarketingDetails")]
        public ActionResult<MarketingViewModel> Get(int id) 
        { 
            var result = _marketingService.Get(id);

            if (result == null)
                return NotFound();

            return result;
        }

        [HttpPost]
        public ActionResult Post([FromBody] MarketingInputModel marketing)
        {
            // var result = _marketingService.Post(marketing);

            //cria marketing com relacionamento
            var result = _marketingService.CriarMarketing(marketing);

            return new CreatedAtRouteResult("GetMarketingDetails", 
                new { id = result.Id}, result);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MarketingInputModel marketing)
        {
            if (id != marketing.Id)
            {
                return BadRequest();
            }

            var result = _marketingService.Put(id, marketing);

            return new CreatedAtRouteResult("GetMarketingDetails", 
                new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public ActionResult<MarketingViewModel> Delete(int id)
        {
            var result = _marketingService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}