using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using MEC;

namespace InfiniteAmmo.Event.PlayerEvent
{
    public class Reloading
    {
        public static void Reload(ReloadingWeaponEventArgs e)
        {
            Player player = e.Player;
            Firearm firearm = e.Firearm;
            Timing.CallDelayed(0.5f, () =>
            {
                player.SetAmmo(firearm.AmmoType, (ushort)(firearm.MaxMagazineAmmo + 1));
            });
        }
    }
}
