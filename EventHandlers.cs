using System.Collections.Generic;
using EXILED;
using Grenades;
using MEC;

namespace WelcomeBroadcast
{
	public class EventHandlers
	{
        //BROADCAST VARS
        uint time = 5;
        string message = "Welcome to my server!";

        public Plugin plugin;
		public EventHandlers(Plugin plugin) => this.plugin = plugin;

		public void OnPlayerJoin(PlayerJoinEvent ev)
		{
			ev.Player.Broadcast(time, message);
		}
	}
}