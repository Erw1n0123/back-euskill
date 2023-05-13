using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Vezetéknév_Keresztnév_backend.Models;

namespace Vezetéknév_Keresztnév_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersenyzokController : ControllerBase
    {
        [HttpGet]
        public IActionResult getVersenyzoK()
        {
            using (var context = new euroskillsContext())
            {
                try
                {
                    return Ok(context.Versenyzos.ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
        [HttpGet("{id}")]
        public IActionResult getVersenyzo(int id)
        {
            using (var context = new euroskillsContext())
            {
                try
                {
                    return Ok(context.Versenyzos.Where(a => a.Id == id).ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPost("{uid}")]
        public IActionResult addVersenyzo(string uid,Versenyzo versenyzo)
        {
            if (uid == "FKB3F4FEA09CE43C")
            {
               using(var context = new euroskillsContext())
                {
                    try
                    {
                        context.Versenyzos.Add(versenyzo);
                        context.SaveChanges();
                        return Ok("Új versenyző hozzáadva");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }
            else
            {
                return BadRequest("rossz uid");
            }
        }
    }
}
