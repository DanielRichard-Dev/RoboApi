using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoboModels.RoboEnum;
using RoboModels.RoboModels;
using RoboServices.RoboInterfaces;
using RoboServices.RoboServices;

namespace RoboApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        private IRoboService _roboService { get; set; }

        public RoboController()
        {
            _roboService = new RoboService();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<RoboApiModel> IniciarRobo()
        {
            try
            {
                var robo = _roboService.CarregarRobo();

                return Ok(robo);
            }
            catch (Exception)
            {
                return BadRequest("Ërro ao iniciar robô");
            }
        }

        [HttpPut("movimentarbraco")]
        public ActionResult<RoboApiModel> MovimentarBracoRobo([FromBody]RoboApiModel roboRequest)
        {
            try
            {
                var robo = _roboService.MovimentarBracoRobo(roboRequest);

                return Ok(roboRequest);
            }
            catch (Exception)
            {
                return BadRequest("Ërro ao iniciar robô");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
