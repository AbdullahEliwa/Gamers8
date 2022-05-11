using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Api.Areas.Base;
[Route("api/v1/[controller]")]
[ApiController]
public class ApiBaseController<C> : ControllerBase
{
    private ISender _mediator;
    private ILogger<C> _logger;

    private ILogger<C> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<C>>();

    private ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();

    protected async Task<ActionResult<T>> Execute<T>(IRequest<T> request, CancellationToken token = default) where T : class
    {
        Logger.LogInformation("----- Sending Query: {@Command}", request);

        return request is { }
            ? Ok(await Mediator.Send(request, token))
            : StatusCode(StatusCodes.Status405MethodNotAllowed);
    }
    protected async Task<ActionResult> Execute(IRequest request, CancellationToken token = default)
    {
        Logger.LogInformation("----- Sending Query: {@Command}", request);

        return request is { }
            ? Ok(await Mediator.Send(request, token))
            : StatusCode(StatusCodes.Status405MethodNotAllowed);
    }

}