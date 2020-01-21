using System;
using EXILED;

namespace WelcomeBroadcast
{
	public class Plugin : EXILED.Plugin
	{
		//Instance variable for eventhandlers
		public EventHandlers EventHandlers;
		
		public override void OnEnable()
		{
			try
			{
                Plugin.Info("WelcomeBroadcast plugin loading...");
				EventHandlers = new EventHandlers(this);

				Events.PlayerJoinEvent += EventHandlers.OnPlayerJoin;
                Plugin.Info("WelcomeBroadcast plugin loaded!");
			}
			catch (Exception e)
			{
				Error($"WelcomeBroadcast plugin error: {e}");
			}
		}

		public override void OnDisable()
		{
            Events.PlayerJoinEvent -= EventHandlers.OnPlayerJoin;
            EventHandlers = null;
		}

		public override void OnReload()
		{
			
		}

		public override string getName { get; } = "WelcomeBroadcast";
	}
}