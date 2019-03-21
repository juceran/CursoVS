using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SalesWebMvc.Authorization
{
    public class UsuarioLogadoHandler : AuthorizationHandler<UsuarioLogado>
    {
        IHttpContextAccessor httpContext;

        public UsuarioLogadoHandler(IHttpContextAccessor HttpContextAccessor)
        {
            httpContext = HttpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UsuarioLogado requirement)
        {
            string id = httpContext.HttpContext.Session.GetString("IdUsuarioLogado");

            if (id != null && requirement.isLoged)
            {
                context.Succeed(requirement);
            }

            //TODO: Use the following if targeting a version of
            //.NET Framework older than 4.6:
            //      return Task.FromResult(0);
            return Task.CompletedTask;
        }
    }
}
