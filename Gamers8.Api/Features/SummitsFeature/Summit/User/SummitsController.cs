using Gamers8.Api.Features.Base;
using Microsoft.AspNetCore.Mvc;

namespace Gamers8.Api.Features.SummitsFeature.Summit.User
{
    public class SummitsController : UserBaseController<SummitsController>
    {
        [HttpGet]
        public async Task<ActionResult<string>> Create()
       => await Task.FromResult(Ok("User SUmmits works!"));
    }
}
