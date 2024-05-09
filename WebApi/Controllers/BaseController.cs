using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class BaseController:ControllerBase
    {
        //Eğer daha önce Mediator injection yapılmışsa onu döndür yoksa null ise .RequestServices.GetService<IMediator>(); YAP
        private IMediator? _mediator;
        protected IMediator? Mediator => _mediator??=HttpContext.RequestServices.GetService<IMediator>();
    }
}
