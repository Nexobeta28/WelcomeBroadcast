using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeBroadcast
{
    public class Config
    {
        //Enable or disable the plugin. true = enabled, false = disabled.
        public static bool plugin_enabled = true;

        //Duration of the message (in seconds).
        public static uint time = 5;

        //Broadcast message.
        public static string message = "Welcome to my server!";
    }
}
