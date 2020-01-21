using System.Collections.Generic;
using EXILED;
using Grenades;
using MEC;

namespace WelcomeBroadcast
{
	public class EventHandlers
	{

        public Plugin plugin;
		public EventHandlers(Plugin plugin) => this.plugin = plugin;

		public void OnPlayerJoin(PlayerJoinEvent ev)
		{
            if(Config.plugin_enabled == true)
            {
                ev.Player.Broadcast(Config.time, Config.message);
            }
		}
	}
}