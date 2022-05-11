using Microsoft.AspNetCore.Mvc;

namespace Gamers8.Api.Features.Base
{
    [Area("Admin")]
    [Route("api/v1/[area]/[controller]")]
    public class AdminBaseController<C> : ApiBaseController<C>
    {
    }
}
