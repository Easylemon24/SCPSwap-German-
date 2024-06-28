using System;
using CommandSystem;
using PluginAPI.Core;
using SCPSwap_NWAPI.Models;

namespace SCPSwap_NWAPI.Commands
{
    public class Accept : ICommand
    {
        public string Command { get; set; } = "accept";
        
        public string[] Aliases { get; set; } = { "yes", "y" };
        
        public string Description { get; set; } = "Akzeptiert die aktuelle Tauschanfrage";

        bool ICommand.SanitizeResponse
        {
            get
            {
                return true;
            }
        }

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player playerSender = Player.Get(sender);
            if (playerSender == null)
            {
                response = "Dieser Befehl muss in der Spielkonsole ausgeführt werden.";
                return false;
            }

            Swap swap = Swap.FromReceiver(playerSender);
            if (swap == null)
            {
                response = "Du hast aktuell keine offenen Tauschanfragen.";
                return false;
            }

            swap.Run();
            response = "Tausch erfolgreich!";
            return true;
        }
    }
}