using MyDrawingJourney.Contracts;
using MyDrawingJourney.Data;

namespace MyDrawingJourney.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly ApplicationDbContext _data;

        public ApplicationUserService(ApplicationDbContext data)
        {
            _data = data;
        }
        public async Task<string> UserFullName(string userId)
        {
            var user = await _data.Users.FindAsync(userId);

            if(user== null || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
            {
                return null;
            }
            return user.FirstName + " " + user.LastName;
        }
    }
}
