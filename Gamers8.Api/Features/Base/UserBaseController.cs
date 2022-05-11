using Microsoft.AspNetCore.Mvc;

namespace Gamers8.Api.Features.Base
{
    [Area("User")]
    [Route("api/v1/[area]/[controller]")]
    public class UserBaseController<C> : ApiBaseController<C>
    {
    }
}
