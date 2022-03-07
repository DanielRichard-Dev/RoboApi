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
                return BadRequest("Erro ao iniciar robô");
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
                return BadRequest("Erro ao movimentar robô");
            }
        }

        [HttpPut("movimentarcabeca")]
        public ActionResult<RoboApiModel> MovimentarCabecaRobo([FromBody]RoboApiModel roboRequest)
        {
            try
            {
                var robo = _roboService.MovimentarCabecaRobo(roboRequest);

                return Ok(roboRequest);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao movimentar robô");
            }
        }
    }
}
