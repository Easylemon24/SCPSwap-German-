using System;
using CommandSystem;
using PluginAPI.Core;
using SCPSwap_NWAPI.Models;

namespace SCPSwap_NWAPI.Commands
{
    public class Decline : ICommand
    {
        public string Command { get; set; } = "decline";
        
        public string[] Aliases { get; set; } = { "no", "d" };
        
        public string Description { get; set; } = "Lehnt die aktuelle Anfrage ab.";

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

            swap.Decline();
            response = "Tauschanfrage abgelehnt!";
            return true;
        }
    }
}