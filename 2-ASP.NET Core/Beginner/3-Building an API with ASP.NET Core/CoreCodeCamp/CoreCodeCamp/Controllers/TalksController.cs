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
    [Route("api/camps/{moniker}/talks")]
    [ApiController]
    public class TalksController : Controller
    {
        private readonly ICampRepository _repository;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkgenerator;

        public TalksController(ICampRepository repository, IMapper mapper, LinkGenerator linkgenerator)
        {
            _repository = repository;
            _mapper = mapper;
            _linkgenerator = linkgenerator;
        }
        [HttpGet]
        public async Task<ActionResult<TalkViewModel[]>>Get(string moniker)
        {
            try
            {
                var talks =await  _repository.GetTalksByMonikerAsync(moniker);
                return _mapper.Map<TalkViewModel[]>(talks);
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<TalkViewModel>> Get(string moniker,int id)
        {
            try
            {
                var talks = await _repository.GetTalkByMonikerAsync(moniker,id);
                if (talks == null)
                    NotFound("Talk Not Found !");
                return _mapper.Map<TalkViewModel>(talks);
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpPost]
        public async Task<ActionResult<TalkViewModel>> post(string moniker, TalkViewModel model)
        {
            try
            {
                var camp =await _repository.GetCampAsync(moniker);
                if (camp == null)
                    return BadRequest("Camp does not exist");


                var talk = _mapper.Map<Talk>(model);
                talk.Camp = camp;

                if(model.Speaker==null)
                    return BadRequest("Speaker id is Required");

                var speaker = await _repository.GetSpeakerAsync(model.Speaker.SpeakerId);

                if(speaker==null)
                    return BadRequest("Speaker not Found");

                talk.Speaker = speaker;

                _repository.AddTalk(talk);

                if (await _repository.SaveChangesAsync())
                {
                    var url = _linkgenerator.GetPathByAction(HttpContext, "Get", values: new { moniker, id = talk.TalkId });
                    return Created(url,_mapper.Map<TalkViewModel>(model));

                }
                else
                {
                    return BadRequest("Failed to save new talk");
                }
                         
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<TalkViewModel>> Put(string monikor,int id, TalkViewModel model)
        {
            try
            {
                var talk = await _repository.GetTalkByMonikerAsync(monikor,id,true);
                if (talk == null)
                {
                    return NotFound($"Couldn't Found the talk");
                }

                _mapper.Map(model, talk);
                if(model.Speaker!=null)
                {
                    var speaker = await _repository.GetSpeakerAsync(model.Speaker.SpeakerId);
                    if(speaker!=null)
                    {
                        talk.Speaker = speaker;
                    }

                }

                
                if (await _repository.SaveChangesAsync())
                {
                    return _mapper.Map<TalkViewModel>(talk);
                }
                else
                {
                    return BadRequest("Falid to update the database");
                }

                
            }
            catch (Exception)
            {

                return BadRequest("DataBase Failure");
            }
        }
        [HttpDelete("{int:id}")]
        public async Task<ActionResult> Delete(string monikor,int id)
        {
            try
            {
                var talk = await _repository.GetTalkByMonikerAsync(monikor,id);
                if (talk == null)
                {
                    return NotFound($"Couldn't Found the talk");
                }
                _repository.DeleteTalk(talk);

                if (await _repository.SaveChangesAsync())
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
