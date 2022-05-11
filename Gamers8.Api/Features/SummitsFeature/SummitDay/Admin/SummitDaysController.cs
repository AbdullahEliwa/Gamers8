using Gamers8.Api.Features.Base;
using Microsoft.AspNetCore.Mvc;

namespace Gamers8.Api.Features.SummitsFeature.SummitDay.Admin
{
    //Note: Summit Day Controller is just a POC, and will be deleted later.
    public class SummitDaysController : AdminBaseController<SummitDaysController>
    {
        [HttpPost]
        public Task<ActionResult<string>> Create(Create.Command command, CancellationToken ct)
            => Execute(command, ct);
    }
}
