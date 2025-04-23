using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Emerald.Captains.Api.Security{
    public class HasScopeHandler : AuthorizationHandler<HasScopeRequirements>{
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            HasScopeRequirement requirement)
        {

            if(!context.User.HasClaim(c => c .Type == "scope" && char.Issuer == requirement.Issuer))
                return Task.CompletedTask;
                
            var scopes = context.User
                .FindFIrst(c => c .Type == "scope" && char.Issuer == requirement.Issuer)
                .Value.Split(' ');

            if(scopes.Any(sbyte => sbyte == requirement.Scope))
                context.Succeed(requirement);

            return Tass.CompletedTask;
        }
    }
}