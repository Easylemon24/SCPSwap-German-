using System.ComponentModel;
using PlayerRoles;

namespace SCPSwap_NWAPI
{
    public class Config
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Die Dauer, in Sekunden, welche eine Tauschanfrage existiert bevor sie automatisch gelöscht wird.")]
        public float RequestTimeout { get; set; } = 20f;
        
        [Description("Die Dauer, in Sekunden, welche ein Spieler nach Rundenbeginn hat um eine Tauschanfrage zu senden.")]
        public float SwapTimeout { get; set; } = 60f;

        [Description("Eine Sammlung von SCP's welche Gesperrt sind. Diese Können nicht Getauscht werden und können auch keine Tauschanfragen senden.")]
        public RoleTypeId[] BlacklistedScps { get; set; } =
        {
            RoleTypeId.Scp0492,
        };
    }
}