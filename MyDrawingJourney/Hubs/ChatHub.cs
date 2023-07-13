using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using MyDrawingJourney.Data.Models.Chat;

namespace MyDrawingJourney.Hubs
{
    public class ChatHub: Hub
    {
        private readonly string _botUser;
        public ChatHub()
        {
            _botUser = "MyChat Bot";
        }
        public async Task JoinRoom(UserConnection userConection)
        {
            //this add the specified conection(the room) to groups
            await Groups.AddToGroupAsync(Context.ConnectionId, userConection.Room);
            await Clients.All.SendAsync(userConection.Room, _botUser, $"{userConection.User} has joined {userConection.Room}");
        }


    }
}
