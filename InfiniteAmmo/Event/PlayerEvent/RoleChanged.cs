using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using MEC;

namespace InfiniteAmmo.Event.PlayerEvent
{
    public class ChangingRole
    {
        public static void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player == null || !ev.Player.IsConnected)
                return;
            Timing.CallDelayed(1f, () =>
            {
                ev.Player.SetAmmo(AmmoType.Nato556, 1);
                ev.Player.SetAmmo(AmmoType.Nato762, 1);
                ev.Player.SetAmmo(AmmoType.Nato9, 1);
                ev.Player.SetAmmo(AmmoType.Ammo12Gauge, 1);
                ev.Player.SetAmmo(AmmoType.Ammo44Cal, 1);
            });
        }
    }
}
