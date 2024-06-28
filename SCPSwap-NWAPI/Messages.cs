using System.Collections.Generic;
using System.ComponentModel;
using PlayerRoles;
using SCPSwap_NWAPI.Models;

// ReSharper disable once StringLiteralTypo
namespace SCPSwap_NWAPI
{
    public class Messages
    {
        [Description("A collection of custom names with their correlating RoleType.")]
        public Dictionary<string, RoleTypeId> TranslatableSwaps { get; set; } = new()
        {
            { "173", RoleTypeId.Scp173 },
            { "peanut", RoleTypeId.Scp173 },
            { "939", RoleTypeId.Scp939 },
            { "doggo", RoleTypeId.Scp939 },
            { "dog", RoleTypeId.Scp939 },
            { "079", RoleTypeId.Scp079 },
            { "79", RoleTypeId.Scp079 },
            { "pc", RoleTypeId.Scp079 },
            { "computer", RoleTypeId.Scp079 },
            { "106", RoleTypeId.Scp106 },
            { "larry", RoleTypeId.Scp106 },
            { "096", RoleTypeId.Scp096 },
            { "96", RoleTypeId.Scp096 },
            { "shyguy", RoleTypeId.Scp096 },
            { "049", RoleTypeId.Scp049 },
            { "49", RoleTypeId.Scp049 },
            { "doctor", RoleTypeId.Scp049 },
            { "doc", RoleTypeId.Scp049 },
            { "0492", RoleTypeId.Scp0492 },
            { "492", RoleTypeId.Scp0492 },
            { "zombie", RoleTypeId.Scp0492 },
            { "3114", RoleTypeId.Scp3114 },
            { "skeleton", RoleTypeId.Scp3114 },
            { "skinwalker", RoleTypeId.Scp3114}
        };

        [Description("Die Nachricht welche an alle SCP's am Anfang einer neuen Runde gesendet wird.")]
        public GameBroadcastMessage StartMessage { get; set; } = new("<color=yellow><b>Did you know you can swap classes with other SCP's?</b></color> Simply type <color=orange>.scpswap (role number)</color> in your in-game console (not RA) to swap!", 15);
        [Description("Die Ankündigung welche The broadcast to display to the receiver of a swap request.")]
        public GameBroadcastMessage RequestBroadcast { get; set; } = new("<i>You have an SCP Swap request!\nCheck your console by pressing [`] or [~]</i>", 5);
        [Description("The console message to send to the receiver of a swap request.")]
        public ConsoleMessage RequestConsoleMessage { get; set; } = new("You have received a swap request from $SenderName who is $RoleName. Would you like to swap with them? Type \".scpswap accept\" to accept or \".scpswap decline\" to decline.", "yellow");
        [Description("Die Nachricht welche an BEIDE Spieler nach einem Erfolgreichen Tausch gesendet wird")]
        public ConsoleMessage SwapSuccessful { get; set; } = new("Swap successful!", "green");
        [Description("The console message to send to the receiver of a swap request that has timed out.")]
        public ConsoleMessage TimeoutReceiver { get; set; } = new("Your swap request has timed out.", "red");
        [Description("Die Nachricht welche in die Konsole vom Absender geschickt wird wenn die Anfrage an einen anderen Spieler ausgelaufen ist.")]
        public ConsoleMessage TimeoutSender { get; set; } = new("Der Spieler hat nicht auf deine Anfrage geantwortet.", "red");
    }
}