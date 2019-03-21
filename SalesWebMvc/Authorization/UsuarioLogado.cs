using Microsoft.AspNetCore.Authorization;

namespace SalesWebMvc.Authorization
{
    public class UsuarioLogado : IAuthorizationRequirement
    {
        public bool isLoged { get; private set; }

        public UsuarioLogado (bool logado)
        {
            isLoged = logado;
        }
    }
}
