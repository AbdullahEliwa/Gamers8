using AutoMapper;
using Gamers8.Api.Features.Base;
using Gamers8.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;
using summitDomain = Gamers8.Core.Entities.SummitAggregate;

namespace Gamers8.Api.Features.SummitsFeature.Summit.Admin
{

    public class SummitsController : AdminBaseController<SummitsController>
    {

        [HttpGet]
        public async Task<ActionResult<string>> Create()
            => await Task.FromResult(Ok("Admin SUmmits works!"));


    }
}
