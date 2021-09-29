using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API_Arquive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("/v1/dados/{vContenth}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string RouterDadosPost(string vContenth)
        {
            try
            {
                System.IO.File.AppendAllText(@"C:\ABC.txt", vContenth);
                return "ARQUIVO SALVO!";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        [HttpGet("/v1/dados")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string RouterDadosGet()
        {
            try
            {
                var vConteht = System.IO.File.ReadAllText(@"C:\ABC.txt");
                return vConteht;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

    }
}
