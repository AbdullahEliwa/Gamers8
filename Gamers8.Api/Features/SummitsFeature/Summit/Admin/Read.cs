using Microsoft.AspNetCore.Mvc;

namespace Gamers8.Api.Features.SummitsFeature.Summit.Admin
{
    [Route("AminSummitRead")]
    [Area("Summit")]
    [ApiController]
    public class Read : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return Ok("sas");
        }
    }
}
