using System.Security.Claims;

namespace MyDrawingJourney.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public const string AdminRoleName = "Administrator";
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }
    }
}
