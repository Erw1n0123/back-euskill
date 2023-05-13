using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Vezetéknév_Keresztnév_backend.Models;

namespace Vezetéknév_Keresztnév_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrszagokController : ControllerBase
    {
        [HttpGet]
        public IActionResult osszesOrszagSzama()
        {
            using(var context = new euroskillsContext())
            {
                try
                {
                    return Ok("országok száma: " + context.Orszags.Count());
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
