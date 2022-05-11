using Booking.Api.Areas.Base;
using Microsoft.AspNetCore.Mvc;

namespace Gamers8.Api.Features.SummitsFeature.SummitDay.Admin
{

    [ApiController]
    public class SummitDaysController : ApiBaseController<SummitDaysController>
    {
        [HttpPost]
        public Task<ActionResult<string>> Create(Create.Command command, CancellationToken ct)
       => Execute(command, ct);
    }
}
