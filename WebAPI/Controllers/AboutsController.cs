using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet("GetAllAbout")]
        public IActionResult GetAll()
        {

            var result = _aboutService.TGetList();
            
                return Ok(result);
        }
        [HttpGet("GetByIdAbout")]
        public IActionResult GetById(int id)
        {
            var result = _aboutService.TGetById(id);
                return Ok(result);
        }

        [HttpPut("UpdateAbout")]
        public IActionResult Update(About about)
        {
            using var c = new Context();
            var value = c.Find<About>(about.AboutID);
            if(value== null)
            {
                return NotFound();
            }
            else
            {
                value.Title=about.Title;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }

    }
}
