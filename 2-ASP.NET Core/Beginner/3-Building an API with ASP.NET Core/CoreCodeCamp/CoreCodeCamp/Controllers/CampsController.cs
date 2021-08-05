using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Http;
using AutoMapper;
using CoreCodeCamp.ViewModels;
using Microsoft.AspNetCore.Routing;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {
        private readonly ICampRepository _repository;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkgenerator;

        public CampsController(ICampRepository repository, IMapper mapper, LinkGenerator linkgenerator)
        {
            _repository = repository;
            _mapper = mapper;
            _linkgenerator = linkgenerator;
        }
        [HttpGet]
        public async Task<ActionResult<CamViewModel[]>> GetCamps(bool includeTalks = false)
        {
            try
            {
                var result = await _repository.GetAllCampsAsync(includeTalks);

                CamViewModel[] models = _mapper.Map<CamViewModel[]>(result);
                return models;
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpGet("{moniker}")] // so route will be : api/CampsController/{monikerName}
        //[HttpGet("{moniker:int}")]//For int 
        public async Task<ActionResult<CamViewModel>> Get(string moniker)
        {
            try
            {
                var result = await _repository.GetCampAsync(moniker);

                if (result == null)
                    return NotFound();

                CamViewModel model = _mapper.Map<CamViewModel>(result);
                return model;
            }
            catch (Exception)
            {
                return BadRequest("DataBase Failure");
            }
        }
        [HttpGet("search")]
        public async Task<ActionResult<CamViewModel[]>> SearchByDate(DateTime theDate, bool includeTalks = false)
        {
            try
            {
                var result = await _repository.GetAllCampsByEventDate(theDate, includeTalks);

                if (!result.Any())
                    return NotFound();

                CamViewModel[] model = _mapper.Map<CamViewModel[]>(result);
                return model;
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpPost]
        public async Task<ActionResult<CamViewModel>> Post(CamViewModel model)
        {
            try
            {
                


                //Create a new Camp
                var camp = _mapper.Map<Camp>(model);
                _repository.AddCamp(camp);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/Camps/{camp.Moniker}", _mapper.Map<CamViewModel>(camp));
                }

            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
            return BadRequest();
        }
        [HttpPut("{monikor}")]
        public async Task<ActionResult<CamViewModel>> Put(string monikor, CamViewModel model)
        {
            try
            {
                var oldcamp = await _repository.GetCampAsync(monikor);
                if (oldcamp == null)
                {
                    return NotFound($"Couldn't Found cam with monikor {monikor}");
                }
                //_mapper.Map(model, oldcamp);
                var camp = _mapper.Map<Camp>(oldcamp);
                _repository.AddCamp(camp);
                _repository.DeleteCamp(oldcamp);
                if (await _repository.SaveChangesAsync())
                {
                    return _mapper.Map<CamViewModel>(oldcamp);
                }

                return BadRequest();
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpDelete("{monikor}")]
        public async Task<ActionResult> Delete(string monikor)
        {
            try
            {
                var oldCamp = await _repository.GetCampAsync(monikor);
                if(oldCamp == null)
                {
                    return NotFound($"Couldn't Found cam with monikor {monikor}");
                }
                _repository.DeleteCamp(oldCamp);

                if(await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
                return BadRequest();

            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }


    }
}
