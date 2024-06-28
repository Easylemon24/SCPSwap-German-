using System;
using CommandSystem;
using PluginAPI.Core;
using SCPSwap_NWAPI.Models;

namespace SCPSwap_NWAPI.Commands
{
    public class Cancel : ICommand
    {
        public string Command { get; set; } = "cancel";
        
        public string[] Aliases { get; set; } = { "c" };
        
        public string Description { get; set; } = "Bricht die aktuell gesendete Anfrage ab.";

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

            Swap swap = Swap.FromSender(playerSender);
            if (swap == null)
            {
                response = "Du hast aktuell keine offenen Tauschanfragen";
                return false;
            }

            swap.Cancel();
            response = "Tauschanfrage wurde abgebrochen";
            return true;
        }
    }
}